using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class RaspunsCriteriuEvaluareMaterieRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public RaspunsCriteriuEvaluareMaterieInfo RaspunsCriteriuEvaluareMaterieGet(long idRaspunsCriteriuEvaluareMaterie)
        {
            return CBO.FillObject<RaspunsCriteriuEvaluareMaterieInfo>(
                SqlHelper.ExecuteReader(_connectionString, "RaspunsCriteriuEvaluareMaterieGet", idRaspunsCriteriuEvaluareMaterie));
        }

        public List<RaspunsCriteriuEvaluareMaterieInfo> RaspunsCriteriuEvaluareMaterieListGet()
        {
            return CBO.FillCollection<RaspunsCriteriuEvaluareMaterieInfo>(
                SqlHelper.ExecuteReader(_connectionString, "RaspunsCriteriuEvaluareMaterieList"));
        }

        public List<RaspunsCriteriuEvaluareMaterieInfo> RaspunsCriteriuEvaluareMaterieListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            return CBO.FillCollection<RaspunsCriteriuEvaluareMaterieInfo>(
                SqlHelper.ExecuteReader(_connectionString, "RaspunsCriteriuEvaluareMaterieListByDetaliuPlanSemestru", idDetaliuPlanSemestru));
        }

        public List<RaspunsCriteriuEvaluareMaterieInfo> RaspunsCriteriuEvaluareMaterieListByTipCriteriuEvaluareVarianteRaspunsGet(long idTipCriteriuEvaluareVariantaRaspuns)
        {
            return CBO.FillCollection<RaspunsCriteriuEvaluareMaterieInfo>(
                SqlHelper.ExecuteReader(_connectionString, "RaspunsCriteriuEvaluareMaterieListByTipCriteriuEvaluareVarianteRaspuns", idTipCriteriuEvaluareVariantaRaspuns));
        }

        public void RaspunsCriteriuEvaluareMaterieAdd(RaspunsCriteriuEvaluareMaterieInfo objRaspunsCriteriuEvaluareMaterie)
        {
            if (objRaspunsCriteriuEvaluareMaterie.ID_TipCriteriuEvaluareVariantaRaspuns == -1)
                SqlHelper.ExecuteScalar(_connectionString, "RaspunsCriteriuEvaluareMaterieAdd", objRaspunsCriteriuEvaluareMaterie.ID_DetaliuPlanSemestru, null, objRaspunsCriteriuEvaluareMaterie.ComentariuRaspuns);
            else
                SqlHelper.ExecuteScalar(_connectionString, "RaspunsCriteriuEvaluareMaterieAdd", objRaspunsCriteriuEvaluareMaterie.ID_DetaliuPlanSemestru, objRaspunsCriteriuEvaluareMaterie.ID_TipCriteriuEvaluareVariantaRaspuns, objRaspunsCriteriuEvaluareMaterie.ComentariuRaspuns);
        }

        public void RaspunsCriteriuEvaluareMaterieUpdate(RaspunsCriteriuEvaluareMaterieInfo objRaspunsCriteriuEvaluareMaterie)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "RaspunsCriteriuEvaluareMaterieUpdate", objRaspunsCriteriuEvaluareMaterie.ID_RaspunsCriteriuEvaluareMaterie, objRaspunsCriteriuEvaluareMaterie.ID_DetaliuPlanSemestru, objRaspunsCriteriuEvaluareMaterie.ID_TipCriteriuEvaluareVariantaRaspuns, objRaspunsCriteriuEvaluareMaterie.ComentariuRaspuns);
        }

        public void RaspunsCriteriuEvaluareMaterieDelete(long idRaspunsCriteriuEvaluareMaterie)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "RaspunsCriteriuEvaluareMaterieDelete", idRaspunsCriteriuEvaluareMaterie);
        }
    }
}
