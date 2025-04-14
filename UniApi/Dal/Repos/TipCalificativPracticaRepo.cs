using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipCalificativPracticaRepo
    {
        TipCalificativPractica TipCalificativPracticaGet(long idTipCalificativPractica);
        List<TipCalificativPractica> TipCalificativPracticaList();
    }

    public class TipCalificativPracticaRepo : ITipCalificativPracticaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipCalificativPractica TipCalificativPracticaGet(long idTipCalificativPractica)
        {
            return CBO.FillObject<TipCalificativPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipCalificativPracticaGet", idTipCalificativPractica));
        }

        public List<TipCalificativPractica> TipCalificativPracticaList()
        {
            return CBO.FillCollection<TipCalificativPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipCalificativPracticaList"));
        }
    }
}
