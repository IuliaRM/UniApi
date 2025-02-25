using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using DotNetNuke.Common.Utilities;

namespace UniApi.Dal.Repos
{
    public class EvaluareComentariiRepo
    {
        private readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<EvaluareComentariiInfo> GetComentariiByDetaliuPlanSemestru(long iD_DetaliuPlanSemestru)
        {
            return CBO.FillCollection<EvaluareComentariiInfo>(SqlHelper.ExecuteReader(_ConnectionString, "EvaluareGetComentariiByIDDetaliuPlanSemestru", iD_DetaliuPlanSemestru));
        }

        // If you want to implement the update method as well, you can follow a similar approach.
        /*
        public void UpdateTipCriteriuEvaluare(TipCriteriuEvaluareInfo objTipCriteriuEvaluare)
        {
            SqlHelper.ExecuteNonQuery(_ConnectionString, "TipCriteriuEvaluareUpdate", objTipCriteriuEvaluare.ID_TipCriteriuEvaluare, objTipCriteriuEvaluare.DescriereCriteriu, objTipCriteriuEvaluare.ModVizualizare, objTipCriteriuEvaluare.Intrebare, objTipCriteriuEvaluare.IDRaspunsDefault, objTipCriteriuEvaluare.IDText, objTipCriteriuEvaluare.RaspunsObligatoriu, objTipCriteriuEvaluare.MinText, objTipCriteriuEvaluare.MaxText, objTipCriteriuEvaluare.Dimensiune);
        }
        */
    }
}
