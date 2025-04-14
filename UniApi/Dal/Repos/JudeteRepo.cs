using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IJudeteRepo
    {
        JudeteInfo JudeteGet(string idJudet);
        JudeteInfo JudeteGetByID_N_Judet(int idNJudet);
        JudeteInfo JudeteGetByDenumire(string denumireJudet);
        DataTable JudeteList();
        DataTable JudeteListByCaractere(string caractere, int topN);
        int JudeteAdd(JudeteInfo info);
        void JudeteUpdate(JudeteInfo info);
        void JudeteDelete(JudeteInfo info);
    }

    public class JudeteRepo : IJudeteRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public JudeteInfo JudeteGet(string idJudet)
        {
            try
            {
                return CBO.FillObject<JudeteInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Judete_Get", idJudet));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteGet", ex);
            }
        }

        public JudeteInfo JudeteGetByID_N_Judet(int idNJudet)
        {
            try
            {
                return CBO.FillObject<JudeteInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Judete_GetByID_N_Judet", idNJudet));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteGetByID_N_Judet", ex);
            }
        }

        public JudeteInfo JudeteGetByDenumire(string denumireJudet)
        {
            try
            {
                return CBO.FillObject<JudeteInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Judete_GetByDenumire", denumireJudet));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteGetByDenumire", ex);
            }
        }

        public DataTable JudeteList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "Judete_GetList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteList", ex);
            }
        }

        public DataTable JudeteListByCaractere(string caractere, int topN)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "Judete_GetListByCaractere", caractere, topN).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteListByCaractere", ex);
            }
        }

        public int JudeteAdd(JudeteInfo info)
        {
            try
            {
                return (int)SqlHelper.ExecuteScalar(_connectionString, "Judete_Add", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteAdd", ex);
            }
        }

        public void JudeteUpdate(JudeteInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Judete_Update", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteUpdate", ex);
            }
        }

        public void JudeteDelete(JudeteInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Judete_Delete", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la JudeteDelete", ex);
            }
        }
    }
}
