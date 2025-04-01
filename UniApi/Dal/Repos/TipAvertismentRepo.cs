using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipAvertismentRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipAvertismentInfo TipAvertismentGet(long idTipAvertisment)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipAvertismentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipAvertismentGet", idTipAvertisment));
        }

        public List<TipAvertismentInfo> TipAvertismentListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipAvertismentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipAvertismentList"));
        }

        public int TipAvertismentAdd(TipAvertismentInfo tipAvertisment)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipAvertismentAdd", tipAvertisment.DenumireAvertisment);
            return Convert.ToInt32(id);
        }

        public void TipAvertismentUpdate(TipAvertismentInfo tipAvertisment)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipAvertismentUpdate",
                tipAvertisment.ID_TipAvertisment, tipAvertisment.DenumireAvertisment);
        }

        public void TipAvertismentDelete(long idTipAvertisment)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipAvertismentDelete", idTipAvertisment);
        }
    }
}
