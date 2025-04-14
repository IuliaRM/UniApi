using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipSesiuneExameneRepo
    {
        List<TipSesiuneExameneInfo> TipSesiuneExameneList();
    }

    public class TipSesiuneExameneRepo : ITipSesiuneExameneRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<TipSesiuneExameneInfo> TipSesiuneExameneList()
        {
            return CBO.FillCollection<TipSesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipSesiuneExameneList"));
        }
    }
}
