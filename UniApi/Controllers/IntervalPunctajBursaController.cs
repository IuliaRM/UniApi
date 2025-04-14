using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class IntervalPunctajBursaController : DnnApiController
    {
        private readonly IIntervalPunctajBursaRepo _repo = new IntervalPunctajBursaRepo();

        public IntervalPunctajBursaController()
        {

        }

        public IntervalPunctajBursaController(IIntervalPunctajBursaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult IntervalPunctajBursaGet(long id)
        {
            try
            {
                var result = _repo.IntervalPunctajBursaGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult IntervalPunctajBursaAddOrUpdate([FromBody] IntervalPunctajBursaInfo info)
        {
            try
            {
                var id = _repo.IntervalPunctajBursaAddOrUpdate(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult IntervalPunctajBursaDelete([FromBody] IntervalPunctajBursaInfo info)
        {
            try
            {
                _repo.IntervalPunctajBursaDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(long idTipBursa, long idAnUniv, long idAnUnivBursa, long nrSemBursa, long nrSemCalculPunctaj, long idFC, long idFCForma, long idDomeniu, long idAnStudiu, long idSpecializare)
        {
            try
            {
                var result = _repo.IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(idTipBursa, idAnUniv, idAnUnivBursa, nrSemBursa, nrSemCalculPunctaj, idFC, idFCForma, idDomeniu, idAnStudiu, idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
