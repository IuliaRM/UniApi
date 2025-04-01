using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Web.Api;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;


namespace UniApi.Dal.Repos
{
    public class CererePrecazareRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;
        private string _connectionString;

        public CererePrecazareInfo CererePrecazareGet(long idCererePrecazare)
        {
            return CBO.FillObject<CererePrecazareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CererePrecazareGet", idCererePrecazare));
        }

        public List<CererePrecazareInfo> CererePrecazareList()
        {
            return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CererePrecazareList"));
        }

        public List<CererePrecazareInfo> CererePrecazareListByStudent(long idStudent)
        {
            return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CererePrecazareListByStudent", idStudent));
        }

        public List<CererePrecazareInfo> CererePrecazareListByStudentComplet(long idStudent, long idAnUniv)
        {
            return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CererePrecazareListByStudentComplet", idStudent, idAnUniv));
        }

        public List<CererePrecazareInfo> CererePrecazareListByCamera(long idCamera)
        {
            return CBO.FillCollection<CererePrecazareInfo>(SqlHelper.ExecuteReader(_ConnectionString, "CererePrecazareListByCamera", idCamera));
        }

        public long CererePrecazareAdd(CererePrecazareInfo objCererePrecazare)
        {
            return System.Convert.ToInt64(SqlHelper.ExecuteScalar(_ConnectionString, "CererePrecazareAdd", objCererePrecazare.ID_Student, objCererePrecazare.ID_Camera, objCererePrecazare.DataCerere, objCererePrecazare.Motiv, objCererePrecazare.ID_AnUniv));
        }

        public void CererePrecazareUpdate(CererePrecazareInfo objCererePrecazare)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CererePrecazareUpdate", objCererePrecazare.ID_CererePrecazare, objCererePrecazare.ID_Student, objCererePrecazare.ID_Camera, objCererePrecazare.DataCerere, objCererePrecazare.Motiv, objCererePrecazare.ID_AnUniv);
        }

        public void CererePrecazareDelete(long idCererePrecazare)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "CererePrecazareDelete", idCererePrecazare);
        }

        public List<CazareInfo> ListaCamineByAnuUniversitarFacultate(long idAnUniversitar, long idFacultate)
        {
            return CBO.FillCollection<CazareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ListaCamineByAnuUniversitarFacultate", idAnUniversitar, idFacultate)
            );
        }

    }
}
