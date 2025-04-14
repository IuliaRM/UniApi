using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Collections.Generic;

namespace UniApi.Controllers
{

    public class OfertaPracticaFacultateController : DnnApiController
    {
        private readonly IOfertaPracticaFacultateRepo _repo = new OfertaPracticaFacultateRepo();

        public OfertaPracticaFacultateController()
        {

        }

        public OfertaPracticaFacultateController(IOfertaPracticaFacultateRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateGet(long idOfertaPracticaFacultate)
        {
            try
            {
                var result = _repo.OfertaPracticaFacultateGet(idOfertaPracticaFacultate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateList()
        {
            try
            {
                var result = _repo.OfertaPracticaFacultateList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByFacAnStudSpecializDomFC(long idFacultate, long idAnStudiu, long idSpecializare, long idDomeniu, long idFC, int status, DateTime dataValabilitate)
        {
            try
            {
                var result = _repo.OfertaPracticaFacultateListByFacAnStudSpecializDomFC(idFacultate, idAnStudiu, idSpecializare, idDomeniu, idFC, status, dataValabilitate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByFacAnStudFC(long idFacultate, long idAnStudiu, long idFC, int status, DateTime dataValabilitate)
        {
            try
            {
                var result = _repo.OfertaPracticaFacultateListByFacAnStudFC(idFacultate, idAnStudiu, idFC, status, dataValabilitate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByIdOfertaPractica(long idOfertaPractica)
        {
            try
            {
                var result = _repo.OfertaPracticaFacultateListByIdOfertaPractica(idOfertaPractica);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult OfertaPracticaFacultateAdd([FromBody] OfertaPracticaFacultate info)
        {
            try
            {
                var id = _repo.OfertaPracticaFacultateAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult OfertaPracticaFacultateUpdate([FromBody] OfertaPracticaFacultate info)
        {
            try
            {
                _repo.OfertaPracticaFacultateUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult OfertaPracticaFacultateDelete(long idOfertaPracticaFacultate)
        {
            try
            {
                _repo.OfertaPracticaFacultateDelete(idOfertaPracticaFacultate);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
