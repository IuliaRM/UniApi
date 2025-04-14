using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAnUniversitarRepo
    {
        AnUniversitarInfo AnUniversitarGet(long idAnUniv);
        long AnUniversitarAdd(AnUniversitarInfo anUniversitarInfo);
        void AnUniversitarDelete(long idAnUniv);
        List<AnUniversitarInfo> AnUniversitarListByUsername(string username);
    }

    public class AnUniversitarRepo : IAnUniversitarRepo
    {
        private readonly string _connectionString;

        public AnUniversitarRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public AnUniversitarInfo AnUniversitarGet(long idAnUniv)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_Get", idAnUniv))
                {
                    return CBO.FillObject<AnUniversitarInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AnUniversitar.", ex);
            }
        }

        public long AnUniversitarAdd(AnUniversitarInfo anUniversitarInfo)
        {
            if (anUniversitarInfo == null)
                throw new ArgumentNullException(nameof(anUniversitarInfo));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AnUniversitar_Insert",
                    anUniversitarInfo.Denumire,
                    anUniversitarInfo.DataModificare,
                    anUniversitarInfo.ID_Utilizator,
                    anUniversitarInfo.Status,
                    anUniversitarInfo.PortalID,
                    anUniversitarInfo.DataInceputAnUniv,
                    anUniversitarInfo.DataSfirsitAnUniv
                );

                return Convert.ToInt64(id);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding AnUniversitar.", ex);
            }
        }

        public void AnUniversitarDelete(long idAnUniv)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitar_Delete", idAnUniv);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AnUniversitar.", ex);
            }
        }

        public List<AnUniversitarInfo> AnUniversitarListByUsername(string username)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_GetByID_Utilizator", username))
                {
                    return CBO.FillCollection<AnUniversitarInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AnUniversitar list by username.", ex);
            }
        }
    }
}
