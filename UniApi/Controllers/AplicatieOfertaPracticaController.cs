using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    

    public class AplicatieOfertaPracticaController : DnnApiController
    {
        private readonly IAplicatieOfertaPracticaRepo _repo = new AplicatieOfertaPracticaRepo();

        public AplicatieOfertaPracticaController()
        {
        }

        public AplicatieOfertaPracticaController(IAplicatieOfertaPracticaRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult AplicatieOfertaPracticaAdd([FromBody] AplicatieOfertaPractica aplicatie)
        {
            try
            {
                _repo.AplicatieOfertaPracticaAdd(aplicatie);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AplicatieOfertaPracticaUpdate([FromBody] AplicatieOfertaPractica aplicatie)
        {
            try
            {
                _repo.AplicatieOfertaPracticaUpdate(aplicatie);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AplicatieOfertaPracticaDelete(long idAplicatie)
        {
            try
            {
                _repo.AplicatieOfertaPracticaDelete(idAplicatie);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaGet(long idAplicatie)
        {
            try
            {
                var aplicatie = _repo.AplicatieOfertaPracticaGet(idAplicatie);
                if (aplicatie == null)
                    return NotFound();

                return Ok(aplicatie);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaList()
        {
            try
            {
                var list = _repo.AplicatieOfertaPracticaList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaListByIDFirma(long idFirma)
        {
            try
            {
                var list = _repo.AplicatieOfertaPracticaListByIDFirma(idFirma);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaListIDOfPracFac(long idOfertaPracticaFacultate)
        {
            try
            {
                var list = _repo.AplicatieOfertaPracticaListIDOfPracFac(idOfertaPracticaFacultate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaListByStudent(long idStudent)
        {
            try
            {
                var list = _repo.AplicatieOfertaPracticaListByStudent(idStudent);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaGetTotalCountByIDOPracticaFac(long idOfertaPracticaFacultate)
        {
            try
            {
                int count = _repo.AplicatieOfertaPracticaGetTotalCountByIDOPracticaFac(idOfertaPracticaFacultate);
                return Ok(count);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
