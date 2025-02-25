using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class LegitTransportCFRController
    {
        private readonly LegitTransportCFRRepo _repo;

        public LegitTransportCFRController()
        {
            _repo = new LegitTransportCFRRepo();
        }

        public long LegitimatiiCFRMerge(long ID_StudentAnUniv, string SerieLegitimatie, string NumarLegitimatie, int UserIdModificare)
        {
            return _repo.LegitimatiiCFRMerge(ID_StudentAnUniv, SerieLegitimatie, NumarLegitimatie, UserIdModificare);
        }

        public List<LegitTransportCFRInfo> LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(long ID_AnUniv, long ID_Specializare, long ID_AnStudiu, long ID_Grupa)
        {
            return _repo.LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(ID_AnUniv, ID_Specializare, ID_AnStudiu, ID_Grupa);
        }
    }
}
