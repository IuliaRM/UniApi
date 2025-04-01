using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ProfesorGradDidacticController : DnnApiController
    {
        private readonly ProfesorGradDidacticRepo _repo = new ProfesorGradDidacticRepo();

        [HttpGet]
        public IHttpActionResult GradDidacticActivGet(long idProfesor)
        {
            var result = _repo.GradDidacticActivGet(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GradDidacticActivAnUnivGet(long idProfesor, long idAnUniv)
        {
            var result = _repo.GradDidacticActivAnUnivGet(idProfesor, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GradDidacticListByProfesorGet(long idProfesor)
        {
            var result = _repo.GradDidacticListByProfesorGet(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GradDidacticListByTipGradDidacticGet(long idTipGradDidactic)
        {
            var result = _repo.GradDidacticListByTipGradDidacticGet(idTipGradDidactic);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ProfesorGradDidacticAdd([FromBody] ProfesorGradDidacticInfo profesorGradDidactic)
        {
            var id = _repo.ProfesorGradDidacticAdd(profesorGradDidactic);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ProfesorGradDidacticUpdate([FromBody] ProfesorGradDidacticInfo profesorGradDidactic)
        {
            _repo.ProfesorGradDidacticUpdate(profesorGradDidactic);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProfesorGradDidacticDelete([FromBody] ProfesorGradDidacticInfo profesorGradDidactic)
        {
            _repo.ProfesorGradDidacticDelete(profesorGradDidactic);
            return Ok();
        }
    }
}
