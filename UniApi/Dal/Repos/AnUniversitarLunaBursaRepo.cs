using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;


namespace UniApi.Dal.Repos
{
    public class AnUniversitarLunaBursaRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<AnUniversitarLunaBursaInfo> AnUniversitarLunaBursaListByAnUniv(long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaListByAnUniv", idAnUniv));
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivAndNumarLuna(long idAnUniv, int numarLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUnivNumarLuna", idAnUniv, numarLuna));
        }

        public AnUniversitarLunaBursaInfo AnUniversitarLunaBursaGetByAnUnivAndOrdineLuna(long idAnUniv, int ordineLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AnUniversitarLunaBursaInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AnUniversitarLunaBursaGetByAnUnivOrdineLuna", idAnUniv, ordineLuna));
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
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivNumarLuna",
                lunaBursaInfo.ID_AnUniv,
                lunaBursaInfo.NumarLuna,
                lunaBursaInfo.LunaInchisa,
                lunaBursaInfo.UserIDModificare);
        }

        public void AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndOrdineLuna(AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivOrdineLuna",
                lunaBursaInfo.ID_AnUniv,
                lunaBursaInfo.OrdineLuna,
                lunaBursaInfo.LunaInchisa,
                lunaBursaInfo.UserIDModificare);
        }
    }
}
