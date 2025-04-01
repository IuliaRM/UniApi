using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class IntervalPunctajBursaController : DnnApiController
    {
        private readonly IntervalPunctajBursaRepo _repo = new IntervalPunctajBursaRepo();

        [HttpGet]
        public IHttpActionResult IntervalPunctajBursaListByTipBursaAnUnivFCFDASGet(long ID_TipBursa, long ID_AnUniv, long ID_AnUnivBursa, long NumarSemestruBursa, long NumarSemestruCalculPunctaj, long ID_FC, long ID_FCForma, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare)
        {
            var punctaje = _repo.IntervalPunctajBursaListByTipBursaAnUnivFCFDASGet(ID_TipBursa, ID_AnUniv, ID_AnUnivBursa, NumarSemestruBursa, NumarSemestruCalculPunctaj, ID_FC, ID_FCForma, ID_Domeniu, ID_AnStudiu, ID_Specializare);
            return Ok(punctaje);
        }

        [HttpDelete]
        public IHttpActionResult IntervalPunctajBursaDelete([FromBody] IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            _repo.IntervalPunctajBursaDelete(objIntervalPunctajBursa);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult IntervalPunctajBursaGet(long ID_IntervalPunctajBursa)
        {
            var punctaj = _repo.IntervalPunctajBursaGet(ID_IntervalPunctajBursa);
            return Ok(punctaj);
        }

        [HttpPost]
        public IHttpActionResult IntervalPunctajBursaAddOrUpdate([FromBody] IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            var id = _repo.IntervalPunctajBursaAddOrUpdate(objIntervalPunctajBursa);
            return Ok(id);
        }
    }
}
