using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
   


    public class AbsolvireProgramController : DnnApiController
    {
        private readonly AbsolvireProgramRepo _repo = new AbsolvireProgramRepo();

        public AbsolvireProgramController()
        { 
        }



         

        [HttpGet]
        public IHttpActionResult AbsolvireProgramGet(long idAbsolvireProgram)
        {
            try
            {
                var result = _repo.AbsolvireProgramGet(idAbsolvireProgram);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramList()
        {
            try
            {
                var result = _repo.AbsolvireProgramList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramListBySpecializare(long idSpecializare)
        {
            try
            {
                var result = _repo.AbsolvireProgramListBySpecializare(idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramListByAnUniversitar(long idAnUniversitar)
        {
            try
            {
                var result = _repo.AbsolvireProgramListByAnUniversitar(idAnUniversitar);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramListByAnUnivFacDomSpec(long idAnUniversitar, long idFacultate, long idDomeniu, long idSpecializare)
        {
            try
            {
                var result = _repo.AbsolvireProgramListByAnUnivFacDomSpec(idAnUniversitar, idFacultate, idDomeniu, idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramGetBySpecializare(long idSpecializare)
        {
            try
            {
                var result = _repo.AbsolvireProgramGetBySpecializare(idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramGetBySpecializareSesiuneExamene(long idSpecializare, long idSesiune)
        {
            try
            {
                var result = _repo.AbsolvireProgramGetBySpecializareSesiuneExamene(idSpecializare, idSesiune);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireProgramAdd([FromBody] AbsolvireProgramInfo programInfo)
        {
            try
            {
                if (programInfo == null)
                    return BadRequest("Obiectul AbsolvireProgramInfo nu poate fi null");

                var id = _repo.AbsolvireProgramAdd(programInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AbsolvireProgramUpdate([FromBody] AbsolvireProgramInfo programInfo)
        {
            try
            {
                if (programInfo == null)
                    return BadRequest("Obiectul AbsolvireProgramInfo nu poate fi null");

                _repo.AbsolvireProgramUpdate(programInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireProgramDeleteBySpecializare(long idSpecializare)
        {
            try
            {
                _repo.AbsolvireProgramDeleteBySpecializare(idSpecializare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }

}
