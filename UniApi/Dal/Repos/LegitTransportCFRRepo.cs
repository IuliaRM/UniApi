using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class LegitTransportCFRRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long LegitimatiiCFRMerge(long ID_StudentAnUniv, string SerieLegitimatie, string NumarLegitimatie, int UserIdModificare)
        {
            return (long)SqlHelper.ExecuteScalar(_ConnectionString, "LegitimatiiCFR_Merge", ID_StudentAnUniv, SerieLegitimatie, NumarLegitimatie, UserIdModificare);
        }

        public List<LegitTransportCFRInfo> LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupaGet(long ID_AnUniv, long ID_Specializare, long ID_AnStudiu, long ID_Grupa)
        {
            return CBO.FillCollection<LegitTransportCFRInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "LegitimatiiCFR_GetListByAnUnivSpecializareAnStudiuGrupa", ID_AnUniv, ID_Specializare, ID_AnStudiu, ID_Grupa));
        }
    }
}
