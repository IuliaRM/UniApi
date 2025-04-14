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
        private readonly IStudentStudiiAnterioareFacultateRepo _repo = new StudentStudiiAnterioareFacultateRepo();

        public StudentStudiiAnterioareFacultateController()
        {

        }

        [HttpGet]
        public IHttpActionResult StudentStudiiAnterioareFacultateGet(long id)
        {
            var result = _repo.StudentStudiiAnterioareFacultateGet(id);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentStudiiAnterioareFacultateListByStudentGet(long idStudent)
        {
            var result = _repo.StudentStudiiAnterioareFacultateListByStudent(idStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult StudentStudiiAnterioareFacultateAdd([FromBody] StudentStudiiAnterioareFacultateInfo info)
        {
            if (info == null)
            {
                return BadRequest("Obiectul info nu poate fi null.");
            }
            var id = _repo.StudentStudiiAnterioareFacultateAdd(info);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult StudentStudiiAnterioareFacultateUpdate([FromBody] StudentStudiiAnterioareFacultateInfo info)
        {
            if (info == null)
            {
                return BadRequest("Obiectul info nu poate fi null.");
            }
            _repo.StudentStudiiAnterioareFacultateUpdate(info);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult StudentStudiiAnterioareFacultateDelete(long id)
        {
            _repo.StudentStudiiAnterioareFacultateDelete(id);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult StudentStudiiAnterioareFacultateDeleteByIdCandidatFacultate(long idCandidatFacultate)
        {
            _repo.StudentStudiiAnterioareFacultateDeleteByIdCandidatFacultate(idCandidatFacultate);
            return Ok();
        }
    }
}