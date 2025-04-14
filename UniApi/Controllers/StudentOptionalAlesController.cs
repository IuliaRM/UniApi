using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class StudentOptionalAlesController : DnnApiController
    {
        private readonly IStudentOptionalAlesRepo _repo = new StudentOptionalAlesRepo();

        public StudentOptionalAlesController()
        {

        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesGet(long idStudentOptionalAles)
        {
            var result = _repo.StudentOptionalAlesGet(idStudentOptionalAles);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListGet()
        {
            var result = _repo.StudentOptionalAlesList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListByStudentGet(long idStudent)
        {
            var result = _repo.StudentOptionalAlesListByStudent(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            var result = _repo.StudentOptionalAlesListByDetaliuPlanSemestru(idDetaliuPlanSemestru);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult StudentOptionalAlesAdd([FromBody] StudentOptionalAlesInfo studentOptionalAles)
        {
            if (studentOptionalAles == null)
            {
                return BadRequest("Obiectul studentOptionalAles nu poate fi null.");
            }
            var id = _repo.StudentOptionalAlesAdd(studentOptionalAles);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult StudentOptionalAlesUpdate([FromBody] StudentOptionalAlesInfo studentOptionalAles)
        {
            if (studentOptionalAles == null)
            {
                return BadRequest("Obiectul studentOptionalAles nu poate fi null.");
            }
            _repo.StudentOptionalAlesUpdate(studentOptionalAles);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult StudentOptionalAlesDelete(long idStudentOptionalAles)
        {
            _repo.StudentOptionalAlesDelete(idStudentOptionalAles);
            return Ok();
        }
    }
}