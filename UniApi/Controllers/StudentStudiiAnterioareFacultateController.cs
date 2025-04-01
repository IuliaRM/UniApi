using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class StudentStudiiAnterioareFacultateController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult StudentStudiiAnterioareFacultateGet(long id)
        {
            var repo = new StudentStudiiAnterioareFacultateRepo();
            var result = repo.StudentStudiiAnterioareFacultateGet(id);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentStudiiAnterioareFacultateListGet()
        {
            var repo = new StudentStudiiAnterioareFacultateRepo();
            var result = repo.StudentStudiiAnterioareFacultateListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentStudiiAnterioareFacultateListByStudentGet(long idStudent)
        {
            var repo = new StudentStudiiAnterioareFacultateRepo();
            var result = repo.StudentStudiiAnterioareFacultateListByStudentGet(idStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult StudentStudiiAnterioareFacultateAdd([FromBody] StudentStudiiAnterioareFacultateInfo info)
        {
            var repo = new StudentStudiiAnterioareFacultateRepo();
            var id = repo.StudentStudiiAnterioareFacultateAdd(info);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult StudentStudiiAnterioareFacultateUpdate([FromBody] StudentStudiiAnterioareFacultateInfo info)
        {
            var repo = new StudentStudiiAnterioareFacultateRepo();
            repo.StudentStudiiAnterioareFacultateUpdate(info);
            return Ok();
        }
    }
}
