using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;

namespace UniApi.Dal.Repos
{
    public class LegitTransportCFRRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long LegitimatiiCFRMerge(long ID_StudentAnUniv, string SerieLegitimatie, string NumarLegitimatie, int UserIdModificare)
        {
            object ret = SqlHelper.ExecuteScalar(_ConnectionString, "LegitimatiiCFRMerge", ID_StudentAnUniv, SerieLegitimatie, NumarLegitimatie, UserIdModificare);
            return Convert.ToInt64(ret);
        }

        public List<LegitTransportCFRInfo> LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(long ID_AnUniv, long ID_Specializare, long ID_AnStudiu, long ID_Grupa)
        {
            return CBO.FillCollection<LegitTransportCFRInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa", ID_AnUniv, ID_Specializare, ID_AnStudiu, ID_Grupa));
        }
    }
}
