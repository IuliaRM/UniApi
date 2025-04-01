using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;

namespace UniApi.Controllers
{
    public class TipConferintaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipConferintaGet(long idTipConferinta)
        {
            var repo = new TipConferintaRepo();
            var result = repo.TipConferintaGet(idTipConferinta);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipConferintaListGet()
        {
            var repo = new TipConferintaRepo();
            var result = repo.TipConferintaListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipConferintaAdd([FromBody] string denumireTipConferinta)
        {
            var repo = new TipConferintaRepo();
            var id = repo.TipConferintaAdd(denumireTipConferinta);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipConferintaUpdate(long idTipConferinta, [FromBody] string denumireTipConferinta)
        {
            var repo = new TipConferintaRepo();
            repo.TipConferintaUpdate(idTipConferinta, denumireTipConferinta);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipConferintaDelete(long idTipConferinta)
        {
            var repo = new TipConferintaRepo();
            repo.TipConferintaDelete(idTipConferinta);
            return Ok();
        }
    }
}
