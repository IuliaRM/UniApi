using System;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface ILichidareRepo
    {
        void LichidareSecretariatMerge(long idLichidare, long idAbsolvent, long idStudent, long idAnUniv, long idSpecializare, string usernameInitiere);
        void LichidareInitiereAutomata();
        void LichidareSecretariatDeselecteaza(long idLichidare, string username, string coloanaDebifata);
        LichidareInfo LichidareStudentGetByID(long idLichidare);
    }

    public class LichidareRepo : ILichidareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public void LichidareSecretariatMerge(long idLichidare, long idAbsolvent, long idStudent, long idAnUniv, long idSpecializare, string usernameInitiere)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Lichidare_SecretariatMerge", idLichidare, idAbsolvent, idStudent, idAnUniv, idSpecializare, usernameInitiere);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LichidareSecretariatMerge", ex);
            }
        }

        public void LichidareInitiereAutomata()
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Lichidare_InitiereAutomata");
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LichidareInitiereAutomata", ex);
            }
        }

        public void LichidareSecretariatDeselecteaza(long idLichidare, string username, string coloanaDebifata)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "Lichidare_SecretariatDeselecteaza", idLichidare, username, coloanaDebifata);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LichidareSecretariatDeselecteaza", ex);
            }
        }

        public LichidareInfo LichidareStudentGetByID(long idLichidare)
        {
            try
            {
                return CBO.FillObject<LichidareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Lichidare_GetStudentByID", idLichidare));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la LichidareStudentGetByID", ex);
            }
        }
    }
}
