using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipBursaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipBursaInfo TipBursaGet(long idTipBursa)
        {
            return CBO.FillObject<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaGet", idTipBursa));
        }

        public List<TipBursaInfo> TipBursaListGet()
        {
            return CBO.FillCollection<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaList"));
        }

        public List<TipBursaInfo> TipBursaListByAnUnivGet(long idAnUniv)
        {
            return CBO.FillCollection<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaListByAnUniv", idAnUniv));
        }

        public long TipBursaAdd(TipBursaInfo tipBursaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipBursaAdd",
                tipBursaInfo.ID_Utilizator,
                tipBursaInfo.DataModificare,
                tipBursaInfo.DenumireTipBursa,
                tipBursaInfo.ID_N_Bursa);
            return Convert.ToInt64(id);
        }

        public void TipBursaUpdate(TipBursaInfo tipBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipBursaUpdate",
                tipBursaInfo.ID_TipBursa,
                tipBursaInfo.ID_Utilizator,
                tipBursaInfo.DataModificare,
                tipBursaInfo.DenumireTipBursa,
                tipBursaInfo.ID_N_Bursa);
        }

        public void TipBursaDelete(long idTipBursa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipBursaDelete", idTipBursa);
        }
    }
}
