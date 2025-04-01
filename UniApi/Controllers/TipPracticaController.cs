using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipPracticaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipPracticaGet(int idTipPractica)
        {
            var repo = new TipPracticaRepo();
            var result = repo.TipPracticaGet(idTipPractica);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipPracticaListGet()
        {
            var repo = new TipPracticaRepo();
            var result = repo.TipPracticaListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipPracticaAdd([FromBody] TipPractica tipPractica)
        {
            var repo = new TipPracticaRepo();
            var id = repo.TipPracticaAdd(tipPractica);
            return Ok(id); 
        }

        [HttpDelete]
        public IHttpActionResult TipPracticaDelete(int idTipPractica)
        {
            var repo = new TipPracticaRepo();
            repo.TipPracticaDelete(idTipPractica);
            return Ok(); 
        }
    }
}
