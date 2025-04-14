using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDepartamentProfesorRepo
    {
        DepartamentProfesorInfo DepartamentProfesorGet(long idDepartamentProfesor);
        DepartamentProfesorInfo DepartamentProfesorGetByProfesor(long idProfesor);
        List<DepartamentProfesorInfo> DepartamentProfesorList();
        List<DepartamentProfesorInfo> DepartamentProfesorListByDepartament(long idDepartament);
        List<DepartamentProfesorInfo> DepartamentProfesorListByProfesor(long idProfesor);
        int DepartamentProfesorAdd(DepartamentProfesorInfo info);
        void DepartamentProfesorUpdate(DepartamentProfesorInfo info);
        void DepartamentProfesorDelete(long idDepartamentProfesor);
    }

    public class DepartamentProfesorRepo : IDepartamentProfesorRepo
    {
        private readonly string _connectionString;

        public DepartamentProfesorRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DepartamentProfesorInfo DepartamentProfesorGet(long idDepartamentProfesor)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DepartamentProfesorGet", idDepartamentProfesor))
                {
                    return CBO.FillObject<DepartamentProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea datelor despre profesorul din departament.", ex);
            }
        }

        public DepartamentProfesorInfo DepartamentProfesorGetByProfesor(long idProfesor)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DepartamentProfesorGetByProfesor", idProfesor))
                {
                    return CBO.FillObject<DepartamentProfesorInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea profesorului din departament după ID profesor.", ex);
            }
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorList()
        {
            try
            {
                return CBO.FillCollection<DepartamentProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DepartamentProfesorList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor din toate departamentele.", ex);
            }
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorListByDepartament(long idDepartament)
        {
            try
            {
                return CBO.FillCollection<DepartamentProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DepartamentProfesorListByDepartament", idDepartament));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea profesorilor după departament.", ex);
            }
        }

        public List<DepartamentProfesorInfo> DepartamentProfesorListByProfesor(long idProfesor)
        {
            try
            {
                return CBO.FillCollection<DepartamentProfesorInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DepartamentProfesorListByProfesor", idProfesor));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea departamentelor după profesor.", ex);
            }
        }

        public int DepartamentProfesorAdd(DepartamentProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "DepartamentProfesorAdd",
                    info.ID_Departament,
                    info.ID_Profesor,
                    info.DataDeCand,
                    info.DataPanaCand,
                    info.DepartamentProfesorActiv,
                    info.ID_AnUnivDepartament));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea profesorului în departament.", ex);
            }
        }

        public void DepartamentProfesorUpdate(DepartamentProfesorInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DepartamentProfesorUpdate",
                    info.ID_DepartamentProfesor,
                    info.ID_Departament,
                    info.ID_Profesor,
                    info.DataDeCand,
                    info.DataPanaCand,
                    info.DepartamentProfesorActiv,
                    info.ID_AnUnivDepartament);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea profesorului în departament.", ex);
            }
        }

        public void DepartamentProfesorDelete(long idDepartamentProfesor)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DepartamentProfesorDelete", idDepartamentProfesor);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea profesorului din departament.", ex);
            }
        }
    }
}
