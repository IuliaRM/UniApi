using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ScenariuRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ScenariuInfo ScenariuGet(long idScenariu)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuGet", idScenariu));
        }

        public ScenariuInfo ScenariuActivGet(long idCatedra, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuGetScenariuActiv", idCatedra, idAnUniv));
        }

        public List<ScenariuInfo> ScenariuListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuList"));
        }

        public List<ScenariuInfo> ScenariuListByAnUniversitarGet(long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByAnUniversitar", idAnUniv));
        }

        public List<ScenariuInfo> ScenariuListByCatedraGet(long idCatedra)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByCatedra", idCatedra));
        }

        public List<ScenariuInfo> ScenariuListByCatedraAnUnivGet(long idCatedra, long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ScenariuInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ScenariuListByCatedraAnUniv", idCatedra, idAnUniv));
        }

        public long ScenariuAdd(ScenariuInfo scenariuInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ScenariuAdd",
                scenariuInfo.DenumireScenariu, scenariuInfo.ScenariuActiv, scenariuInfo.ID_Catedra,
                scenariuInfo.ID_AnUniv, scenariuInfo.DataModificare, scenariuInfo.ID_Utilizator);
            return Convert.ToInt64(id);
        }

        public long ScenariuDinAltScenariuAdd(long idScenariuSursa, string denumireScenariu,
                                               long idAnUnivCurent, long idCatedra, long idUtilizator)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "ScenariuAddDinAltScenariu",
                idScenariuSursa, denumireScenariu, idAnUnivCurent, idCatedra, idUtilizator);
            return Convert.ToInt64(id);
        }

        public void ScenariuUpdate(ScenariuInfo scenariuInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuUpdate",
                scenariuInfo.ID_Scenariu, scenariuInfo.DenumireScenariu, scenariuInfo.ScenariuActiv,
                scenariuInfo.ID_Catedra, scenariuInfo.ID_AnUniv, scenariuInfo.DataModificare,
                scenariuInfo.ID_Utilizator);
        }

        public void ScenariuActivUpdate(ScenariuInfo scenariuInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuUpdateScenariuActiv",
                scenariuInfo.ID_Scenariu, scenariuInfo.ScenariuActiv, scenariuInfo.ID_Catedra,
                scenariuInfo.ID_AnUniv, scenariuInfo.DataModificare, scenariuInfo.ID_Utilizator);
        }

        public void ScenariuDelete(ScenariuInfo scenariuInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ScenariuDelete", scenariuInfo.ID_Scenariu);
        }
    }
}
