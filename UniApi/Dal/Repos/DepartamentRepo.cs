using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDepartamentRepo
    {
        DepartamentInfo DepartamentGet(long idDepartament);
        List<DepartamentInfo> DepartamentList();
        int DepartamentAdd(DepartamentInfo info);
        void DepartamentUpdate(DepartamentInfo info);
        void DepartamentDelete(long idDepartament);
    }

    public class DepartamentRepo : IDepartamentRepo
    {
        private readonly string _connectionString;

        public DepartamentRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DepartamentInfo DepartamentGet(long idDepartament)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DepartamentGet", idDepartament))
                {
                    return CBO.FillObject<DepartamentInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obținerea departamentului.", ex);
            }
        }

        public List<DepartamentInfo> DepartamentList()
        {
            try
            {
                return CBO.FillCollection<DepartamentInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DepartamentList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea departamentelor.", ex);
            }
        }

        public int DepartamentAdd(DepartamentInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "DepartamentAdd",
                    info.DenumireDepartament,
                    info.DenumireScurtaDepartament));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adăugarea departamentului.", ex);
            }
        }

        public void DepartamentUpdate(DepartamentInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DepartamentUpdate",
                    info.ID_Departament,
                    info.DenumireDepartament,
                    info.DenumireScurtaDepartament);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea departamentului.", ex);
            }
        }

        public void DepartamentDelete(long idDepartament)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DepartamentDelete", idDepartament);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la ștergerea departamentului.", ex);
            }
        }
    }
}
