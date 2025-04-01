using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipAvertismentController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipAvertismentGet(long idTipAvertisment)
        {
            var repo = new TipAvertismentRepo();
            var result = repo.TipAvertismentGet(idTipAvertisment);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipAvertismentListGet()
        {
            var repo = new TipAvertismentRepo();
            var result = repo.TipAvertismentListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipAvertismentAdd([FromBody] TipAvertismentInfo tipAvertisment)
        {
            var repo = new TipAvertismentRepo();
            var id = repo.TipAvertismentAdd(tipAvertisment);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipAvertismentUpdate([FromBody] TipAvertismentInfo tipAvertisment)
        {
            var repo = new TipAvertismentRepo();
            repo.TipAvertismentUpdate(tipAvertisment);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipAvertismentDelete(long idTipAvertisment)
        {
            var repo = new TipAvertismentRepo();
            repo.TipAvertismentDelete(idTipAvertisment);
            return Ok();
        }
    }
}
