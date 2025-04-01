using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipCalificativPracticaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipCalificativPracticaGet(long idTipCalificativPractica)
        {
            var repo = new TipCalificativPracticaRepo();
            var result = repo.TipCalificativPracticaGet(idTipCalificativPractica);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipCalificativPracticaListGet()
        {
            var repo = new TipCalificativPracticaRepo();
            var result = repo.TipCalificativPracticaListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipCalificativPracticaAdd([FromBody] TipCalificativPractica tipCalificativPractica)
        {
            var repo = new TipCalificativPracticaRepo();
            var id = repo.TipCalificativPracticaAdd(tipCalificativPractica);
            return Ok(id);
        }

        [HttpDelete]
        public IHttpActionResult TipCalificativPracticaDelete(long idTipCalificativPractica)
        {
            var repo = new TipCalificativPracticaRepo();
            repo.TipCalificativPracticaDelete(idTipCalificativPractica);
            return Ok();
        }
    }
}
