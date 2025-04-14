using System;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IDiplomaSupplementAdeverintaAbsolvireRepo
    {
        DiplomaSupplementAdeverintaAbsolvireInfo StudentGet(long idStudent, long idFacultate, long idTipCiclu);
        DiplomaSupplementAdeverintaAbsolvireInfo ClasamentGet(long idStudent, long idFacultate, long idPlanInvatamant);
        DiplomaSupplementAdeverintaAbsolvireInfo MedieGeneralaGet(long idStudent, long idFacultate, long idPlanInvatamant);
        DiplomaSupplementAdeverintaAbsolvireInfo MedieFinalaGet(long idStudent, long idTipCiclu);
        DiplomaSupplementAdeverintaAbsolvireInfo SesiuneAbsolvireGet(long idStudent, long idTipCiclu);
        PlanInvatamantInfo SpecializareGet(long idPlanInvatamant, long idStudent);
        DiplomaSupplementAdeverintaAbsolvireInfo MediiAnualeSiCrediteGet(long idStudent, long idPlanInvatamant);
    }

    public class DiplomaSupplementAdeverintaAbsolvireRepo : IDiplomaSupplementAdeverintaAbsolvireRepo
    {
        private readonly string _connectionString;

        public DiplomaSupplementAdeverintaAbsolvireRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo StudentGet(long idStudent, long idFacultate, long idTipCiclu)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DiplomaSupplement_GetStudent_Adeverinta", idStudent, idFacultate, idTipCiclu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea studentului pentru supliment diploma.", ex);
            }
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo ClasamentGet(long idStudent, long idFacultate, long idPlanInvatamant)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DiplomaSupplement_GetClasament", idStudent, idFacultate, idPlanInvatamant));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea clasamentului.", ex);
            }
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieGeneralaGet(long idStudent, long idFacultate, long idPlanInvatamant)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DiplomaSupplement_GetMedieGenerala", idFacultate, idStudent, idPlanInvatamant));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea mediei generale.", ex);
            }
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieFinalaGet(long idStudent, long idTipCiclu)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "NotaMediePacheteAbsolvireGetByStudent", idStudent, idTipCiclu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea mediei finale.", ex);
            }
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo SesiuneAbsolvireGet(long idStudent, long idTipCiclu)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "PachetAbsolvireGetByStudent", idStudent, idTipCiclu));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea sesiunii de absolvire.", ex);
            }
        }

        public PlanInvatamantInfo SpecializareGet(long idPlanInvatamant, long idStudent)
        {
            try
            {
                return CBO.FillObject<PlanInvatamantInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "DiplomaSupplement_GetSpecializare", idPlanInvatamant, idStudent));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea specializarii.", ex);
            }
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MediiAnualeSiCrediteGet(long idStudent, long idPlanInvatamant)
        {
            try
            {
                return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "Rap_Absolvire_GetPerioadaSiMediiAnuale", idStudent, idPlanInvatamant));
            }
            catch (Exception ex)
            {
                throw new DataException("Eroare la obtinerea mediilor anuale si a creditelor.", ex);
            }
        }
    }
}
