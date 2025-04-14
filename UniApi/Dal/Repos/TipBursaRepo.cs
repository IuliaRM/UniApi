using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipBursaRepo
    {
        TipBursaInfo TipBursaGet(long idTipBursa);
        List<TipBursaInfo> TipBursaList();
        List<TipBursaInfo> TipBursaListByAnUniv(long idAnUniv);
        List<TipBursaInfo> TipBursaGetByPunctajInterval(decimal punctajMinim, decimal punctajMaxim, long idAnUniv);
        long TipBursaAdd(TipBursaInfo tipBursaInfo);
        void TipBursaUpdate(TipBursaInfo tipBursaInfo);
        void TipBursaDelete(long idTipBursa);
    }

    public class TipBursaRepo : ITipBursaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipBursaInfo TipBursaGet(long idTipBursa)
        {
            return CBO.FillObject<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaGet", idTipBursa));
        }

        public List<TipBursaInfo> TipBursaList()
        {
            return CBO.FillCollection<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaList"));
        }

        public List<TipBursaInfo> TipBursaListByAnUniv(long idAnUniv)
        {
            return CBO.FillCollection<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaListByAnUniv", idAnUniv));
        }

        public List<TipBursaInfo> TipBursaGetByPunctajInterval(decimal punctajMinim, decimal punctajMaxim, long idAnUniv)
        {
            return CBO.FillCollection<TipBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipBursaGetByPunctajInterval", punctajMinim, punctajMaxim, idAnUniv));
        }

        public long TipBursaAdd(TipBursaInfo tipBursaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipBursaAdd",
                tipBursaInfo.ID_Utilizator,
                DateTime.Now, // DataModificare - am presupus ca se seteaza la adaugare
                tipBursaInfo.DenumireTipBursa,
                tipBursaInfo.ID_N_Bursa);
            return Convert.ToInt64(id);
        }

        public void TipBursaUpdate(TipBursaInfo tipBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipBursaUpdate",
                tipBursaInfo.ID_TipBursa,
                tipBursaInfo.ID_Utilizator,
                DateTime.Now, // DataModificare - am presupus ca se seteaza la update
                tipBursaInfo.DenumireTipBursa,
                tipBursaInfo.ID_N_Bursa);
        }

        public void TipBursaDelete(long idTipBursa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipBursaDelete", idTipBursa);
        }
    }
}
