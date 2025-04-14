using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{  

    public class LegitTransportCFRController : DnnApiController
    {
        private readonly ILegitTransportCFRRepo _repo = new LegitTransportCFRRepo();

        public LegitTransportCFRController()
        {

        }

        public LegitTransportCFRController(ILegitTransportCFRRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(long idAnUniv, long idSpecializare, long idAnStudiu, long idGrupa)
        {
            try
            {
                var result = _repo.LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(idAnUniv, idSpecializare, idAnStudiu, idGrupa);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LegitimatiiCFRMerge(long idStudentAnUniv, string serieLegitimatie, string numarLegitimatie, int userIdModificare)
        {
            try
            {
                var result = _repo.LegitimatiiCFRMerge(idStudentAnUniv, serieLegitimatie, numarLegitimatie, userIdModificare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
