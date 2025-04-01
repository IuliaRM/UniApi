using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipNotaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipNotaGet(int idTipNota)
        {
            var repo = new TipNotaRepo();
            var result = repo.TipNotaGet(idTipNota);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipNotaListGet()
        {
            var repo = new TipNotaRepo();
            var result = repo.TipNotaListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipNotaAdd([FromBody] TipNotaInfo tipNota)
        {
            var repo = new TipNotaRepo();
            var id = repo.TipNotaAdd(tipNota);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipNotaUpdate([FromBody] TipNotaInfo tipNota)
        {
            var repo = new TipNotaRepo();
            repo.TipNotaUpdate(tipNota);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipNotaDelete(int idTipNota)
        {
            var repo = new TipNotaRepo();
            repo.TipNotaDelete(idTipNota);
            return Ok();
        }
    }
}
