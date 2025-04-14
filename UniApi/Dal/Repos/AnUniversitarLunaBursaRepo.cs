using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAnUniversitarLunaBursaRepo
    {
        List<AnUniversitarLunaBursaInfo> AnUniversitarLunaBursaListaByAnUniv(long idAnUniv);
        AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUniversitarNumarLuna(long idAnUniv, int numarLuna);
        AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivOrdineLuna(long idAnUniv, int ordineLuna);
        void AnUniversitarLunaBursaUpdate(AnUniversitarLunaBursaInfo lunaBursaInfo);
        void AnUniversitarLunaBursaUpdateInchisaByAnUnivNumarLuna(AnUniversitarLunaBursaInfo lunaBursaInfo);
        void AnUniversitarLunaBursaUpdateInchisaByAnUniv(AnUniversitarLunaBursaInfo lunaBursaInfo);
    }

    public class AnUniversitarLunaBursaRepo : IAnUniversitarLunaBursaRepo
    {
        private readonly string _connectionString;

        public AnUniversitarLunaBursaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public List<AnUniversitarLunaBursaInfo> AnUniversitarLunaBursaListaByAnUniv(long idAnUniv)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaListaByAnUniv", idAnUniv))
                {
                    return CBO.FillCollection<AnUniversitarLunaBursaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving list of months by AnUniversitar.", ex);
            }
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUniversitarNumarLuna(long idAnUniv, int numarLuna)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUniversitarNumarLuna", idAnUniv, numarLuna))
                {
                    return CBO.FillObject<AnUniversitarLunaBursaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving luna bursa by numar luna.", ex);
            }
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivOrdineLuna(long idAnUniv, int ordineLuna)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUnivOrdineLuna", idAnUniv, ordineLuna))
                {
                    return CBO.FillObject<AnUniversitarLunaBursaInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving luna bursa by ordine luna.", ex);
            }
        }

        public void AnUniversitarLunaBursaUpdate(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            if (lunaBursaInfo == null)
                throw new ArgumentNullException(nameof(lunaBursaInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdate",
                    lunaBursaInfo.ID_AnUnivLunaBursa,
                    lunaBursaInfo.LunaInchisa,
                    lunaBursaInfo.UserIDModificare
                );
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating luna bursa.", ex);
            }
        }

        public void AnUniversitarLunaBursaUpdateInchisaByAnUnivNumarLuna(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            if (lunaBursaInfo == null)
                throw new ArgumentNullException(nameof(lunaBursaInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateInchisaByAnUnivNumarLuna",
                    lunaBursaInfo.ID_AnUniv,
                    lunaBursaInfo.NumarLuna,
                    lunaBursaInfo.LunaInchisa,
                    lunaBursaInfo.UserIDModificare
                );
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating inchidere luna by numar luna.", ex);
            }
        }

        public void AnUniversitarLunaBursaUpdateInchisaByAnUniv(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            if (lunaBursaInfo == null)
                throw new ArgumentNullException(nameof(lunaBursaInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateInchisaByAnUniv",
                    lunaBursaInfo.ID_AnUniv,
                    lunaBursaInfo.LunaInchisa,
                    lunaBursaInfo.UserIDModificare
                );
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating inchidere pe toate lunile unui an.", ex);
            }
        }
    }
}
