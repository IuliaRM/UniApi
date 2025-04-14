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
        private readonly ITipPracticaRepo _repo = new TipPracticaRepo();

        public TipPracticaController()
        {

        }


        [HttpGet]
        public IHttpActionResult TipPracticaGet(int idTipPractica)
        {
            var result = _repo.TipPracticaGet(idTipPractica);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipPracticaListGet()
        {
            var result = _repo.TipPracticaList();
            return Ok(result);
        }
    }
}