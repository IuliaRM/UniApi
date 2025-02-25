using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class CodEvaluareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public CodEvaluareInfo CodEvaluareGet(long idCodEvaluare)
        {
            return CBO.FillObject<CodEvaluareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CodEvaluareGet", idCodEvaluare));
        }

        public List<CodEvaluareInfo> CodEvaluareList()
        {
            return CBO.FillCollection<CodEvaluareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CodEvaluareList"));
        }

        public long CodEvaluareAdd(CodEvaluareInfo objCodEvaluare)
        {
            return System.Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "CodEvaluareAdd", objCodEvaluare.Cod, objCodEvaluare.Descriere));
        }

        public void CodEvaluareUpdate(CodEvaluareInfo objCodEvaluare)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CodEvaluareUpdate", objCodEvaluare.ID_CodEvaluare, objCodEvaluare.Cod, objCodEvaluare.Descriere);
        }

        public void CodEvaluareDelete(long idCodEvaluare)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CodEvaluareDelete", idCodEvaluare);
        }
    }
}
