using System;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DiplomaSupplementAdeverintaAbsolvireRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DiplomaSupplementAdeverintaAbsolvireInfo StudentGet(long ID_Student, long ID_Facultate, long ID_TipCiclu)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DiplomaSupplement_GetStudent_Adeverinta", ID_Student, ID_Facultate, ID_TipCiclu));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo ClasamentGet(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DiplomaSupplement_GetClasament", ID_Student, ID_Facultate, ID_PlanInvatamant));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieGeneralaGet(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DiplomaSupplement_GetMedieGenerala", ID_Facultate, ID_Student, ID_PlanInvatamant));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieFinalaGet(long ID_Student, long ID_TipCiclu)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "[NotaMediePacheteAbsolvireGetByStudent]", ID_Student, ID_TipCiclu));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo SesiuneAbsolvireGet(long ID_Student, long ID_TipCiclu)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "PachetAbsolvireGetByStudent", ID_Student, ID_TipCiclu));
        }

        public PlanInvatamantInfo SpecializareGet(long ID_PlanInvatamant, long ID_Student)
        {
            return CBO.FillObject<PlanInvatamantInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DiplomaSupplement_GetSpecializare", ID_PlanInvatamant, ID_Student));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MediiAnualeSiCrediteGet(long ID_Student, long ID_PlanInvatamant)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Rap_Absolvire_GetPerioadaSiMediiAnuale", ID_Student, ID_PlanInvatamant));
        }
    }
}
