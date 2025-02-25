using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AnUniversitarController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AnUniversitarGet(long idAnUniv)
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarGet(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarListByUtilizator(int idUtilizator)
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarListByUtilizator(idUtilizator);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarListAll()
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarListAll();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarGetByAnCalendaristic(int anCalendaristic)
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarGetByAnCalendaristic(anCalendaristic);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AnUniversitarAdd([FromBody] AnUniversitarInfo anUniversitarInfo)
        {
            var repo = new AnUniversitarRepo();
            var id = repo.AnUniversitarAdd(anUniversitarInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AnUniversitarUpdate([FromBody] AnUniversitarInfo anUniversitarInfo)
        {
            var repo = new AnUniversitarRepo();
            repo.AnUniversitarUpdate(anUniversitarInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AnUniversitarDelete(long idAnUniv)
        {
            var repo = new AnUniversitarRepo();
            repo.AnUniversitarDelete(idAnUniv);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarGetNextYear(long idAnUniversitarCurent)
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarGetNextYear(idAnUniversitarCurent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarListWithPrecedent()
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarListWithPrecedent();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarGetPreviousYear(long idAnUniversitarCurent)
        {
            var repo = new AnUniversitarRepo();
            var result = repo.AnUniversitarGetPreviousYear(idAnUniversitarCurent);
            return Ok(result);
        }
    }
}
