using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface ITipPracticaRepo
    {
        TipPractica TipPracticaGet(int idTipPractica);
        List<TipPractica> TipPracticaList();
    }

    public class TipPracticaRepo : ITipPracticaRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public TipPractica TipPracticaGet(int idTipPractica)
        {
            return CBO.FillObject<TipPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipPracticaGet", idTipPractica));
        }

        public List<TipPractica> TipPracticaList()
        {
            return CBO.FillCollection<TipPractica>(
                SqlHelper.ExecuteReader(_connectionString, "TipPracticaList"));
        }
    }
}
