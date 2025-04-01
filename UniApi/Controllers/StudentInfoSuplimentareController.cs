using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class StudentInfoSuplimentareController : DnnApiController
    {

        [HttpPost]
        public IHttpActionResult StudentInfoSuplimentaraAdd([FromBody] StudentInfoSuplimentare sis)
        {
            var id = StudentInfoSuplimentaraAdd(sis);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult StudentInfoSuplimentaraUpdate([FromBody] StudentInfoSuplimentare sis)
        {
            var id = StudentInfoSuplimentaraUpdate(sis);
            return Ok(id);
        }

        [HttpDelete]
        public IHttpActionResult StudentInfoSuplimentaraDelete(long idStudentInfo)
        {
            StudentInfoSuplimentaraDelete(idStudentInfo);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult StudentInfoSuplimentaraListGet(long idStudent)
        {
            var result = StudentInfoSuplimentaraListGet(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentInfoSuplimentaraListByTipGet(long idStudent, string tip)
        {
            var result = StudentInfoSuplimentaraListByTipGet(idStudent, tip);
            return Ok(result);
        }
    }
}
