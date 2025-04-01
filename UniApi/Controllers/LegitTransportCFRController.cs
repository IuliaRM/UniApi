using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class LegitTransportCFRController : DnnApiController
    {
        private readonly LegitTransportCFRRepo _repo = new LegitTransportCFRRepo();

        [HttpPost]
        public IHttpActionResult LegitimatiiCFRMerge(long ID_StudentAnUniv, string SerieLegitimatie, string NumarLegitimatie, int UserIdModificare)
        {
            var result = _repo.LegitimatiiCFRMerge(ID_StudentAnUniv, SerieLegitimatie, NumarLegitimatie, UserIdModificare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupaGet(long ID_AnUniv, long ID_Specializare, long ID_AnStudiu, long ID_Grupa)
        {
            var legitimatii = _repo.LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupaGet(ID_AnUniv, ID_Specializare, ID_AnStudiu, ID_Grupa);
            return Ok(legitimatii);
        }
    }
}
