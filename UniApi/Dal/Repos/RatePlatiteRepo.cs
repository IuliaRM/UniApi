using System;
using System.Collections.Generic;
using System.Configuration;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class RatePlatiteRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<RatePlatiteInfo> RatePlatiteListByTaxeStudentGet(long ID_TaxaStudent, long ID_AnUniv)
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteListByTaxeStudent", ID_TaxaStudent, ID_AnUniv));
        }

        public List<RatePlatiteInfo> RatePlatiteListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteListByStudent", ID_Student, ID_AnUniv));
        }

        public RatePlatiteInfo RatePlatiteByRataTaxaGet(long ID_RataTaxa)
        {
            return CBO.FillObject<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteGetByRataTaxa", ID_RataTaxa));
        }

        public RatePlatiteInfo RatePlatiteGet(long ID_RatePlatite)
        {
            return CBO.FillObject<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "RatePlatiteGet", ID_RatePlatite));
        }

        public long RatePlatiteNextReceiptNumberUpdate(long ID_RatePlatite, long NumarChitanta, long UserID, DateTime DataPentruModificare, bool crescator)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "RatePlatiteUpdateUrmatoareleNumereDeChitanta", ID_RatePlatite, NumarChitanta, UserID, DataPentruModificare, crescator);
            return result != null ? Convert.ToInt64(result.ToString()) : -1;
        }

        public void RatePlatiteUpdate(DateTime Data_Plata, decimal SumaPlatita, string SerieChitanta, long NumarChitanta, long NumarFactura, long ID_ContContabil, long ID_Utilizator)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "RatePlatiteUpdate", Data_Plata, SumaPlatita, SerieChitanta, NumarChitanta, NumarFactura, ID_ContContabil, ID_Utilizator);
        }
    }
}
