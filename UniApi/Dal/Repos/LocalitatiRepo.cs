using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ILocalitatiRepo
    {
        LocalitatiInfo LocalitatiGet(string idLocalitate);
        LocalitatiInfo LocalitatiGetByID_N_Localitate(int idNLocalitate);
        LocalitatiInfo LocalitatiGetByDenumireIdJudet(string denumire, string idJudet);
        DataTable LocalitatiListByCaractereDenumireIdJudet(string caractere, string idJudet);
        DataTable LocalitatiListByJudet(string idJudet);
        long LocalitatiAdd(LocalitatiInfo info);
        void LocalitatiUpdate(LocalitatiInfo info);
        void LocalitatiDelete(LocalitatiInfo info);
    }

    public class LocalitatiRepo : ILocalitatiRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public LocalitatiInfo LocalitatiGet(string idLocalitate)
        {
            try
            {
                return CBO.FillObject<LocalitatiInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Localitati_Get", idLocalitate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiGet", ex);
            }
        }

        public LocalitatiInfo LocalitatiGetByID_N_Localitate(int idNLocalitate)
        {
            try
            {
                return CBO.FillObject<LocalitatiInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Localitati_GetByID_N_Localitate", idNLocalitate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiGetByID_N_Localitate", ex);
            }
        }

        public LocalitatiInfo LocalitatiGetByDenumireIdJudet(string denumire, string idJudet)
        {
            try
            {
                return CBO.FillObject<LocalitatiInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Localitati_GetByDenumireIdJudet", denumire, idJudet));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiGetByDenumireIdJudet", ex);
            }
        }

        public DataTable LocalitatiListByCaractereDenumireIdJudet(string caractere, string idJudet)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "Localitati_GetListByCaractereDenumireIdJudet", caractere, idJudet).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiListByCaractereDenumireIdJudet", ex);
            }
        }

        public DataTable LocalitatiListByJudet(string idJudet)
        {
            try
            {
                return SqlHelper.ExecuteDataset(_connectionString, "Localitati_GetListByJudet", idJudet).Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiListByJudet", ex);
            }
        }

        public long LocalitatiAdd(LocalitatiInfo info)
        {
            try
            {
                return (long)SqlHelper.ExecuteScalar(_connectionString, "Localitati_Add", info.Localitate, info.URBAN_RURAL, info.ID_Judet);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiAdd", ex);
            }
        }

        public void LocalitatiUpdate(LocalitatiInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Localitati_Update", info.ID_Localitate, info.Localitate, info.URBAN_RURAL, info.ID_Judet);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiUpdate", ex);
            }
        }

        public void LocalitatiDelete(LocalitatiInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Localitati_Delete", info.ID_Localitate);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LocalitatiDelete", ex);
            }
        }
    }
}
