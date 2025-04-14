using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TaxaDeScolarizareController : DnnApiController
    {
        private readonly ITaxaDeScolarizareRepo _repo = new TaxaDeScolarizareRepo();

        public TaxaDeScolarizareController()
        {

        }

        [HttpGet]
        public IHttpActionResult TaxaScolaiareListByFacultateCicluFormaGet(long idFacultate, long idCicluStudiu, long idFormaInvatamant, long idAnUniversitar)
        {
            var result = _repo.TaxaScolaiareListByFacultateCicluForma(idFacultate, idCicluStudiu, idFormaInvatamant, idAnUniversitar);
            return Ok(result);
        }
    }
}