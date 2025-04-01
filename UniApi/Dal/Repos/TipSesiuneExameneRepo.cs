using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipSesiuneExameneRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<TipSesiuneExameneInfo> TipSesiuneExameneListGet()
        {
            return CBO.FillCollection<TipSesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.TipSesiuneExameneList"));
        }

        public long TipSesiuneExameneAdd(TipSesiuneExameneInfo sesiuneInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "PE.TipSesiuneExameneAdd",
                sesiuneInfo.DenumireTipSesiuneExamene);
            return Convert.ToInt64(id);
        }

        public void TipSesiuneExameneDelete(long idSesiune)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PE.TipSesiuneExameneDelete", idSesiune);
        }
    }
}
