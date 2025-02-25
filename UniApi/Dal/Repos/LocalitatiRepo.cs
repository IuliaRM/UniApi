using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class LocalitatiRepo
    {
        private readonly string _ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public LocalitatiInfo LocalitatiGet(string iD_Localitate)
        {
            return CBO.FillObject<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiGet", iD_Localitate));
        }

        public LocalitatiInfo LocalitatiGetByID_N_Localitate(int iD_N_Localitate)
        {
            return CBO.FillObject<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiGetByID_N_Localitate", iD_N_Localitate));
        }

        public List<LocalitatiInfo> LocalitatiList()
        {
            return CBO.FillCollection<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiList"));
        }

        public int LocalitatiAdd(LocalitatiInfo objLocalitati)
        {
            return (int)SqlHelper.ExecuteScalar(_ConnectionString, "LocalitatiAdd", objLocalitati.Localitate, objLocalitati.URBAN_RURAL, objLocalitati.ID_Judet);
        }

        public void LocalitatiUpdate(LocalitatiInfo objLocalitati)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "LocalitatiUpdate", objLocalitati.ID_Localitate, objLocalitati.Localitate, objLocalitati.URBAN_RURAL, objLocalitati.ID_Judet);
        }

        public void LocalitatiDelete(LocalitatiInfo objLocalitati)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "LocalitatiDelete", objLocalitati.ID_Localitate);
        }

        public LocalitatiInfo LocalitatiGetBydenumireIdJudet(string denumireLocalitate, string idjudet)
        {
            return CBO.FillObject<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiGetBydenumireIdJudet", denumireLocalitate, idjudet));
        }

        public List<LocalitatiInfo> LocalitatiListByJudet(string idjudet)
        {
            return CBO.FillCollection<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiListByJudet", idjudet));
        }

        public List<LocalitatiInfo> LocalitatiListByCaractereDenumireIdJudet(string CaractereDenumireLocalitate, string idjudet)
        {
            return CBO.FillCollection<LocalitatiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "LocalitatiListByCaractereDenumireIdJudet", CaractereDenumireLocalitate, idjudet));
        }
    }
}
