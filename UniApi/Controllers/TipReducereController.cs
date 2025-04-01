using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using UniApi;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipReducereController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipReducereGet(long idTipReducere)
        {
            var repo = new TipReducereRepo();
            var result = repo.TipReducereGet(idTipReducere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListGet()
        {
            var repo = new TipReducereRepo();
            var result = repo.TipReducereListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListByTaxaGet(long idTaxa)
        {
            var repo = new TipReducereRepo();
            var result = repo.TipReducereListByTaxaGet(idTaxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListByTaxaStudentGet(long idTaxaStudent)
        {
            var repo = new TipReducereRepo();
            var result = repo.TipReducereListByTaxaStudentGet(idTaxaStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipReducereAdd([FromBody] TipReducereInfo tipReducereInfo)
        {
            var repo = new TipReducereRepo();
            var id = repo.TipReducereAdd(tipReducereInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipReducereUpdate([FromBody] TipReducereInfo tipReducereInfo)
        {
            var repo = new TipReducereRepo();
            repo.TipReducereUpdate(tipReducereInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipReducereDelete([FromBody] TipReducereInfo tipReducereInfo)
        {
            var repo = new TipReducereRepo();
            repo.TipReducereDelete(tipReducereInfo);
            return Ok();
        }
    }
}
