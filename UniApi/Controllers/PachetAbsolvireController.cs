using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PachetAbsolvireController : DnnApiController
    {
        private readonly IPachetAbsolvireRepo _repo = new PachetAbsolvireRepo();

        public PachetAbsolvireController()
        {

        }

        public PachetAbsolvireController(IPachetAbsolvireRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireGet(long idPachetAbsolvire)
        {
            try
            {
                var result = _repo.PachetAbsolvireGet(idPachetAbsolvire);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireListGet()
        {
            try
            {
                var result = _repo.PachetAbsolvireListGet();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpGet]
        public IHttpActionResult PachetAbsolvireGetByAnUnivIdSpecializare(long idAnUniv, long idSpecializare)
        {
            try
            {
                var result = _repo.PachetAbsolvireGetByAnUnivIdSpecializare(idAnUniv, idSpecializare);
                if (result == null || result.Count == 0)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log error (e.g., using ILogger)
                return InternalServerError(ex);
            }
        }


        [HttpGet]
        public IHttpActionResult PachetAbsolvireGetByStudent(long idStudent)
        {
            try
            {
                var result = _repo.PachetAbsolvireGetByStudent(idStudent);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireGetByAnUnivIdSpecializareActivaInscriereStudenti(long idAnUniv, long idSpecializare)
        {
            try
            {
                var result = _repo.PachetAbsolvireGetByAnUnivIdSpecializareActivaInscriereStudenti(idAnUniv, idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireGetByAnUnivUsernameSecretar(long idAnUniv, string usernameSecretar)
        {
            try
            {
                var result = _repo.PachetAbsolvireGetByAnUnivUsernameSecretar(idAnUniv, usernameSecretar);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireListSesiuneAbsolvire()
        {
            try
            {
                var result = _repo.PachetAbsolvireListSesiuneAbsolvire();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireListByIdSpecIdAnUniv(long idSpecializare, long idAnUniv)
        {
            try
            {
                var result = _repo.PachetAbsolvireListByIdSpecIdAnUniv(idSpecializare, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PachetAbsolvireAdd([FromBody] PachetAbsolvireInfo pachetAbs)
        {
            try
            {
                if (pachetAbs == null)
                    return BadRequest("Obiectul PachetAbsolvireInfo nu poate fi null");

                var id = _repo.PachetAbsolvireAdd(pachetAbs);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult PachetAbsolvireUpdate([FromBody] PachetAbsolvireInfo pachetAbs)
        {
            try
            {
                if (pachetAbs == null)
                    return BadRequest("Obiectul PachetAbsolvireInfo nu poate fi null");

                _repo.PachetAbsolvireUpdate(pachetAbs);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult PachetAbsolvireDeleteByIdPachetAbsolvire(long idPachetAbsolvire)
        {
            try
            {
                _repo.PachetAbsolvireDeleteByIdPachetAbsolvire(idPachetAbsolvire);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}