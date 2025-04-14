using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class StudentContController : DnnApiController
    {
        private readonly StudentContRepo _repo = new StudentContRepo();

        public StudentContController() { }

        [HttpGet]
        public IHttpActionResult StudentListByIdAndAnUnivGet(List<long> listaID_Student, long ID_AnUniv)
        {
            var result = _repo.StudentListByIdAndAnUnivGet(listaID_Student, ID_AnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult StudentUserPassEmailAdd(long ID_Student, string user, string pass, string email)
        {
            _repo.StudentUserPassEmailAdd(ID_Student, user, pass, email);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult StudentUsernameByCNPGet(string cnp)
        {
            var result = _repo.StudentUsernameByCNPGet(cnp);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentUsernameListByEmailGet(string Email)
        {
            var result = _repo.StudentUsernameListByEmailGet(Email);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentUsernameByID_StudentGet(long ID_Student)
        {
            var result = _repo.StudentUsernameByID_StudentGet(ID_Student);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentByFacultateCicluFormaDomeniuSpecializareNumeCNPGet(long ID_Facultate, long ID_FC, long ID_FCF, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare, string Nume, string Prenume, string CNP)
        {
            var result = _repo.StudentByFacultateCicluFormaDomeniuSpecializareNumeCNPGet(ID_Facultate, ID_FC, ID_FCF, ID_Domeniu, ID_AnStudiu, ID_Specializare, Nume, Prenume, CNP);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ModificaParolaInAGSIS(string username, string ParolaNoua)
        {
            _repo.ModificaParolaInAGSIS(username, ParolaNoua);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult StudentListByAnUnivMaiMareDeAnGet(long ID_AnUniv, bool faraUsername)
        {
            var result = _repo.StudentListByAnUnivMaiMareDeAnGet(ID_AnUniv, faraUsername);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult StudentListByAnUnivLaMaiMulteFacultatiGet(long ID_AnUniv)
        {
            var result = _repo.StudentListByAnUnivLaMaiMulteFacultatiGet(ID_AnUniv);
            return Ok(result);
        }
    }
}