using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipGradDidacticRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipGradDidacticInfo TipGradDidacticGet(long idTipGradDidactic)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipGradDidacticGet", idTipGradDidactic));
        }

        public List<TipGradDidacticInfo> TipGradDidacticListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipGradDidacticInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipGradDidacticList"));
        }

        public int TipGradDidacticAdd(TipGradDidacticInfo tipGradDidacticInfo)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "TipGradDidacticAdd", tipGradDidacticInfo.DenumireGradDidactic));
        }

        public void TipGradDidacticUpdate(TipGradDidacticInfo tipGradDidacticInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipGradDidacticUpdate", tipGradDidacticInfo.ID_TipGradDidactic, tipGradDidacticInfo.DenumireGradDidactic);
        }

        public void TipGradDidacticDelete(long idTipGradDidactic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipGradDidacticDelete", idTipGradDidactic);
        }
    }
}
