using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class SumaPerioadaAcordareBursaSpecializareController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializareGet(long idAnUniv, long idTipPerioadaAcordareBursa, long idSpecializare)
        {
            var repo = new SumaPerioadaAcordareBursaSpecializareRepo();
            var result = repo.SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializareGet(idAnUniv, idTipPerioadaAcordareBursa, idSpecializare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SumaPerioadaAcordareBursaSpecializareMerge([FromBody] SumaPerioadaAcordareBursaSpecializareInfo obj)
        {
            var repo = new SumaPerioadaAcordareBursaSpecializareRepo();
            repo.SumaPerioadaAcordareBursaSpecializareMerge(obj);
            return Ok();
        }
    }
}
