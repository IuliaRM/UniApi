using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class PostProfesorController : DnnApiController
    {
        private readonly PostProfesorRepo _repo = new PostProfesorRepo();

        [HttpGet]
        public IHttpActionResult PostProfesorGet(long idPostProfesor)
        {
            var result = _repo.PostProfesorGet(idPostProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListGet()
        {
            var result = _repo.PostProfesorListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            var result = _repo.PostProfesorListByDetaliuPlanSemestruProfesorGet(idDetaliuPlanSemestruProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByPostGet(long idPost)
        {
            var result = _repo.PostProfesorListByPostGet(idPost);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PostProfesorAdd([FromBody] PostProfesorInfo postProfesorInfo)
        {
            var id = _repo.PostProfesorAdd(postProfesorInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PostProfesorUpdate([FromBody] PostProfesorInfo postProfesorInfo)
        {
            _repo.PostProfesorUpdate(postProfesorInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PostProfesorDelete(long idPostProfesor)
        {
            _repo.PostProfesorDelete(idPostProfesor);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ProcentOreConventionaleByProfesorGet(long idProfesor, long idAnUniv, long idScenariu)
        {
            var result = _repo.ProcentOreConventionaleByProfesorGet(idProfesor, idAnUniv, idScenariu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProcentOreConventionaleByProfesorSemestruGet(long idProfesor, long idAnUniv, long idScenariu)
        {
            var result = _repo.ProcentOreConventionaleByProfesorSemestruGet(idProfesor, idAnUniv, idScenariu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProcentOreConventionaleByPostProfesorGet(long idPost, long idProfesor, long idAnUniv, long idScenariu)
        {
            var result = _repo.ProcentOreConventionaleByPostProfesorGet(idPost, idProfesor, idAnUniv, idScenariu);
            return Ok(result);
        }
    }
}
