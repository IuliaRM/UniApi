using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TipCriteriuEvaluareVarianteRaspunsController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsGet(long idTipCriteriuEvaluareVariantaRaspuns)
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            var result = repo.TipCriteriuEvaluareVarianteRaspunsGet(idTipCriteriuEvaluareVariantaRaspuns);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsListGet()
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            var result = repo.TipCriteriuEvaluareVarianteRaspunsListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsListByTipCriteriuEvaluareGet(long idTipCriteriuEvaluare)
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            var result = repo.TipCriteriuEvaluareVarianteRaspunsListByTipCriteriuEvaluareGet(idTipCriteriuEvaluare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsAdd([FromBody] TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            var id = repo.TipCriteriuEvaluareVarianteRaspunsAdd(obj);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsUpdate([FromBody] TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            repo.TipCriteriuEvaluareVarianteRaspunsUpdate(obj);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipCriteriuEvaluareVarianteRaspunsDelete([FromBody] TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            var repo = new TipCriteriuEvaluareVarianteRaspunsRepo();
            repo.TipCriteriuEvaluareVarianteRaspunsDelete(obj);
            return Ok();
        }
    }
}
