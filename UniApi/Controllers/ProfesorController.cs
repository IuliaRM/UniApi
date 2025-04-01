using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ProfesorController : DnnApiController
    {
        private readonly ProfesorRepo _repo = new ProfesorRepo();

        [HttpGet]
        public IHttpActionResult ProfesorGet(long idProfesor)
        {
            var result = _repo.ProfesorGet(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorByEmailGet(string emailProfesor)
        {
            var result = _repo.ProfesorByEmailGet(emailProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorByCNPGet(string cnp)
        {
            var result = _repo.ProfesorByCNPGet(cnp);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorByUsernameGet(string username)
        {
            var result = _repo.ProfesorByUsernameGet(username);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListGet()
        {
            var result = _repo.ProfesorListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByAnUnivGet(long idAnUniv)
        {
            var result = _repo.ProfesorListByAnUnivGet(idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ProfesorAdd([FromBody] ProfesorInfo profesorInfo)
        {
            var id = _repo.ProfesorAdd(profesorInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ProfesorUpdate([FromBody] ProfesorInfo profesorInfo)
        {
            _repo.ProfesorUpdate(profesorInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProfesorDelete(long idProfesor)
        {
            _repo.ProfesorDelete(idProfesor);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ProfesorPasswordUpdate([FromBody] dynamic data)
        {
            string username = data.username;
            string newPassword = data.newPassword;
            _repo.ProfesorPasswordUpdate(username, newPassword);
            return Ok();
        }
    }
}
