using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipConferintaRepo
    {
        TipConferintaInfo TipConferintaGet(long idTipConferinta);
        List<TipConferintaInfo> TipConferintaList();
        long TipConferintaAdd(TipConferintaInfo tipConferinta);
        void TipConferintaUpdate(TipConferintaInfo tipConferinta);
        void TipConferintaDelete(long idTipConferinta);
    }

    public class TipConferintaRepo : ITipConferintaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipConferintaInfo TipConferintaGet(long idTipConferinta)
        {
            return CBO.FillObject<TipConferintaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipConferintaGet", idTipConferinta));
        }

        public List<TipConferintaInfo> TipConferintaList()
        {
            return CBO.FillCollection<TipConferintaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipConferintaList"));
        }

        public long TipConferintaAdd(TipConferintaInfo tipConferinta)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipConferintaAdd",
                tipConferinta.DenumireTipConferinta);
            return Convert.ToInt64(id);
        }

        public void TipConferintaUpdate(TipConferintaInfo tipConferinta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipConferintaUpdate",
                tipConferinta.ID_TipConferinta,
                tipConferinta.DenumireTipConferinta);
        }

        public void TipConferintaDelete(long idTipConferinta)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipConferintaDelete", idTipConferinta);
        }
    }
}
