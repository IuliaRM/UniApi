using System;
using System.Web.Http;
using System.Data;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class FluxDocumentRegistraturaController : DnnApiController
    {
        private readonly IFluxDocumentRegistraturaRepo _repo = new FluxDocumentRegistraturaRepo();

        public FluxDocumentRegistraturaController()
        {

        }

        public FluxDocumentRegistraturaController(IFluxDocumentRegistraturaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaGet(long id)
        {
            try
            {
                var result = _repo.FluxDocumentRegistraturaGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaList()
        {
            try
            {
                var result = _repo.FluxDocumentRegistraturaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaListByDocumentRegistratura(long idDocReg, int anCalendaristic)
        {
            try
            {
                var result = _repo.FluxDocumentRegistraturaListByDocumentRegistratura(idDocReg, anCalendaristic);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult FluxDocumentRegistraturaAdd([FromBody] FluxDocumentRegistraturaInfo info)
        {
            try
            {
                var id = _repo.FluxDocumentRegistraturaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult FluxDocumentRegistraturaUpdate([FromBody] FluxDocumentRegistraturaInfo info)
        {
            try
            {
                _repo.FluxDocumentRegistraturaUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult FluxDocumentRegistraturaDelete([FromBody] FluxDocumentRegistraturaInfo info)
        {
            try
            {
                _repo.FluxDocumentRegistraturaDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaStatisticiByAn(int anCalendaristic)
        {
            try
            {
                var result = _repo.FluxDocumentRegistraturaStatisticiByAn(anCalendaristic);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
