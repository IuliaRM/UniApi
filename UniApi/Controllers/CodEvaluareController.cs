using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CodEvaluareController : DnnApiController
    {
        private readonly ICodEvaluareRepo _repo = new CodEvaluareRepo();

        public CodEvaluareController()
        {

        }

        public CodEvaluareController(ICodEvaluareRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult CodEvaluareAdd([FromBody] CodEvaluareInfo info)
        {
            try
            {
                var id = _repo.CodEvaluareAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CodEvaluareUpdate([FromBody] CodEvaluareInfo info)
        {
            try
            {
                _repo.CodEvaluareUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult CodEvaluareDelete(long idCodEvaluare)
        {
            try
            {
                _repo.CodEvaluareDelete(idCodEvaluare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareGet(long idCodEvaluare)
        {
            try
            {
                var cod = _repo.CodEvaluareGet(idCodEvaluare);
                return cod != null ? (IHttpActionResult)Ok(cod) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareList()
        {
            try
            {
                var list = _repo.CodEvaluareList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListByProfesor(long idProfesor)
        {
            try
            {
                var list = _repo.CodEvaluareListByProfesor(idProfesor);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListBySefCatedra(long idSefCatedra)
        {
            try
            {
                var list = _repo.CodEvaluareListBySefCatedra(idSefCatedra);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListBySpecializareSemestru(long idSpecializare, int semestru)
        {
            try
            {
                var list = _repo.CodEvaluareListBySpecializareSemestru(idSpecializare, semestru);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListByUserIdRol(long idUser, long idRol)
        {
            try
            {
                var list = _repo.CodEvaluareListByUserIdRol(idUser, idRol);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListByUsernameRole(string username, string role)
        {
            try
            {
                var list = _repo.CodEvaluareListByUsernameRole(username, role);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareExamneListByAnUnivSesiuneActiva(long idAnUniv)
        {
            try
            {
                var list = _repo.CodEvaluareExamneListByAnUnivSesiuneActiva(idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CodEvaluareUpdateDataEmail(long idCodEvaluare, DateTime dataTrimitere)
        {
            try
            {
                _repo.CodEvaluareUpdateDataEmail(idCodEvaluare, dataTrimitere);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
