using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipBursaController : DnnApiController
    {
        private readonly TipBursaRepo _repo = new TipBursaRepo();

        [HttpGet]
        public IHttpActionResult TipBursaGet(long idTipBursa)
        {
            var result = _repo.TipBursaGet(idTipBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipBursaListGet()
        {
            var result = _repo.TipBursaListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipBursaListByAnUnivGet(long idAnUniv)
        {
            var result = _repo.TipBursaListByAnUnivGet(idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipBursaAdd([FromBody] TipBursaInfo tipBursaInfo)
        {
            var id = _repo.TipBursaAdd(tipBursaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipBursaUpdate([FromBody] TipBursaInfo tipBursaInfo)
        {
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
