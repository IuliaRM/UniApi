using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipCriteriuEvaluareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipCriteriuEvaluareInfo TipCriteriuEvaluareGet(long idTipCriteriuEvaluare)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<TipCriteriuEvaluareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipCriteriuEvaluareGet", idTipCriteriuEvaluare));
        }

        public List<TipCriteriuEvaluareInfo> TipCriteriuEvaluareListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<TipCriteriuEvaluareInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TipCriteriuEvaluareList"));
        }

        public int TipCriteriuEvaluareAdd(TipCriteriuEvaluareInfo tipCriteriuEvaluare)
        {
            return Convert.ToInt32(SqlHelper.ExecuteScalar(_connectionString, "TipCriteriuEvaluareAdd",
                tipCriteriuEvaluare.DescriereCriteriu,
                tipCriteriuEvaluare.ModVizualizare,
                tipCriteriuEvaluare.Intrebare,
                tipCriteriuEvaluare.IDRaspunsDefault,
                tipCriteriuEvaluare.IDText,
                tipCriteriuEvaluare.RaspunsObligatoriu,
                tipCriteriuEvaluare.MinText,
                tipCriteriuEvaluare.MaxText,
                tipCriteriuEvaluare.Dimensiune));
        }

        public void TipCriteriuEvaluareUpdate(TipCriteriuEvaluareInfo tipCriteriuEvaluare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipCriteriuEvaluareUpdate",
                tipCriteriuEvaluare.ID_TipCriteriuEvaluare,
                tipCriteriuEvaluare.DescriereCriteriu,
                tipCriteriuEvaluare.ModVizualizare,
                tipCriteriuEvaluare.Intrebare,
                tipCriteriuEvaluare.IDRaspunsDefault,
                tipCriteriuEvaluare.IDText,
                tipCriteriuEvaluare.RaspunsObligatoriu,
                tipCriteriuEvaluare.MinText,
                tipCriteriuEvaluare.MaxText,
                tipCriteriuEvaluare.Dimensiune);
        }

        public void TipCriteriuEvaluareDelete(long idTipCriteriuEvaluare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipCriteriuEvaluareDelete", idTipCriteriuEvaluare);
        }
    }
}
