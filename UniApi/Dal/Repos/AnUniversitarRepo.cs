using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class AnUniversitarRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AnUniversitarInfo AnUniversitarGet(long idAnUniv)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_Get", idAnUniv))
            {
                return (AnUniversitarInfo)CBO.FillObject(dr, typeof(AnUniversitarInfo));
            }
        }

        public List<AnUniversitarInfo> AnUniversitarListByUtilizator(int idUtilizator)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                using (var dr = SqlHelper.ExecuteReader(sqlConnection, "AnUniversitar_GetByID_Utilizator", idUtilizator))
                {
                    return CBO.FillCollection<AnUniversitarInfo>(dr);
                }
            }
        }

        public List<AnUniversitarInfo> AnUniversitarListAll()
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_List"))
            {
                return CBO.FillCollection<AnUniversitarInfo>(dr);
            }
        }

        public AnUniversitarInfo AnUniversitarGetByAnCalendaristic(int anCalendaristic)
        {
            var listAnUniv = AnUniversitarListAll();
            var result = listAnUniv.FirstOrDefault(
                li => li.Denumire.ToLower().StartsWith("an universitar " + anCalendaristic.ToString()));
            return result ?? listAnUniv.Last();
        }

        public int AnUniversitarAdd(AnUniversitarInfo anUniversitarInfo)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "AnUniversitar_Insert",
                anUniversitarInfo.Denumire,
                anUniversitarInfo.DataModificare,
                anUniversitarInfo.ID_Utilizator,
                anUniversitarInfo.Status,
                anUniversitarInfo.PortalID,
                anUniversitarInfo.DataInceputAnUniv,
                anUniversitarInfo.DataSfirsitAnUniv));
        }

        public void AnUniversitarUpdate(AnUniversitarInfo anUniversitarInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitar_Update",
                anUniversitarInfo.ID_AnUniv,
                anUniversitarInfo.Denumire,
                anUniversitarInfo.DataModificare,
                anUniversitarInfo.ID_Utilizator,
                anUniversitarInfo.Status,
                anUniversitarInfo.PortalID,
                anUniversitarInfo.DataInceputAnUniv,
                anUniversitarInfo.DataSfirsitAnUniv);
        }

        public void AnUniversitarDelete(long idAnUniv)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitar_Delete", idAnUniv);
        }

        public AnUniversitarInfo AnUniversitarGetNextYear(long idAnUniversitarCurent)
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_getNextYear", idAnUniversitarCurent))
            {
                return (AnUniversitarInfo)CBO.FillObject(dr, typeof(AnUniversitarInfo));
            }
        }

        public List<AnUniversitarInfo> AnUniversitarListWithPrevious()
        {
            using (var dr = SqlHelper.ExecuteReader(_connectionString, "AnUniversitar_GetCurrentAndPrevious"))
            {
                return CBO.FillCollection<AnUniversitarInfo>(dr);
            }
        }

        public AnUniversitarInfo AnUniversitarGetPrevious(long idAnUniversitarCurent)
        {
            var currentYear = AnUniversitarGet(idAnUniversitarCurent);
            return AnUniversitarGet(currentYear.Id_AnUnivPrecedent);
        }
    }
}
