using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class ProfesorGradDidacticController : DnnApiController
    {
        private readonly IProfesorGradDidacticRepo _repo = new ProfesorGradDidacticRepo();

        public ProfesorGradDidacticController()
        {

        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticGet(long idProfesorGradDidactic)
        {
            var result = _repo.ProfesorGradDidacticGet(idProfesorGradDidactic);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticGetGradDidacticActiv(long idProfesor)
        {
            var result = _repo.ProfesorGradDidacticGetGradDidacticActiv(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticGetGradDidacticActivAnUniv(long idProfesor, long idAnUniv)
        {
            var result = _repo.ProfesorGradDidacticGetGradDidacticActivAnUniv(idProfesor, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticList()
        {
            var result = _repo.ProfesorGradDidacticList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticListByProfesor(long idProfesor)
        {
            var result = _repo.ProfesorGradDidacticListByProfesor(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGradDidacticListByTipGradDidactic(long idTipGradDidactic)
        {
            var result = _repo.ProfesorGradDidacticListByTipGradDidactic(idTipGradDidactic);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ProfesorGradDidacticAdd([FromBody] ProfesorGradDidacticInfo profesorGradDidactic)
        {
            if (profesorGradDidactic == null)
            {
                return BadRequest("Obiectul profesorGradDidactic nu poate fi null.");
            }
            var id = _repo.ProfesorGradDidacticAdd(profesorGradDidactic);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ProfesorGradDidacticUpdate([FromBody] ProfesorGradDidacticInfo profesorGradDidactic)
        {
            if (profesorGradDidactic == null)
            {
                return BadRequest("Obiectul profesorGradDidactic nu poate fi null.");
            }
            _repo.ProfesorGradDidacticUpdate(profesorGradDidactic);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProfesorGradDidacticDelete(long idProfesorGradDidactic)
        {
            _repo.ProfesorGradDidacticDelete(idProfesorGradDidactic);
            return Ok();
        }
    }
}