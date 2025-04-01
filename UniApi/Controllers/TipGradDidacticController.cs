using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipGradDidacticController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipGradDidacticGet(long idTipGradDidactic)
        {
            var repo = new TipGradDidacticRepo();
            var result = repo.TipGradDidacticGet(idTipGradDidactic);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipGradDidacticListGet()
        {
            var repo = new TipGradDidacticRepo();
            var result = repo.TipGradDidacticListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipGradDidacticAdd([FromBody] TipGradDidacticInfo tipGradDidacticInfo)
        {
            var repo = new TipGradDidacticRepo();
            var id = repo.TipGradDidacticAdd(tipGradDidacticInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipGradDidacticUpdate([FromBody] TipGradDidacticInfo tipGradDidacticInfo)
        {
            var repo = new TipGradDidacticRepo();
            repo.TipGradDidacticUpdate(tipGradDidacticInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipGradDidacticDelete(long idTipGradDidactic)
        {
            var repo = new TipGradDidacticRepo();
            repo.TipGradDidacticDelete(idTipGradDidactic);
            return Ok();
        }
    }
}
