using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class SportNeprofilStudentController : DnnApiController
    {
        private readonly ISportNeprofilStudentRepo _repo = new SportNeprofilStudentRepo();

        public SportNeprofilStudentController()
        {

        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentGet(long idSportNeprofilStudent)
        {
            var result = _repo.SportNeprofilStudentGet(idSportNeprofilStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListBySportNeprofilGet(long idSportNeprofil)
        {
            var result = _repo.SportNeprofilStudentListBySportNeprofil(idSportNeprofil);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByStudentGet(long idStudent)
        {
            var result = _repo.SportNeprofilStudentListByStudent(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByStudentAnUnivGet(long idStudent, long idAnUniv)
        {
            var result = _repo.SportNeprofilStudentListByStudentAnUniv(idStudent, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByAnUniversitarGet(long idAnUniv)
        {
            var result = _repo.SportNeprofilStudentListByAnUniversitar(idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SportNeprofilStudentAdd([FromBody] SportNeprofilStudentInfo sportNeprofilStudent)
        {
            if (sportNeprofilStudent == null)
            {
                return BadRequest("Obiectul sportNeprofilStudent nu poate fi null.");
            }
            var id = _repo.SportNeprofilStudentAdd(sportNeprofilStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult SportNeprofilStudentUpdate([FromBody] SportNeprofilStudentInfo sportNeprofilStudent)
        {
            if (sportNeprofilStudent == null)
            {
                return BadRequest("Obiectul sportNeprofilStudent nu poate fi null.");
            }
            _repo.SportNeprofilStudentUpdate(sportNeprofilStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult SportNeprofilStudentDelete(long idSportNeprofilStudent)
        {
            _repo.SportNeprofilStudentDelete(idSportNeprofilStudent);
            return Ok();
        }
    }
}