using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CatedraProfesorController : DnnApiController
    {
        private readonly CatedraProfesorRepo _repo = new CatedraProfesorRepo();

        [HttpGet]
        public IHttpActionResult CatedraProfesorGet(long idCatedraProfesor)
        {
            var catedraProfesor = _repo.CatedraProfesorGet(idCatedraProfesor);
            return catedraProfesor != null ? Ok(catedraProfesor) : NotFound();
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorList()
        {
            var catedreProfesori = _repo.CatedraProfesorList();
            return Ok(catedreProfesori);
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedra(long idCatedra)
        {
            var catedreProfesori = _repo.CatedraProfesorListByCatedra(idCatedra);
            return Ok(catedreProfesori);
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            var catedreProfesori = _repo.CatedraProfesorListByCatedraAnUniv(idCatedra, idAnUniv);
            return Ok(catedreProfesori);
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByProfesor(long idProfesor)
        {
            var catedreProfesori = _repo.CatedraProfesorListByProfesor(idProfesor);
            return Ok(catedreProfesori);
        }

        [HttpPost]
        public IHttpActionResult CatedraProfesorAdd([FromBody] CatedraProfesorInfo catedraProfesor)
        {
            int id = _repo.CatedraProfesorAdd(catedraProfesor);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult CatedraProfesorUpdate([FromBody] CatedraProfesorInfo catedraProfesor)
        {
            _repo.CatedraProfesorUpdate(catedraProfesor);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult CatedraProfesorDelete(long idCatedraProfesor)
        {
            var catedraProfesor = _repo.CatedraProfesorGet(idCatedraProfesor);
            if (catedraProfesor == null)
            {
                return NotFound();
            }
            _repo.CatedraProfesorDelete(idCatedraProfesor);
            return Ok();
        }
    }
}
