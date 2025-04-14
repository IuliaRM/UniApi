using System;
using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class SportNeprofilController : DnnApiController
    {
        private readonly ISportNeprofilRepo _repo = new SportNeprofilRepo();

        public SportNeprofilController()
        {

        }


        [HttpGet]
        public IHttpActionResult SportNeprofilGet(long idSportNeprofil)
        {
            var result = _repo.SportNeprofilGet(idSportNeprofil);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilListByAnUniversitarFacultateGet(long idAnUniv, long idFacultate)
        {
            var result = _repo.SportNeprofilListByAnUniversitarFacultate(idAnUniv, idFacultate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilListByFacultateGet(long idFacultate)
        {
            var result = _repo.SportNeprofilListByFacultate(idFacultate);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SportNeprofilAdd([FromBody] SportNeprofilInfo sportNeprofilInfo)
        {
            if (sportNeprofilInfo == null)
            {
                return BadRequest("Obiectul sportNeprofilInfo nu poate fi null.");
            }
            var id = _repo.SportNeprofilAdd(sportNeprofilInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult SportNeprofilUpdate([FromBody] SportNeprofilInfo sportNeprofilInfo)
        {
            if (sportNeprofilInfo == null)
            {
                return BadRequest("Obiectul sportNeprofilInfo nu poate fi null.");
            }
            _repo.SportNeprofilUpdate(sportNeprofilInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult SportNeprofilDelete(long idSportNeprofil)
        {
            _repo.SportNeprofilDelete(idSportNeprofil);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult SportNeprofilUpdateAsistentExamen(long idSportNeprofil, long? idAsistentExamen)
        {
            _repo.SportNeprofilUpdateAsistentExamen(idSportNeprofil, idAsistentExamen);
            return Ok();
        }
    }
}