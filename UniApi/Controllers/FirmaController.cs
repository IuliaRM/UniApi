using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using UniApi.Models;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class FirmaController : DnnApiController
    {
        private readonly FirmaRepo _repo = new FirmaRepo();

        [HttpGet]
        public IHttpActionResult FirmaGet(long ID_Firma)
        {
            var firma = _repo.FirmaGet(ID_Firma);
            return Ok(firma);
        }

        [HttpGet]
        public IHttpActionResult FirmaListGet()
        {
            var firme = _repo.FirmaListGet();
            return Ok(firme);
        }

        [HttpGet]
        public IHttpActionResult FirmaByUserIdPortalGet(int ID_UserPortal)
        {
            var firma = _repo.FirmaByUserIdPortalGet(ID_UserPortal);
            return Ok(firma);
        }

        [HttpPost]
        public IHttpActionResult FirmaAdd([FromBody] Firma objFirma)
        {
            _repo.FirmaAdd(objFirma);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult FirmaUpdate([FromBody] Firma objFirma)
        {
            _repo.FirmaUpdate(objFirma);
            return Ok();
        }
    }
}
