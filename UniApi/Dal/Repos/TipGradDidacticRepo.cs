using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipGradDidacticRepo
    {
        TipGradDidacticInfo TipGradDidacticGet(long idTipGradDidactic);
        List<TipGradDidacticInfo> TipGradDidacticList();
        long TipGradDidacticAdd(TipGradDidacticInfo tipGradDidacticInfo);
        void TipGradDidacticUpdate(TipGradDidacticInfo tipGradDidacticInfo);
        void TipGradDidacticDelete(long idTipGradDidactic);
    }

    public class TipGradDidacticRepo : ITipGradDidacticRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipGradDidacticInfo TipGradDidacticGet(long idTipGradDidactic)
        {
            return CBO.FillObject<TipGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipGradDidacticGet", idTipGradDidactic));
        }

        public List<TipGradDidacticInfo> TipGradDidacticList()
        {
            return CBO.FillCollection<TipGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipGradDidacticList"));
        }

        public long TipGradDidacticAdd(TipGradDidacticInfo tipGradDidacticInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipGradDidacticAdd",
                tipGradDidacticInfo.DenumireGradDidactic);
            return Convert.ToInt64(id);
        }

        public void TipGradDidacticUpdate(TipGradDidacticInfo tipGradDidacticInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipGradDidacticUpdate",
                tipGradDidacticInfo.ID_TipGradDidactic,
                tipGradDidacticInfo.DenumireGradDidactic);
        }

        public void TipGradDidacticDelete(long idTipGradDidactic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipGradDidacticDelete", idTipGradDidactic);
        }
    }
}
