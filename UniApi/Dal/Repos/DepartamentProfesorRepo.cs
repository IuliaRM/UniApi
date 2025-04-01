using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DepartamentProfesorRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DepartamentProfesorInfo DepartamentProfesorGet(long idDepartamentProfesor)
        {
            return CBO.FillObject<DepartamentProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DepartamentProfesorGet", idDepartamentProfesor));
        }

        public DepartamentProfesorInfo DepartamentProfesorGetByProfesor(long idProfesor)
        {
            return CBO.FillObject<DepartamentProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DepartamentProfesorGetByProfesor", idProfesor));
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorList()
        {
            return CBO.FillCollection<DepartamentProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DepartamentProfesorList"));
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorListByDepartament(long idDepartament)
        {
            return CBO.FillCollection<DepartamentProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DepartamentProfesorListByDepartament", idDepartament));
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorListByProfesor(long idProfesor)
        {
            return CBO.FillCollection<DepartamentProfesorInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DepartamentProfesorListByProfesor", idProfesor));
        }

        public int DepartamentProfesorAdd(DepartamentProfesorInfo objDepartamentProfesor)
        {
            object obj = SqlHelper.ExecuteScalar(_ConnectionString, "DepartamentProfesorAdd",
                objDepartamentProfesor.ID_Departament,
                objDepartamentProfesor.ID_Profesor,
                objDepartamentProfesor.DataDeCand,
                objDepartamentProfesor.DataPanaCand,
                objDepartamentProfesor.DepartamentProfesorActiv,
                objDepartamentProfesor.ID_AnUnivDepartament);
            return Convert.ToInt32(obj);
        }

        public void DepartamentProfesorUpdate(DepartamentProfesorInfo objDepartamentProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DepartamentProfesorUpdate",
                objDepartamentProfesor.ID_DepartamentProfesor,
                objDepartamentProfesor.ID_Departament,
                objDepartamentProfesor.ID_Profesor,
                objDepartamentProfesor.DataDeCand,
                objDepartamentProfesor.DataPanaCand,
                objDepartamentProfesor.DepartamentProfesorActiv,
                objDepartamentProfesor.ID_AnUnivDepartament);
        }

        public void DepartamentProfesorDelete(long idDepartamentProfesor)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DepartamentProfesorDelete", idDepartamentProfesor);
        }
    }
}
