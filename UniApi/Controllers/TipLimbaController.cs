using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipLimbaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipLimbaGet(long idTipLimba)
        {
            var repo = new TipLimbaRepo();
            var result = repo.TipLimbaGet(idTipLimba);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipLimbaListGet()
        {
            var repo = new TipLimbaRepo();
            var result = repo.TipLimbaListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipLimbaAdd([FromBody] TipLimbaInfo tipLimbaInfo)
        {
            var repo = new TipLimbaRepo();
            var id = repo.TipLimbaAdd(tipLimbaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipLimbaUpdate([FromBody] TipLimbaInfo tipLimbaInfo)
        {
            var repo = new TipLimbaRepo();
            repo.TipLimbaUpdate(tipLimbaInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipLimbaDelete(long idTipLimba)
        {
            var repo = new TipLimbaRepo();
            repo.TipLimbaDelete(idTipLimba);
            return Ok();
        }
    }
}
