using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ReducereTaxaStudentController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentGet(long idReducereStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            var result = repo.ReducereTaxaStudentGet(idReducereStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentByTaxaStudentGet(long idTaxaStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            var result = repo.ReducereTaxaStudentByTaxaStudentGet(idTaxaStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListGet()
        {
            var repo = new ReducereTaxaStudentRepo();
            var result = repo.ReducereTaxaStudentListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListByTipReducereGet(long idTipReducere)
        {
            var repo = new ReducereTaxaStudentRepo();
            var result = repo.ReducereTaxaStudentListByTipReducereGet(idTipReducere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListByStudentGet(long idStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            var result = repo.ReducereTaxaStudentListByStudentGet(idStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ReducereTaxaStudentAdd([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            var id = repo.ReducereTaxaStudentAdd(objReducereTaxaStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ReducereTaxaStudentUpdate([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            repo.ReducereTaxaStudentUpdate(objReducereTaxaStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ReducereTaxaStudentDelete([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            var repo = new ReducereTaxaStudentRepo();
            repo.ReducereTaxaStudentDelete(objReducereTaxaStudent);
            return Ok();
        }
    }
}
