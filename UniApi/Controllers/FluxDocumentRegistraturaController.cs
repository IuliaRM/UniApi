using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class FluxDocumentRegistraturaController : DnnApiController
    {
        private readonly FluxDocumentRegistraturaRepo _repo = new FluxDocumentRegistraturaRepo();

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaGet(long ID_FluxDocReg)
        {
            var flux = _repo.FluxDocumentRegistraturaGet(ID_FluxDocReg);
            return Ok(flux);
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaListGet()
        {
            var fluxuri = _repo.FluxDocumentRegistraturaListGet();
            return Ok(fluxuri);
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaListByDocumentRegistraturaGet(long ID_DocReg, int AnCalendaristic)
        {
            var fluxuri = _repo.FluxDocumentRegistraturaListByDocumentRegistraturaGet(ID_DocReg, AnCalendaristic);
            return Ok(fluxuri);
        }

        [HttpPost]
        public IHttpActionResult FluxDocumentRegistraturaAdd([FromBody] FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            var id = _repo.FluxDocumentRegistraturaAdd(objFluxDocumentRegistratura);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult FluxDocumentRegistraturaUpdate([FromBody] FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            _repo.FluxDocumentRegistraturaUpdate(objFluxDocumentRegistratura);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult FluxDocumentRegistraturaDelete([FromBody] FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            _repo.FluxDocumentRegistraturaDelete(objFluxDocumentRegistratura);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult FluxDocumentRegistraturaStatisticiByAnGet(int AnCalendaristic)
        {
            var statistici = _repo.FluxDocumentRegistraturaStatisticiByAnGet(AnCalendaristic);
            return Ok(statistici);
        }
    }
}
