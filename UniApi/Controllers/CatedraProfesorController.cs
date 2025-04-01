using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class CatedraProfesorController : DnnApiController
    {
        private readonly CatedraProfesorRepo _repo = new CatedraProfesorRepo();

        [HttpGet]
        public IHttpActionResult CatedraProfesorGet(long idCatedraProfesor)
        {
            var repo = new CatedraProfesorRepo(); // Use CatedraProfesorRepo, not CatedraRepo
            var catedraProfesor = repo.CatedraProfesorGet(idCatedraProfesor); // Fetch data

            if (catedraProfesor != null)
            {
                return Ok(catedraProfesor);
            }
            else
            {
                return NotFound();
            }
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
            var repo = new CatedraProfesorRepo(); // Use CatedraProfesorRepo, not CatedraRepo
            long id = repo.CatedraProfesorAdd(catedraProfesor); // Call the correct method

            if (id > 0)
            {
                return Ok(id); // Return the new ID if successful
            }
            else
            {
                return BadRequest("Eroare la adãugarea profesorului în catedrã."); // Handle failure
            }
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
