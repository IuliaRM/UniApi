using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;
namespace UniApi.DAL.Repos
{
    public interface IPachetAbsolvireRepo
    {
        PachetAbsolvireInfo PachetAbsolvireGet(long idPachetAbsolvire);
        List<PachetAbsolvireInfo> PachetAbsolvireListGet();
        List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivIdSpecializare(long idAnUniv, long idSpecializare);
        PachetAbsolvireInfo PachetAbsolvireGetByStudent(long idStudent);
        List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivIdSpecializareActivaInscriereStudenti(long idAnUniv, long idSpecializare);
        List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivUsernameSecretar(long idAnUniv, string usernameSecretar);
        List<PachetAbsolvireInfo> PachetAbsolvireListSesiuneAbsolvire();
        List<PachetAbsolvireInfo> PachetAbsolvireListByIdSpecIdAnUniv(long idSpecializare, long idAnUniv);
        long PachetAbsolvireAdd(PachetAbsolvireInfo pachetAbs);
        void PachetAbsolvireUpdate(PachetAbsolvireInfo pachetAbs);
        void PachetAbsolvireDeleteByIdPachetAbsolvire(long idPachetAbsolvire);
    }

    public class PachetAbsolvireRepo : IPachetAbsolvireRepo
    {
        private readonly string _connectionString;

        public PachetAbsolvireRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found in configuration.");
            }
        }

        public PachetAbsolvireInfo PachetAbsolvireGet(long idPachetAbsolvire)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGet", idPachetAbsolvire))
                {
                    return CBO.FillObject<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireListGet()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireList"))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire list", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivIdSpecializare(long idAnUniv, long idSpecializare)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGetByAnUnivIdSpecializare", idAnUniv, idSpecializare))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire by AnUniv and Specializare", ex);
            }
        }

        public PachetAbsolvireInfo PachetAbsolvireGetByStudent(long idStudent)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGetByStudent", idStudent))
                {
                    return CBO.FillObject<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire by Student", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivIdSpecializareActivaInscriereStudenti(long idAnUniv, long idSpecializare)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGetByAnUnivIdSpecializareActivaInscriereStudenti", idAnUniv, idSpecializare))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving active PachetAbsolvire by AnUniv and Specializare", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireGetByAnUnivUsernameSecretar(long idAnUniv, string usernameSecretar)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGetByAnUnivUsernameSecretar", idAnUniv, usernameSecretar))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire by AnUniv and UsernameSecretar", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireListSesiuneAbsolvire()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireListSesiuneAbsolvire"))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire session list", ex);
            }
        }

        public List<PachetAbsolvireInfo> PachetAbsolvireListByIdSpecIdAnUniv(long idSpecializare, long idAnUniv)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireListByIdSpecIdAnUniv", idSpecializare, idAnUniv))
                {
                    return CBO.FillCollection<PachetAbsolvireInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving PachetAbsolvire by Specializare and AnUniv", ex);
            }
        }

        public long PachetAbsolvireAdd(PachetAbsolvireInfo pachetAbs)
        {
            if (pachetAbs == null)
                throw new ArgumentNullException(nameof(pachetAbs));

            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "PachetAbsolvireAdd",
                    pachetAbs.Id_AnUnivAbsolvire,
                    pachetAbs.Id_Specializare,
                    pachetAbs.DenumirePachet,
                    pachetAbs.DenumireSesiuneAbsolvire,
                    pachetAbs.AnSesiuneAbsolvire);

                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding PachetAbsolvire", ex);
            }
        }

        public void PachetAbsolvireUpdate(PachetAbsolvireInfo pachetAbs)
        {
            if (pachetAbs == null)
                throw new ArgumentNullException(nameof(pachetAbs));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PachetAbsolvireUpdate",
                    pachetAbs.Id_PachetAbsolvire,
                    pachetAbs.Id_AnUnivAbsolvire,
                    pachetAbs.Id_Specializare,
                    pachetAbs.DenumirePachet,
                    pachetAbs.DenumireSesiuneAbsolvire,
                    pachetAbs.ActivaInscriereStudenti,
                    pachetAbs.ID_ProfesorPresedinteComisie,
                    pachetAbs.CSVUsernameSecretariComisie,
                    pachetAbs.CSVUsernameMembriComisie,
                    pachetAbs.AnSesiuneAbsolvire);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating PachetAbsolvire", ex);
            }
        }

        public void PachetAbsolvireDeleteByIdPachetAbsolvire(long idPachetAbsolvire)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PachetAbsolvireDeleteByIdPachetAbsolvire", idPachetAbsolvire);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting PachetAbsolvire", ex);
            }
        }
    }
}