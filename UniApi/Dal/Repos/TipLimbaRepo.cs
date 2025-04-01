using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipLimbaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipLimbaInfo TipLimbaGet(long idTipLimba)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipLimbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipLimbaGet", idTipLimba));
        }

        public List<TipLimbaInfo> TipLimbaListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipLimbaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipLimbaList"));
        }

        public int TipLimbaAdd(TipLimbaInfo tipLimbaInfo)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "TipLimbaAdd",
                tipLimbaInfo.Denumire,
                tipLimbaInfo.ID_Utilizator,
                tipLimbaInfo.DataModificare,
                tipLimbaInfo.Status));
        }

        public void TipLimbaUpdate(TipLimbaInfo tipLimbaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipLimbaUpdate",
                tipLimbaInfo.ID_TipLimba,
                tipLimbaInfo.Denumire,
                tipLimbaInfo.ID_Utilizator,
                tipLimbaInfo.DataModificare,
                tipLimbaInfo.Status);
        }

        public void TipLimbaDelete(long idTipLimba)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipLimbaDelete", idTipLimba);
        }
    }
}
