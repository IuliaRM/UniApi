using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipCriteriuEvaluareController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipCriteriuEvaluareGet(long idTipCriteriuEvaluare)
        {
            var repo = new TipCriteriuEvaluareRepo();
            var result = repo.TipCriteriuEvaluareGet(idTipCriteriuEvaluare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipCriteriuEvaluareLisGett()
        {
            var repo = new TipCriteriuEvaluareRepo();
            var result = repo.TipCriteriuEvaluareListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipCriteriuEvaluareAdd([FromBody] TipCriteriuEvaluareInfo tipCriteriuEvaluare)
        {
            var repo = new TipCriteriuEvaluareRepo();
            var id = repo.TipCriteriuEvaluareAdd(tipCriteriuEvaluare);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipCriteriuEvaluareUpdate([FromBody] TipCriteriuEvaluareInfo tipCriteriuEvaluare)
        {
            var repo = new TipCriteriuEvaluareRepo();
            repo.TipCriteriuEvaluareUpdate(tipCriteriuEvaluare);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipCriteriuEvaluareDelete(long idTipCriteriuEvaluare)
        {
            var repo = new TipCriteriuEvaluareRepo();
            repo.TipCriteriuEvaluareDelete(idTipCriteriuEvaluare);
            return Ok();
        }
    }
}
