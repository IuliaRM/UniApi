using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class MedieEvaluariRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<MedieEvaluariInfo> MedieEvaluariGet(long idDetaliuPlanSemestru)
        {
            return CBO.FillCollection<MedieEvaluariInfo>(
                SqlHelper.ExecuteReader(_connectionString, "EvaluareListByIDDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }
    }
}
