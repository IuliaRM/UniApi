using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TipBursaController : DnnApiController
    {
        private readonly ITipBursaRepo _repo = new TipBursaRepo();

        public TipBursaController()
        {

        }

        [HttpGet]
        public IHttpActionResult TipBursaGet(long idTipBursa)
        {
            var result = _repo.TipBursaGet(idTipBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipBursaListGet()
        {
            var result = _repo.TipBursaList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipBursaListByAnUnivGet(long idAnUniv)
        {
            var result = _repo.TipBursaListByAnUniv(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipBursaGetByPunctajIntervalGet(decimal punctajMinim, decimal punctajMaxim, long idAnUniv)
        {
            var result = _repo.TipBursaGetByPunctajInterval(punctajMinim, punctajMaxim, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipBursaAdd([FromBody] TipBursaInfo tipBursaInfo)
        {
            if (tipBursaInfo == null)
            {
                return BadRequest("Obiectul tipBursaInfo nu poate fi null.");
            }
            var id = _repo.TipBursaAdd(tipBursaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipBursaUpdate([FromBody] TipBursaInfo tipBursaInfo)
        {
            if (tipBursaInfo == null)
            {
                return BadRequest("Obiectul tipBursaInfo nu poate fi null.");
            }
            _repo.TipBursaUpdate(tipBursaInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipBursaDelete(long idTipBursa)
        {
            _repo.TipBursaDelete(idTipBursa);
            return Ok();
        }
    }
}