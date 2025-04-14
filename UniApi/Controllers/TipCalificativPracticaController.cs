using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TipCalificativPracticaController : DnnApiController
    {
        private readonly ITipCalificativPracticaRepo _repo = new TipCalificativPracticaRepo();

        public TipCalificativPracticaController()
        {

        }

        [HttpGet]
        public IHttpActionResult TipCalificativPracticaGet(long idTipCalificativPractica)
        {
            var result = _repo.TipCalificativPracticaGet(idTipCalificativPractica);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipCalificativPracticaListGet()
        {
            var result = _repo.TipCalificativPracticaList();
            return Ok(result);
        }
    }
}