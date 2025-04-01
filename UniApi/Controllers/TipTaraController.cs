using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipTaraController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipTaraGet(long idTipTara)
        {
            var repo = new TipTaraRepo();
            var result = repo.TipTaraGet(idTipTara);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipTaraByID_N_TaraGet(long idNTipTara)
        {
            var repo = new TipTaraRepo();
            var result = repo.TipTaraByID_N_TaraGet(idNTipTara);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipTaraByCodeGet(string codTara)
        {
            var repo = new TipTaraRepo();
            var result = repo.TipTaraByCodeGet(codTara);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipTaraListGet()
        {
            var repo = new TipTaraRepo();
            var result = repo.TipTaraListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipTaraAdd([FromBody] TipTaraInfo tipTaraInfo)
        {
            var repo = new TipTaraRepo();
            var id = repo.TipTaraAdd(tipTaraInfo);
            return Ok(id);  
        }


        [HttpDelete]
        public IHttpActionResult TipTaraDelete(long idTipTara)
        {
            var repo = new TipTaraRepo();
            repo.TipTaraDelete(idTipTara);
            return Ok();  
        }
    }
}
