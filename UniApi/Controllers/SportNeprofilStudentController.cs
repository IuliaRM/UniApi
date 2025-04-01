using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class SportNeprofilStudentController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult SportNeprofilStudentGet(long idSportNeprofilStudent)
        {
            var repo = new SportNeprofilStudentRepo();
            var result = repo.SportNeprofilStudentGet(idSportNeprofilStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListBySportNeprofilGet(long idSportNeprofil)
        {
            var repo = new SportNeprofilStudentRepo();
            var result = repo.SportNeprofilStudentListBySportNeprofilGet(idSportNeprofil);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByStudentGet(long idStudent)
        {
            var repo = new SportNeprofilStudentRepo();
            var result = repo.SportNeprofilStudentListByStudentGet(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByStudentAnUnivGet(long idStudent, long idAnUniv, int nrSemestru)
        {
            var repo = new SportNeprofilStudentRepo();
            var result = repo.SportNeprofilStudentListByStudentAnUnivGet(idStudent, idAnUniv, nrSemestru);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByAnUniversitarGet(long idAnUniv, int nrSemestru)
        {
            var repo = new SportNeprofilStudentRepo();
            var result = repo.SportNeprofilStudentListByAnUniversitarGet(idAnUniv, nrSemestru);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SportNeprofilStudentAdd([FromBody] SportNeprofilStudentInfo sportNeprofilStudent)
        {
            var repo = new SportNeprofilStudentRepo();
            var id = repo.SportNeprofilStudentAdd(sportNeprofilStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult SportNeprofilStudentUpdate([FromBody] SportNeprofilStudentInfo sportNeprofilStudent)
        {
            var repo = new SportNeprofilStudentRepo();
            repo.SportNeprofilStudentUpdate(sportNeprofilStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult SportNeprofilStudentDelete([FromBody] SportNeprofilStudentInfo sportNeprofilStudent)
        {
            var repo = new SportNeprofilStudentRepo();
            repo.SportNeprofilStudentDelete(sportNeprofilStudent);
            return Ok();
        }
    }
}
