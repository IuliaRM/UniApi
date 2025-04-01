using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ValoareBursaStudentController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult ValoareBursaStudentGet(long idValoareBursa)
        {
            var repo = new ValoareBursaStudentRepo();
            var result = repo.ValoareBursaStudentGet(idValoareBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentByBursaLunaGet(long idBursa, int numarLuna, long idAnUnivBursa)
        {
            var repo = new ValoareBursaStudentRepo();
            var result = repo.ValoareBursaStudentByBursaLunaGet(idBursa, numarLuna, idAnUnivBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentListGet()
        {
            var repo = new ValoareBursaStudentRepo();
            var result = repo.ValoareBursaStudentListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentListByLunaGet(int numarLuna)
        {
            var repo = new ValoareBursaStudentRepo();
            var result = repo.ValoareBursaStudentListByLunaGet(numarLuna);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentListByBursaGet(long idBursa)
        {
            var repo = new ValoareBursaStudentRepo();
            var result = repo.ValoareBursaStudentListByBursaGet(idBursa);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ValoareBursaStudentAdd([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            var repo = new ValoareBursaStudentRepo();
            var id = repo.ValoareBursaStudentAdd(valoareBursaStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ValoareBursaStudentUpdate([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            var repo = new ValoareBursaStudentRepo();
            repo.ValoareBursaStudentUpdate(valoareBursaStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ValoareBursaStudentDelete([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            var repo = new ValoareBursaStudentRepo();
            repo.ValoareBursaStudentDelete(valoareBursaStudent);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult BugetRamasUpdate([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            var repo = new ValoareBursaStudentRepo();
            repo.BugetRamasUpdate(valoareBursaStudent);
            return Ok();
        }
    }
}
