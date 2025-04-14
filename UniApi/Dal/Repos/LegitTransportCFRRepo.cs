using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ILegitTransportCFRRepo
    {
        long LegitimatiiCFRMerge(long idStudentAnUniv, string serieLegitimatie, string numarLegitimatie, int userIdModificare);
        DataTable LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(long idAnUniv, long idSpecializare, long idAnStudiu, long idGrupa);
    }

    public class LegitTransportCFRRepo : ILegitTransportCFRRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long LegitimatiiCFRMerge(long idStudentAnUniv, string serieLegitimatie, string numarLegitimatie, int userIdModificare)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "LegitimatiiCFR_Merge", idStudentAnUniv, serieLegitimatie, numarLegitimatie, userIdModificare);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LegitimatiiCFRMerge", ex);
            }
        }

        public DataTable LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa(long idAnUniv, long idSpecializare, long idAnStudiu, long idGrupa)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "LegitimatiiCFR_GetListByAnUnivSpecializareAnStudiuGrupa", idAnUniv, idSpecializare, idAnStudiu, idGrupa).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LegitimatiiCFRListByAnUnivSpecializareAnStudiuGrupa", ex);
            }
        }
    }
}
