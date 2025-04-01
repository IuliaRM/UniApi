using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipPracticaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipPractica TipPracticaGet(int idTipPractica)
        {
            return CBO.FillObject<TipPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipPracticaGet", idTipPractica));
        }

        public List<TipPractica> TipPracticaListGet()
        {
            return CBO.FillCollection<TipPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipPracticaList"));
        }

        public int TipPracticaAdd(TipPractica tipPractica)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipPracticaAdd",
                tipPractica.DenumireTipPractica); 

            return Convert.ToInt32(id);
        }

        public void TipPracticaDelete(int idTipPractica)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipPracticaDelete", idTipPractica);
        }
    }
}
