using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;
//using UniApi.Components;

namespace UniApi.DAL.Repos
{

    public interface ITaxeRepo
    {
        long TaxeAdd(TaxeInfo tax);
        void TaxeDelete(long idTaxa);
        TaxeInfo TaxeGet(long idTaxa);
        List<TaxeInfo> TaxeGetByAnUniversitar(long idAnUniv);
        List<TaxeInfo> TaxeGetByTipCicluInvatamant(long idTipCiclu);
        List<TaxeInfo> TaxeGetByTipFormaInv(long idTipFormaInv);
        List<TaxeInfo> TaxeGetByTipTaxa(long idTip);
        List<TaxeInfo> TaxeList();
        void TaxeUpdate(TaxeInfo tax);
    }

    public class TaxeRepo : ITaxeRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long TaxeAdd(TaxeInfo tax)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TaxeAdd",
                tax.Tip,
                tax.ID_Facultate,
                tax.ID_TipCiclu,
                tax.ID_TipFormaInv,
                tax.ID_AnUniv,
                tax.ID_Utilizator,
                DateTime.Now, // DataModificare
                tax.Status,
                tax.PortalId,
                tax.ID_Camin);
            return Convert.ToInt64(id);
        }

        public void TaxeDelete(long idTaxa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TaxeDelete", idTaxa);
        }

        public TaxeInfo TaxeGet(long idTaxa)
        {
            return CBO.FillObject<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeGet", idTaxa));
        }

        public List<TaxeInfo> TaxeGetByAnUniversitar(long idAnUniv)
        {
            return CBO.FillCollection<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeGetByAnUniversitar", idAnUniv));
        }

        public List<TaxeInfo> TaxeGetByTipCicluInvatamant(long idTipCiclu)
        {
            return CBO.FillCollection<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeGetByTipCicluInvatamant", idTipCiclu));
        }

        public List<TaxeInfo> TaxeGetByTipFormaInv(long idTipFormaInv)
        {
            return CBO.FillCollection<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeGetByTipFormaInv", idTipFormaInv));
        }

        public List<TaxeInfo> TaxeGetByTipTaxa(long idTip)
        {
            return CBO.FillCollection<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeGetByTipTaxa", idTip));
        }

        public List<TaxeInfo> TaxeList()
        {
            return CBO.FillCollection<TaxeInfo>(
                SqlHelper.ExecuteReader(_connectionString, "TaxeList"));
        }

        public void TaxeUpdate(TaxeInfo tax)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TaxeUpdate",
                tax.ID,
                tax.ID_Facultate,
                tax.Tip,
                tax.ID_TipCiclu,
                tax.ID_TipFormaInv,
                tax.ID_AnUniv,
                tax.ID_Utilizator,
                DateTime.Now, // DataModificare
                tax.Status,
                tax.PortalId,
                tax.ID_Camin);
        }
    }
}
