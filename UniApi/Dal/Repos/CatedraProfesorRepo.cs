using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class CatedraProfesorRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public CatedraProfesorInfo CatedraProfesorGet(long idCatedraProfesor)
        {
            return CBO.FillObject<CatedraProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraProfesorGet", idCatedraProfesor));
        }

        public List<CatedraProfesorInfo> CatedraProfesorList()
        {
            return CBO.FillCollection<CatedraProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraProfesorList"));
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedra(long idCatedra)
        {
            return CBO.FillCollection<CatedraProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraProfesorListByCatedra", idCatedra));
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            return CBO.FillCollection<CatedraProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraProfesorListByCatedraAnUniv", idCatedra, idAnUniv));
        }

        public List<CatedraProfesorInfo> CatedraProfesorListByProfesor(long idProfesor)
        {
            return CBO.FillCollection<CatedraProfesorInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CatedraProfesorListByProfesor", idProfesor));
        }

        public long CatedraProfesorAdd(CatedraProfesorInfo objCatedraProfesor)
        {
            return System.Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "CatedraProfesorAdd", objCatedraProfesor.ID_Catedra, objCatedraProfesor.ID_Profesor, objCatedraProfesor.DataDeCand, objCatedraProfesor.DataPanaCand, objCatedraProfesor.CatedraProfesorActiv, objCatedraProfesor.ID_AnUniv));
        }

        public void CatedraProfesorUpdate(CatedraProfesorInfo objCatedraProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CatedraProfesorUpdate", objCatedraProfesor.ID_CatedraProfesor, objCatedraProfesor.ID_Catedra, objCatedraProfesor.ID_Profesor, objCatedraProfesor.DataDeCand, objCatedraProfesor.DataPanaCand, objCatedraProfesor.CatedraProfesorActiv, objCatedraProfesor.ID_AnUniv);
        }

        public void CatedraProfesorDelete(long idCatedraProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CatedraProfesorDelete", idCatedraProfesor);
        }
    }
}
