using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDetaliuPlanSemestruProfesorCuplajRepo
    {
        DetaliuPlanSemestruProfesorCuplajInfo DetaliuPlanSemestruProfesorCuplajGet(long id);
        List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajList();
        List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor(long idDetaliu);
        List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajListByDetaliuCuplaj(long idCuplaj);
        int DetaliuPlanSemestruProfesorCuplajAdd(DetaliuPlanSemestruProfesorCuplajInfo info);
        void DetaliuPlanSemestruProfesorCuplajUpdate(DetaliuPlanSemestruProfesorCuplajInfo info);
        void DetaliuPlanSemestruProfesorCuplajDelete(long id);
        void DetaliuPlanSemestruProfesorCuplajDeleteByPostProfesor(long idCuplaj, long idPostProfesor);
    }

    public class DetaliuPlanSemestruProfesorCuplajRepo : IDetaliuPlanSemestruProfesorCuplajRepo
    {
        private readonly string _connectionString;

        public DetaliuPlanSemestruProfesorCuplajRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DetaliuPlanSemestruProfesorCuplajInfo DetaliuPlanSemestruProfesorCuplajGet(long id)
        {
            try
            {
                using (var dr = SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajGet", id))
                {
                    return CBO.FillObject<DetaliuPlanSemestruProfesorCuplajInfo>(dr);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea detaliului cuplajului profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajList()
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajList"));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cuplajelor profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor(long idDetaliu)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor", idDetaliu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cuplajelor dupa detaliu plan semestru profesor.", ex);
            }
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> DetaliuPlanSemestruProfesorCuplajListByDetaliuCuplaj(long idCuplaj)
        {
            try
            {
                return CBO.FillCollection<DetaliuPlanSemestruProfesorCuplajInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DetaliuPlanSemestruProfesorCuplajListByDetaliuCuplaj", idCuplaj));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la listarea cuplajelor dupa detaliu cuplaj.", ex);
            }
        }

        public int DetaliuPlanSemestruProfesorCuplajAdd(DetaliuPlanSemestruProfesorCuplajInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "DetaliuPlanSemestruProfesorCuplajAdd",
                    info.ID_DetaliuPlanSemestruProfesor,
                    info.ID_Cuplaj,
                    info.Observatii));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la adaugarea cuplajului profesor.", ex);
            }
        }

        public void DetaliuPlanSemestruProfesorCuplajUpdate(DetaliuPlanSemestruProfesorCuplajInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruProfesorCuplajUpdate",
                    info.ID_DetaliuPlanSemestruProfesorCuplaj,
                    info.ID_DetaliuPlanSemestruProfesor,
                    info.ID_Cuplaj,
                    info.Observatii);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la actualizarea cuplajului profesor.", ex);
            }
        }

        public void DetaliuPlanSemestruProfesorCuplajDelete(long id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruProfesorCuplajDelete", id);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea cuplajului profesor.", ex);
            }
        }

        public void DetaliuPlanSemestruProfesorCuplajDeleteByPostProfesor(long idCuplaj, long idPostProfesor)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "DetaliuPlanSemestruProfesorCuplajDeleteByPostProfesor",
                    idCuplaj, idPostProfesor);
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la stergerea cuplajului dupa post profesor.", ex);
            }
        }
    }
}
