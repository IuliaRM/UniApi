using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class CodEvaluareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public CodEvaluareInfo CodEvaluareGet(long idCodEvaluare)
        {
            return CBO.FillObject<CodEvaluareInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "CodEvaluareGet", idCodEvaluare)
            );
        }

        public List<CodEvaluareInfo> CodEvaluareList()
        {
            return CBO.FillCollection<CodEvaluareInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "CodEvaluareList")
            );
        }

        public long CodEvaluareAdd(CodEvaluareInfo objCodEvaluare)
        {
            return System.Convert.ToInt64(SqlHelper.ExecuteScalar(
                _ConnectionString,
                "CodEvaluareAdd",
                objCodEvaluare.ID_DetaliuPlanSemestru, // Added missing fields
                objCodEvaluare.ID_EvaluareProfesor,
                objCodEvaluare.TipCursEvaluat,
                objCodEvaluare.CodEvaluare,
                objCodEvaluare.Status
            ));
        }

        public void CodEvaluareUpdate(CodEvaluareInfo objCodEvaluare)
        {
            SqlHelper.ExecuteNonQuery(
                _ConnectionString,
                "CodEvaluareUpdate",
                objCodEvaluare.ID_CodEvaluare,
                objCodEvaluare.ID_DetaliuPlanSemestru, // Added missing fields
                objCodEvaluare.ID_EvaluareProfesor,
                objCodEvaluare.TipCursEvaluat,
                objCodEvaluare.CodEvaluare,
                objCodEvaluare.Status
            );
        }

        public void CodEvaluareDelete(long idCodEvaluare)
        {
            SqlHelper.ExecuteNonQuery(
                _ConnectionString,
                "CodEvaluareDelete",
                idCodEvaluare
            );
        }
    }
}
