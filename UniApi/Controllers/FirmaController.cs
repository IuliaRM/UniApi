using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{
    public class FirmaController : DnnApiController
    {
        private readonly IFirmaRepo _repo = new FirmaRepo();

        public FirmaController()
        {

        }

        public FirmaController(IFirmaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult FirmaGet(long idFirma)
        {
            try
            {
                var result = _repo.FirmaGet(idFirma);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FirmaByUserIdPortalGet(int idUserPortal)
        {
            try
            {
                var result = _repo.FirmaGetByUserIdPortal(idUserPortal);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FirmaList()
        {
            try
            {
                var result = _repo.FirmaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult FirmaAdd([FromBody] Firma info)
        {
            try
            {
                var id = _repo.FirmaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult FirmaUpdate([FromBody] Firma info)
        {
            try
            {
                _repo.FirmaUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
