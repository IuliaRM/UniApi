using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TipCalificativPracticaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipCalificativPractica TipCalificativPracticaGet(long idTipCalificativPractica)
        {
            return CBO.FillObject<TipCalificativPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipCalificativPracticaeGet", idTipCalificativPractica));
        }

        public List<TipCalificativPractica> TipCalificativPracticaListGet()
        {
            return CBO.FillCollection<TipCalificativPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipCalificativPracticaList"));
        }

        public long TipCalificativPracticaAdd(TipCalificativPractica tipCalificativPractica)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TipCalificativPracticaAdd",
                tipCalificativPractica.DenumireTipCalificativPractica);

            return Convert.ToInt64(id);
        }

        public void TipCalificativPracticaDelete(long idTipCalificativPractica)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TipCalificativPracticaDelete", idTipCalificativPractica);
        }
    }
}
