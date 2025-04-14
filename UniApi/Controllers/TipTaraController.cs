using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class TipTaraController : DnnApiController
    {
        private readonly ITipTaraRepo _repo = new TipTaraRepo();

        public TipTaraController() { }

        [HttpGet]
        [Route("{idTipTara:long}")]
        public IHttpActionResult Get(long idTipTara)
        {
            var result = _repo.TipTaraGet(idTipTara);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("by-n-tara/{idNTipTara:long}")]
        public IHttpActionResult GetById_N_Tara(long idNTipTara)
        {
            var result = _repo.TipTaraGetById_N_Tara(idNTipTara);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("by-code/{codTara}")]
        public IHttpActionResult GetByCode(string codTara)
        {
            var result = _repo.TipTaraGetByCode(codTara);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("list")]
        public IHttpActionResult List()
        {
            var result = _repo.TipTaraList();
            return Ok(result);
        }
    }
}