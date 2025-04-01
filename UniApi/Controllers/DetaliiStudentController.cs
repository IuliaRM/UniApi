using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DetaliiStudentController : DnnApiController
    {
        private readonly DetaliiStudentRepo _repo = new DetaliiStudentRepo();

        [HttpGet]
        public IHttpActionResult StudentListByIdAndAnUniv([FromUri] List<long> listaID_Student, long idAnUniv)
        {
            var studenti = _repo.StudentListByIdAndAnUniv(listaID_Student, idAnUniv);
            return Ok(studenti);
        }

        [HttpGet]
        public IHttpActionResult UsernameExistent(string username)
        {
            bool exists = _repo.UsernameExistent(username);
            return Ok(exists);
        }

        [HttpPost]
        public IHttpActionResult StudentUserPassEmailAdd(long idStudent, string user, string pass, string email)
        {
            _repo.StudentUserPassEmailAdd(idStudent, user, pass, email);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult StudentUsernameGetByCNP(string cnp)
        {
            var username = _repo.StudentUsernameGetByCNP(cnp);
            return Ok(username);
        }

        [HttpGet]
        public IHttpActionResult StudentUsernameGetByNumePrenumeDataN(string nume, string prenume, DateTime data)
        {
            var username = _repo.StudentUsernameGetByNumePrenumeDataN(nume, prenume, data);
            return Ok(username);
        }

        [HttpGet]
        public IHttpActionResult StudentParolaGetByUsername(string user)
        {
            var parola = _repo.StudentParolaGetByUsername(user);
            return Ok(parola);
        }

        [HttpPut]
        public IHttpActionResult StudentParolaUpdateByUsername(string username)
        {
            _repo.StudentParolaUpdateByUsername(username);
            return Ok();
        }
    }
}
