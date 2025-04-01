using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public DetaliuPlanSemestruInfo DetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            return CBO.FillObject<DetaliuPlanSemestruInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruGet", idDetaliuPlanSemestru)
            );
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestru(long idPlanSemestru)
        {
            return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruListByPlanSemestru", idPlanSemestru)
            );
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByMaterie(long idMaterie)
        {
            return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                SqlHelper.ExecuteReader(_ConnectionString, "DetaliuPlanSemestruListByMaterie", idMaterie)
            );
        }

        public int DetaliuPlanSemestruAdd(DetaliuPlanSemestruInfo objDetaliuPlanSemestru)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(
                _ConnectionString, "DetaliuPlanSemestruAdd",
                objDetaliuPlanSemestru.ID_PlanSemestru,
                objDetaliuPlanSemestru.ID_Materie,
                objDetaliuPlanSemestru.NumarPachet,
                objDetaliuPlanSemestru.TipDisciplinaCriteriul1,
                objDetaliuPlanSemestru.TipDisciplinaCriteriul2,
                objDetaliuPlanSemestru.NrOreCurs,
                objDetaliuPlanSemestru.NrOreSeminar,
                objDetaliuPlanSemestru.NrOreLaborator,
                objDetaliuPlanSemestru.NrOreProiect,
                objDetaliuPlanSemestru.TipVerificare,
                objDetaliuPlanSemestru.Ordine,
                objDetaliuPlanSemestru.NrFormatiiCurs,
                objDetaliuPlanSemestru.NrFormatiiSeminar,
                objDetaliuPlanSemestru.NrFormatiiLaborator,
                objDetaliuPlanSemestru.NrFormatiiProiect
            ));
        }

        public void DetaliuPlanSemestruDelete(long idDetaliuPlanSemestru)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DetaliuPlanSemestruDelete", idDetaliuPlanSemestru);
        }

        public void DetaliuPlanSemestruUpdateMaterieSursaInDestinatie(long idMaterieSursa, long idMaterieDestinatie)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "DetaliuPlanSemestruUpdateMaterieSursaInDestinatie",
                idMaterieSursa,
                idMaterieDestinatie
            );
        }
    }
}
