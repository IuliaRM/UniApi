using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class SumaPerioadaAcordareBursaSpecializareController : DnnApiController
    {
        private readonly ISumaPerioadaAcordareBursaSpecializareRepo _repo = new SumaPerioadaAcordareBursaSpecializareRepo();

        public SumaPerioadaAcordareBursaSpecializareController()
        {
        }

        [HttpGet]
        public IHttpActionResult SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializareGet(long idAnUniv, long idTipPerioadaAcordareBursa, long idSpecializare)
        {
            var result = _repo.SumaPerioadaAcordareBursaSpecializareListByTipPerioadaSpecializare(idAnUniv, idTipPerioadaAcordareBursa, idSpecializare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult SumaPerioadaAcordareBursaSpecializareMerge([FromBody] SumaPerioadaAcordareBursaSpecializareInfo obj)
        {
            if (obj == null)
            {
                return BadRequest("Obiectul obj nu poate fi null.");
            }
            _repo.SumaPerioadaAcordareBursaSpecializareMerge(obj);
            return Ok();
        }
    }
}