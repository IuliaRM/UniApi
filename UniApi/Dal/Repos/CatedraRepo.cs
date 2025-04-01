
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class CatedraRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public CatedraInfo CatedraGet(long idCatedra)
        {
            return CBO.FillObject<CatedraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraGet", idCatedra));
        }

        public List<CatedraInfo> CatedraList()
        {
            return CBO.FillCollection<CatedraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraList"));
        }

        public List<CatedraInfo> CatedraListByAnUniv(long idAnUniv)
        {
            return CBO.FillCollection<CatedraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraListByAnUniv", idAnUniv));
        }

        public List<CatedraInfo> CatedraListByFacultate(long idFacultate)
        {
            return CBO.FillCollection<CatedraInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraListByFacultate", idFacultate));
        }

        public long CatedraAdd(CatedraInfo objCatedra)
        {
            return System.Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "CatedraAdd", objCatedra.DenumireCatedra, objCatedra.DenumireScurtaCatedra, objCatedra.ID_Facultate, objCatedra.ID_AnUniv));
        }

        public void CatedraUpdate(CatedraInfo objCatedra)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CatedraUpdate", objCatedra.ID_Catedra, objCatedra.DenumireCatedra, objCatedra.DenumireScurtaCatedra, objCatedra.ID_Facultate, objCatedra.ID_ProfesorSefCatedra, objCatedra.UsernameCoordonatorCEAC, objCatedra.UsernameSecretar);
        }

        public void CatedraDelete(long idCatedra)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CatedraDelete", idCatedra);
        }
    }
}
