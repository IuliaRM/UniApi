using System;
using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class SportNeprofilController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult SportNeprofilGet(long idSportNeprofil)
        {
            var repo = new SportNeprofilRepo();
            var result = repo.SportNeprofilGet(idSportNeprofil);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilListByAnUniversitarGet(long idAnUniv, int nrSemestru)
        {
            var repo = new SportNeprofilRepo();
            var result = repo.SportNeprofilListByAnUniversitarGet(idAnUniv, nrSemestru);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilListByAnUniversitarFacultateGet(long idAnUniv, long idFacultate, int nrSemestru)
        {
            var repo = new SportNeprofilRepo();
            var result = repo.SportNeprofilListByAnUniversitarFacultateGet(idAnUniv, idFacultate, nrSemestru);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilListByFacultateGet(long idFacultate)
        {
            var repo = new SportNeprofilRepo();
            var result = repo.SportNeprofilListByFacultateGet(idFacultate);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SportNeprofilAdd([FromBody] SportNeprofilInfo sportNeprofilInfo)
        {
            var repo = new SportNeprofilRepo();
            var id = repo.SportNeprofilAdd(sportNeprofilInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult SportNeprofilUpdate([FromBody] SportNeprofilInfo sportNeprofilInfo)
        {
            var repo = new SportNeprofilRepo();
            repo.SportNeprofilUpdate(sportNeprofilInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult SportNeprofilDelete(long idSportNeprofil)
        {
            var repo = new SportNeprofilRepo();
            repo.SportNeprofilDelete(idSportNeprofil);
            return Ok();
        }
    }
}
