using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class SesiuneExameneRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public SesiuneExameneInfo SesiuneExameneGet(long idSesiuneExamene)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<SesiuneExameneInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.SesiuneExameneGet", idSesiuneExamene));
        }

        public List<ProgramareExamenInfo> ProgramareExamenListBySesiuneExameneGet(long idSesiuneExamene)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ProgramareExamenInfo>(
                SqlHelper.ExecuteReader(_connectionString, "PE.RAP_ProgramareExamenlListBySesiuneExamene", idSesiuneExamene));
        }

        public System.Data.DataTable ProgramareExamenListBySesiuneExameneDTGet(long idSesiuneExamene)
        {
            var result = SqlHelper.ExecuteReader(_connectionString, "PE.RAP_ProgramareExamenlListBySesiuneExamene", idSesiuneExamene);
            return DotNetNuke.Common.Globals.ConvertDataReaderToDataTable(result);
        }
    }
}
