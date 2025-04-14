using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class ReducereTaxaStudentController : DnnApiController
    {
        private readonly IReducereTaxaStudentRepo _repo = new ReducereTaxaStudentRepo();

        public ReducereTaxaStudentController()
        {

        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentGet(long idReducereStudent)
        {
            var result = _repo.ReducereTaxaStudentGet(idReducereStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentByTaxaStudentGet(long idTaxaStudent)
        {
            var result = _repo.ReducereTaxaStudentGetByTaxaStudent(idTaxaStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListGet()
        {
            var result = _repo.ReducereTaxaStudentList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListByStudentGet(long idStudent)
        {
            var result = _repo.ReducereTaxaStudentListByStudent(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListByTaxaStudentStudentGet(long idTaxaStudent, long idStudent)
        {
            var result = _repo.ReducereTaxaStudentListByTaxaStudentStudent(idTaxaStudent, idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ReducereTaxaStudentListByTipReducereGet(long idTipReducere)
        {
            var result = _repo.ReducereTaxaStudentListByTipReducere(idTipReducere);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ReducereTaxaStudentAdd([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            if (objReducereTaxaStudent == null)
            {
                return BadRequest("Obiectul objReducereTaxaStudent nu poate fi null.");
            }
            var id = _repo.ReducereTaxaStudentAdd(objReducereTaxaStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ReducereTaxaStudentUpdate([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            if (objReducereTaxaStudent == null)
            {
                return BadRequest("Obiectul objReducereTaxaStudent nu poate fi null.");
            }
            _repo.ReducereTaxaStudentUpdate(objReducereTaxaStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ReducereTaxaStudentDelete([FromBody] ReducereTaxaStudentInfo objReducereTaxaStudent)
        {
            if (objReducereTaxaStudent == null)
            {
                return BadRequest("Obiectul objReducereTaxaStudent nu poate fi null.");
            }
            _repo.ReducereTaxaStudentDelete(objReducereTaxaStudent.ID_ReducereStudent);
            return Ok();
        }
    }
}