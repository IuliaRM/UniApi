using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AnUniversitarLunaBursaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<AnUniversitarLunaBursaInfo> AnUniversitarLunaBursaGetByAnUniv(long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUniv", idAnUniv));
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivAndNumarLuna(long idAnUniv, int numarLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUnivAndNumarLuna", idAnUniv, numarLuna));
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivAndOrdineLuna(long idAnUniv, int ordineLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUnivAndOrdineLuna", idAnUniv, ordineLuna));
        }

        public void AnUniversitarLunaBursaUpdate(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdate",
                lunaBursaInfo.ID_AnUnivLunaBursa,
                lunaBursaInfo.LunaInchisa,
                lunaBursaInfo.UserIDModificare);
        }

        public void AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndNumarLuna(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndNumarLuna",
                lunaBursaInfo.ID_AnUniv,
                lunaBursaInfo.NumarLuna,
                lunaBursaInfo.LunaInchisa,
                lunaBursaInfo.UserIDModificare);
        }

        public void AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndOrdineLuna(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndOrdineLuna",
                lunaBursaInfo.ID_AnUniv,
                lunaBursaInfo.OrdineLuna,
                lunaBursaInfo.LunaInchisa,
                lunaBursaInfo.UserIDModificare);
        }
    }
}
