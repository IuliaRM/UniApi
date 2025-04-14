using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipAvertismentRepo
    {
        TipAvertismentInfo TipAvertismentGet(long idTipAvertisment);
        List<TipAvertismentInfo> TipAvertismentList();
        long TipAvertismentAdd(TipAvertismentInfo tipAvertisment);
        void TipAvertismentUpdate(TipAvertismentInfo tipAvertisment);
        void TipAvertismentDelete(long idTipAvertisment);
    }

    public class TipAvertismentRepo : ITipAvertismentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipAvertismentInfo TipAvertismentGet(long idTipAvertisment)
        {
            return CBO.FillObject<TipAvertismentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipAvertismentGet", idTipAvertisment));
        }

        public List<TipAvertismentInfo> TipAvertismentList()
        {
            return CBO.FillCollection<TipAvertismentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipAvertismentList"));
        }

        public long TipAvertismentAdd(TipAvertismentInfo tipAvertisment)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipAvertismentAdd",
                tipAvertisment.DenumireAvertisment);
            return Convert.ToInt64(id);
        }

        public void TipAvertismentUpdate(TipAvertismentInfo tipAvertisment)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipAvertismentUpdate",
                tipAvertisment.ID_TipAvertisment,
                tipAvertisment.DenumireAvertisment);
        }

        public void TipAvertismentDelete(long idTipAvertisment)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipAvertismentDelete", idTipAvertisment);
        }
    }
}
