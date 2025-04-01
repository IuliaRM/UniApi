using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DepartamentProfesorController : DnnApiController
    {
        private readonly DepartamentProfesorRepo _repo = new DepartamentProfesorRepo();

        [HttpGet]
        public IHttpActionResult DepartamentProfesorGet(long idDepartamentProfesor)
        {
            var departamentProfesor = _repo.DepartamentProfesorGet(idDepartamentProfesor);
            if (departamentProfesor != null)
            {
                return Ok(departamentProfesor);
            }
            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorGetByProfesor(long idProfesor)
        {
            var departamentProfesor = _repo.DepartamentProfesorGetByProfesor(idProfesor);
            if (departamentProfesor != null)
            {
                return Ok(departamentProfesor);
            }
            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorList()
        {
            var lista = _repo.DepartamentProfesorList();
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorListByDepartament(long idDepartament)
        {
            var lista = _repo.DepartamentProfesorListByDepartament(idDepartament);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorListByProfesor(long idProfesor)
        {
            var lista = _repo.DepartamentProfesorListByProfesor(idProfesor);
            return Ok(lista);
        }

        [HttpPost]
        public IHttpActionResult DepartamentProfesorAdd([FromBody] DepartamentProfesorInfo objDepartamentProfesor)
        {
            int id = _repo.DepartamentProfesorAdd(objDepartamentProfesor);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult DepartamentProfesorUpdate([FromBody] DepartamentProfesorInfo objDepartamentProfesor)
        {
            _repo.DepartamentProfesorUpdate(objDepartamentProfesor);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DepartamentProfesorDelete(long idDepartamentProfesor)
        {
            var departamentProfesor = _repo.DepartamentProfesorGet(idDepartamentProfesor);
            if (departamentProfesor == null)
            {
                return NotFound();
            }
            _repo.DepartamentProfesorDelete(idDepartamentProfesor);
            return Ok();
        }
    }
}
