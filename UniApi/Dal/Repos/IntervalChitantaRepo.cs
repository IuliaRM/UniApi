using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IIntervalChitantaRepo
    {
        IntervalChitantaInfo IntervalChitantaGet(long id);
        IntervalChitantaInfo IntervalChitantaGetIntervalActiv(int idUtilizator);
        int IntervalChitantaGetUltimulNumarDeChitanta(int idUtilizator);
        DataTable IntervalChitantaList();
        DataTable IntervalChitantaListByID_Utilizator(int idUtilizator);
        long IntervalChitantaAdd(IntervalChitantaInfo info);
        void IntervalChitantaUpdate(IntervalChitantaInfo info);
        void IntervalChitantaDelete(IntervalChitantaInfo info);
        int IntervalChitantaSeteazaUrmatorulNumarDeChitanta(int idUtilizator);
    }

    public class IntervalChitantaRepo : IIntervalChitantaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public IntervalChitantaInfo IntervalChitantaGet(long id)
        {
            try
            {
                return CBO.FillObject<IntervalChitantaInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "IntervalChitanta_GetIntervalChitanta", id));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaGet", ex);
            }
        }

        public IntervalChitantaInfo IntervalChitantaGetIntervalActiv(int idUtilizator)
        {
            try
            {
                return CBO.FillObject<IntervalChitantaInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "IntervalChitanta_GetIntervalChitantaByUtilizator", idUtilizator));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaGetIntervalActiv", ex);
            }
        }

        public int IntervalChitantaGetUltimulNumarDeChitanta(int idUtilizator)
        {
            try
            {
                return (int)SqlHelper.ExecuteScalar(_connectionString, "IntervalChitanta_GetUltimulNumarDeChitanta", idUtilizator);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaGetUltimulNumarDeChitanta", ex);
            }
        }

        public DataTable IntervalChitantaList()
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "IntervalChitanta_GetIntervalChitantaList").Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaList", ex);
            }
        }

        public DataTable IntervalChitantaListByID_Utilizator(int idUtilizator)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "IntervalChitanta_GetIntervalChitantaListByUtilizator", idUtilizator).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaListByID_Utilizator", ex);
            }
        }

        public long IntervalChitantaAdd(IntervalChitantaInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "IntervalChitanta_AddIntervalChitanta", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaAdd", ex);
            }
        }

        public void IntervalChitantaUpdate(IntervalChitantaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "IntervalChitanta_UpdateIntervalChitanta", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaUpdate", ex);
            }
        }

        public void IntervalChitantaDelete(IntervalChitantaInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "IntervalChitanta_DeleteIntervalChitanta", info);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaDelete", ex);
            }
        }

        public int IntervalChitantaSeteazaUrmatorulNumarDeChitanta(int idUtilizator)
        {
            try
            {
                return (int)SqlHelper.ExecuteScalar(_connectionString, "IntervalChitanta_SeteazaUrmatorulNumarDeChitanta", idUtilizator);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la IntervalChitantaSeteazaUrmatorulNumarDeChitanta", ex);
            }
        }
    }
}
