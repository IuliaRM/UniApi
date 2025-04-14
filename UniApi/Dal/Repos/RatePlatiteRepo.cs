using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IRatePlatiteRepo
    {
        RatePlatiteInfo RatePlatiteGet(long idRatePlatite);
        RatePlatiteInfo RatePlatiteGetByContContabil(long idContContabil);
        RatePlatiteInfo RatePlatiteGetByRataTaxa(long idRataTaxa);
        List<RatePlatiteInfo> RatePlatiteList();
        List<RatePlatiteInfo> RatePlatiteListByStudent(long idStudent, long idAnUniv);
        List<RatePlatiteInfo> RatePlatiteListByTaxeStudent(long idTaxaStudent, long idAnUniv);
        long RatePlatiteAdd(RatePlatiteInfo ratePlatite);
        void RatePlatiteDelete(long idRatePlatite);
        void RatePlatiteUpdate(RatePlatiteInfo ratePlatite);
        long RatePlatiteUpdateUrmatoareleNumereDeChitanta(long idRatePlatite, long numarChitanta, long userId, DateTime dataPentruModificare, bool crescator);
    }

    public class RatePlatiteRepo : IRatePlatiteRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public RatePlatiteInfo RatePlatiteGet(long idRatePlatite)
        {
            return CBO.FillObject<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteGet", idRatePlatite));
        }

        public RatePlatiteInfo RatePlatiteGetByContContabil(long idContContabil)
        {
            return CBO.FillObject<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteGetByContContabil", idContContabil));
        }

        public RatePlatiteInfo RatePlatiteGetByRataTaxa(long idRataTaxa)
        {
            return CBO.FillObject<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteGetByRataTaxa", idRataTaxa));
        }

        public List<RatePlatiteInfo> RatePlatiteList()
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteList"));
        }

        public List<RatePlatiteInfo> RatePlatiteListByStudent(long idStudent, long idAnUniv)
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteListByStudent", idStudent, idAnUniv));
        }

        public List<RatePlatiteInfo> RatePlatiteListByTaxeStudent(long idTaxaStudent, long idAnUniv)
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteListByTaxeStudent", idTaxaStudent, idAnUniv));
        }

        public long RatePlatiteAdd(RatePlatiteInfo ratePlatite)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "RatePlatiteAdd",
                ratePlatite.ID_RataTaxa,
                ratePlatite.Data_Plata,
                ratePlatite.SumaPlatita,
                ratePlatite.SerieChitanta,
                ratePlatite.NumarChitanta,
               // ratePlatite.NumarFactura,
                ratePlatite.ID_ContContabil,
                ratePlatite.ID_Utilizator,
               // ratePlatite.DataCreare,
               // ratePlatite.UserIDCreare,
               // ratePlatite.DataModificare,
               // ratePlatite.UserIDModificare,
                ratePlatite.PortalID);
            return result != null ? Convert.ToInt64(result) : -1;
        }

        public void RatePlatiteDelete(long idRatePlatite)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "RatePlatiteDelete", idRatePlatite);
        }

        public void RatePlatiteUpdate(RatePlatiteInfo ratePlatite)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "RatePlatiteUpdate",
                ratePlatite.ID_RatePlatite,
                ratePlatite.ID_RataTaxa,
                ratePlatite.Data_Plata,
                ratePlatite.SumaPlatita,
                ratePlatite.SerieChitanta,
                ratePlatite.NumarChitanta,
               // ratePlatite.NumarFactura,
                ratePlatite.ID_ContContabil,
                ratePlatite.ID_Utilizator,
              //  ratePlatite.DataCreare,
              //  ratePlatite.UserIDCreare,
              //  ratePlatite.DataModificare,
              //  ratePlatite.UserIDModificare,
                ratePlatite.PortalID);
        }

        public long RatePlatiteUpdateUrmatoareleNumereDeChitanta(long idRatePlatite, long numarChitanta, long userId, DateTime dataPentruModificare, bool crescator)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "RatePlatiteUpdateUrmatoareleNumereDeChitanta", idRatePlatite, numarChitanta, userId, dataPentruModificare, crescator);
            return result != null ? Convert.ToInt64(result) : -1;
        }
    }
}
