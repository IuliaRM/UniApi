using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipCriteriuEvaluareVarianteRaspunsRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipCriteriuEvaluareVarianteRaspunsInfo TipCriteriuEvaluareVarianteRaspunsGet(long idTipCriteriuEvaluareVariantaRaspuns)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipCriteriuEvaluareVarianteRaspunsInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipCriteriuEvaluareVarianteRaspunsGet", idTipCriteriuEvaluareVariantaRaspuns));
        }

        public List<TipCriteriuEvaluareVarianteRaspunsInfo> TipCriteriuEvaluareVarianteRaspunsListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipCriteriuEvaluareVarianteRaspunsInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipCriteriuEvaluareVarianteRaspunsList"));
        }

        public List<TipCriteriuEvaluareVarianteRaspunsInfo> TipCriteriuEvaluareVarianteRaspunsListByTipCriteriuEvaluareGet(long idTipCriteriuEvaluare)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipCriteriuEvaluareVarianteRaspunsInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipCriteriuEvaluareVarianteRaspunsListByTipCriteriuEvaluare", idTipCriteriuEvaluare));
        }

        public int TipCriteriuEvaluareVarianteRaspunsAdd(TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            return (int)SqlHelper.ExecuteScalar(_connectionString, "TipCriteriuEvaluareVarianteRaspunsAdd", obj.ID_TipCriteriuEvaluare, obj.TextRaspuns, obj.ValoareRaspuns);
        }

        public void TipCriteriuEvaluareVarianteRaspunsUpdate(TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipCriteriuEvaluareVarianteRaspunsUpdate", obj.ID_TipCriteriuEvaluareVariantaRaspuns, obj.ID_TipCriteriuEvaluare, obj.TextRaspuns, obj.ValoareRaspuns);
        }

        public void TipCriteriuEvaluareVarianteRaspunsDelete(TipCriteriuEvaluareVarianteRaspunsInfo obj)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipCriteriuEvaluareVarianteRaspunsDelete", obj.ID_TipCriteriuEvaluareVariantaRaspuns);
        }
    }
}
