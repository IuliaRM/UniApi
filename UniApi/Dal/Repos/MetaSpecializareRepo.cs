using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IMetaSpecializareRepo
    {
        MetaSpecializareInfo MetaSpecializareGet(long idMetaSpecializare);
        List<MetaSpecializareInfo> MetaSpecializareList();
        List<MetaSpecializareInfo> MetaSpecializareListByFacultate(long idFacultate);
        List<MetaSpecializareInfo> MetaSpecializareListBySpecializare(long idSpecializare);
        List<MetaSpecializareInfo> MetaSpecializareListByCatedraAnUniv(long idCatedra, long idAnUniv);
        long MetaSpecializareAdd(MetaSpecializareInfo info);
        void MetaSpecializareUpdate(MetaSpecializareInfo info);
        void MetaSpecializareDelete(long idMetaSpecializare);
    }

    public class MetaSpecializareRepo : IMetaSpecializareRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public MetaSpecializareInfo MetaSpecializareGet(long idMetaSpecializare)
        {
            try
            {
                return CBO.FillObject<MetaSpecializareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareGet", idMetaSpecializare));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareGet", ex);
            }
        }

        public List<MetaSpecializareInfo> MetaSpecializareList()
        {
            try
            {
                return CBO.FillCollection<MetaSpecializareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareList"));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareList", ex);
            }
        }

        public List<MetaSpecializareInfo> MetaSpecializareListByFacultate(long idFacultate)
        {
            try
            {
                return CBO.FillCollection<MetaSpecializareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareListByFacultate", idFacultate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareListByFacultate", ex);
            }
        }

        public List<MetaSpecializareInfo> MetaSpecializareListBySpecializare(long idSpecializare)
        {
            try
            {
                return CBO.FillCollection<MetaSpecializareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareListBySpecializare", idSpecializare));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareListBySpecializare", ex);
            }
        }

        public List<MetaSpecializareInfo> MetaSpecializareListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                return CBO.FillCollection<MetaSpecializareInfo>(
                    SqlHelper.ExecuteReader(_connectionString, "MetaSpecializareListByCatedraAnUniv", idCatedra, idAnUniv));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareListByCatedraAnUniv", ex);
            }
        }

        public long MetaSpecializareAdd(MetaSpecializareInfo info)
        {
            try
            {
                return Convert.ToInt64(SqlHelper.ExecuteScalar(
                    _connectionString, "MetaSpecializareAdd", info.denumiremetaspecializare, info.id_facultate));
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareAdd", ex);
            }
        }

        public void MetaSpecializareUpdate(MetaSpecializareInfo info)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "MetaSpecializareUpdate",
                    info.id_metaspecializare, info.denumiremetaspecializare, info.id_facultate);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareUpdate", ex);
            }
        }

        public void MetaSpecializareDelete(long idMetaSpecializare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "MetaSpecializareDelete", idMetaSpecializare);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la MetaSpecializareDelete", ex);
            }
        }
    }
}
