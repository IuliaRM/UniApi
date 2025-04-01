using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class SesiuneExameneSpecializareController : DnnApiController
    {

        [HttpGet]
        public IHttpActionResult SesiuneExameneSpecializareGet(long idSesiuneExameneSpecializare)
        {
            var result = SesiuneExameneSpecializareGet(idSesiuneExameneSpecializare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SesiuneExameneSpecializareAdd([FromBody] SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            var id = SesiuneExameneSpecializareAdd(sesiuneInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult SesiuneExameneSpecializareUpdate([FromBody] SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            SesiuneExameneSpecializareUpdate(sesiuneInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult NumaiStudentiiDinMetaCurentaUpdate(long idSesiuneExameneSpecializare, bool numaiStudentiiDinMetaCurenta)
        {
           NumaiStudentiiDinMetaCurentaUpdate(idSesiuneExameneSpecializare, numaiStudentiiDinMetaCurenta);
            return Ok();
        }
    }
}
