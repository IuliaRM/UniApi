using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DepartamentController : DnnApiController
    {
        private readonly DepartamentRepo _repo = new DepartamentRepo();

        [HttpGet]
        public IHttpActionResult DepartamentGet(long idDepartament)
        {
            var departament = _repo.DepartamentGet(idDepartament);
            if (departament != null)
            {
                return Ok(departament);
            }
            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult DepartamentList()
        {
            var departamente = _repo.DepartamentList();
            return Ok(departamente);
        }

        [HttpPost]
        public IHttpActionResult DepartamentAdd([FromBody] DepartamentInfo objDepartament)
        {
            int id = _repo.DepartamentAdd(objDepartament);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult DepartamentUpdate([FromBody] DepartamentInfo objDepartament)
        {
            _repo.DepartamentUpdate(objDepartament);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DepartamentDelete(long idDepartament)
        {
            var departament = _repo.DepartamentGet(idDepartament);
            if (departament == null)
            {
                return NotFound();
            }
            _repo.DepartamentDelete(idDepartament);
            return Ok();
        }
    }
}