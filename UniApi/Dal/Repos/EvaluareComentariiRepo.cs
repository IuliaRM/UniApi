using System;
using System.Collections.Generic;
using UniApi.Info;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareComentariiRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<EvaluareComentariiInfo> ComentariiByDetaliuPlanSemestruGet(long ID_DetaliuPlanSemestru)
        {
            return CBO.FillCollection<EvaluareComentariiInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Evaluare_GetComentariiByDetaliuPlanSemestru", ID_DetaliuPlanSemestru));
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieAnStudiiGet(long ID_Student, long ID_PlanInvatamant)
        {
            return CBO.FillObject<DiplomaSupplementAdeverintaAbsolvireInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "Rap_Absolvire_GetMedieAnStudii", ID_Student, ID_PlanInvatamant));
        }
    }
}
