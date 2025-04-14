using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IScenariuRepo
    {
        ScenariuInfo ScenariuGet(long idScenariu);
        ScenariuInfo ScenariuGetScenariuActiv(long idCatedra, long idAnUniv);
        List<ScenariuInfo> ScenariuListByAnUniversitar(long idAnUniv);
        List<ScenariuInfo> ScenariuListByCatedra(long idCatedra);
        List<ScenariuInfo> ScenariuListByCatedraAnUniv(long idCatedra, long idAnUniv);
        long ScenariuAdd(ScenariuInfo scenariuInfo);
        long ScenariuAddDinAltScenariu(long idScenariuSursa, string denumireScenariu, long idAnUnivCurent, long idCatedra, long idUtilizator);
        void ScenariuUpdate(ScenariuInfo scenariuInfo);
        void ScenariuUpdateScenariuActiv(long idScenariu, bool scenariuActiv, long idCatedra, long idAnUniv, DateTime dataModificare, long idUtilizator);
        void ScenariuDelete(long idScenariu);
    }

    public class ScenariuRepo : IScenariuRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ScenariuInfo ScenariuGet(long idScenariu)
        {
            return CBO.FillObject<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuGet", idScenariu));
        }

        public ScenariuInfo ScenariuGetScenariuActiv(long idCatedra, long idAnUniv)
        {
            return CBO.FillObject<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuGetScenariuActiv", idCatedra, idAnUniv));
        }

        public List<ScenariuInfo> ScenariuListByAnUniversitar(long idAnUniv)
        {
            return CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByAnUniversitar", idAnUniv));
        }

        public List<ScenariuInfo> ScenariuListByCatedra(long idCatedra)
        {
            return CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByCatedra", idCatedra));
        }

        public List<ScenariuInfo> ScenariuListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            return CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByCatedraAnUniv", idCatedra, idAnUniv));
        }

        public long ScenariuAdd(ScenariuInfo scenariuInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ScenariuAdd",
                scenariuInfo.DenumireScenariu,
                scenariuInfo.ScenariuActiv,
                scenariuInfo.ID_Catedra,
                scenariuInfo.ID_AnUniv,
                scenariuInfo.DataModificare,
                scenariuInfo.ID_Utilizator);
            return Convert.ToInt64(id);
        }

        public long ScenariuAddDinAltScenariu(long idScenariuSursa, string denumireScenariu, long idAnUnivCurent, long idCatedra, long idUtilizator)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ScenariuAddDinAltScenariu",
                idScenariuSursa,
                denumireScenariu,
                idAnUnivCurent,
                idCatedra,
                idUtilizator);
            return Convert.ToInt64(id);
        }

        public void ScenariuUpdate(ScenariuInfo scenariuInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuUpdate",
                scenariuInfo.ID_Scenariu,
                scenariuInfo.DenumireScenariu,
                scenariuInfo.ScenariuActiv,
                scenariuInfo.ID_Catedra,
                scenariuInfo.ID_AnUniv,
                scenariuInfo.DataModificare,
                scenariuInfo.ID_Utilizator);
        }

        public void ScenariuUpdateScenariuActiv(long idScenariu, bool scenariuActiv, long idCatedra, long idAnUniv, DateTime dataModificare, long idUtilizator)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuUpdateScenariuActiv",
                idScenariu,
                scenariuActiv,
                idCatedra,
                idAnUniv,
                dataModificare,
                idUtilizator);
        }

        public void ScenariuDelete(long idScenariu)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuDelete", idScenariu);
        }
    }
}
