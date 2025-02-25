using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using System.ComponentModel;

namespace UniApi.Dal.Repos
{
    public class MetaSpecializareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public MetaSpecializareInfo MetaSpecializareGet(long idMetaSpecializare)
        {
            return CBO.FillObject<MetaSpecializareInfo>(SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareGet", idMetaSpecializare));
        }

        public List<MetaSpecializareInfo> MetaSpecializareList()
        {
            return CBO.FillCollection<MetaSpecializareInfo>(SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareList"));
        }

        public List<MetaSpecializareInfo> MetaSpecializareListByFacultate(long idFacultate)
        {
            return CBO.FillCollection<MetaSpecializareInfo>(SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareListByFacultate", idFacultate));
        }

        public List<MetaSpecializareInfo> MetaSpecializareListBySpecializare(long idSpecializare)
        {
            return CBO.FillCollection<MetaSpecializareInfo>(SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareListBySpecializare", idSpecializare));
        }

        public long MetaSpecializareAdd(MetaSpecializareInfo objMetaSpecializare)
        {
            object obj = SqlHelper.ExecuteScalar(_connectionString, "MetaSpecializareAdd", objMetaSpecializare.denumiremetaspecializare, objMetaSpecializare.id_facultate);
            return Convert.ToInt64(obj);
        }

        public void MetaSpecializareUpdate(MetaSpecializareInfo objMetaSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "MetaSpecializareUpdate", objMetaSpecializare.id_metaspecializare, objMetaSpecializare.denumiremetaspecializare, objMetaSpecializare.id_facultate);
        }

        public void MetaSpecializareDelete(long idMetaSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "MetaSpecializareDelete", idMetaSpecializare);
        }
    }
}
