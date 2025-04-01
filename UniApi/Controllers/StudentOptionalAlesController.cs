using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class StudentOptionalAlesController : DnnApiController
    {

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesGet(long idStudentOptionalAles)
        {
            var result = StudentOptionalAlesGet(idStudentOptionalAles);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListGet()
        {
            var result = StudentOptionalAlesListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListByStudentGet(long idStudent)
        {
            var result = StudentOptionalAlesListByStudentGet(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentOptionalAlesListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            var result = StudentOptionalAlesListByDetaliuPlanSemestruGet(idDetaliuPlanSemestru);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult StudentOptionalAlesAdd([FromBody] StudentOptionalAlesInfo studentOptionalAles)
        {
            var id = StudentOptionalAlesAdd(studentOptionalAles);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult StudentOptionalAlesUpdate([FromBody] StudentOptionalAlesInfo studentOptionalAles)
        {
            StudentOptionalAlesUpdate(studentOptionalAles);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult StudentOptionalAlesDelete(long idStudentOptionalAles)
        {
            StudentOptionalAlesDelete(idStudentOptionalAles);
            return Ok();
        }
    }
}
