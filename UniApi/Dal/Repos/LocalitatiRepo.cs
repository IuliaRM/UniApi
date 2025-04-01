using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class LocalitatiRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public LocalitatiInfo LocalitatiGet(string ID_Localitate)
        {
            return CBO.FillObject<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_Get", ID_Localitate));
        }

        public LocalitatiInfo LocalitatiByID_N_LocalitateGet(int ID_N_Localitate)
        {
            return CBO.FillObject<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_GetByID_N_Localitate", ID_N_Localitate));
        }

        public List<LocalitatiInfo> LocalitatiListGet()
        {
            return CBO.FillCollection<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_GetList"));
        }

        public int LocalitatiAdd(LocalitatiInfo objLocalitati)
        {
            return (int)SqlHelper.ExecuteScalar(_ConnectionString, "Localitati_Add", objLocalitati.Localitate, objLocalitati.URBAN_RURAL, objLocalitati.ID_Judet);
        }

        public void LocalitatiUpdate(LocalitatiInfo objLocalitati)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Localitati_Update", objLocalitati.ID_Localitate, objLocalitati.Localitate, objLocalitati.URBAN_RURAL, objLocalitati.ID_Judet);
        }

        public void LocalitatiDelete(LocalitatiInfo objLocalitati)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "Localitati_Delete", objLocalitati.ID_Localitate);
        }

        public LocalitatiInfo LocalitatiByDenumireIdJudetGet(string DenumireLocalitate, string ID_Judet)
        {
            return CBO.FillObject<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_GetByDenumireIdJudet", DenumireLocalitate, ID_Judet));
        }

        public List<LocalitatiInfo> LocalitatiListByJudetGet(string ID_Judet)
        {
            return CBO.FillCollection<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_GetListByJudet", ID_Judet));
        }

        public List<LocalitatiInfo> LocalitatiListByCaractereDenumireIdJudetGet(string CaractereDenumireLocalitate, string ID_Judet)
        {
            return CBO.FillCollection<LocalitatiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Localitati_GetListByCaractereDenumireIdJudet", CaractereDenumireLocalitate, ID_Judet));
        }
    }
}
