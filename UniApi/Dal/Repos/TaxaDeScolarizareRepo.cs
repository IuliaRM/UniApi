using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class TaxaDeScolarizareRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public List<RatePlatiteInfo> StudentiCuTaxaScolarizareAchitataMaiPutinDeProcentGet(long ID_AnUniv, long Id_FC, long Id_FCForma, long Id_AnStudiu, long Id_Domeniu, long Id_Specializare, long ID_Grupe, string FiltruTipIntrareIesire, int Procent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<RatePlatiteInfo>(
                SqlHelper.ExecuteReader(_connectionString, "RAP_StudentiCuTaxaScolarizareAchitataMaiPutinDeProcent",
                ID_AnUniv, Id_FC, Id_FCForma, Id_AnStudiu, Id_Domeniu, Id_Specializare, ID_Grupe, FiltruTipIntrareIesire, Procent));
        }

        public TipTaxaScolarizareStudentAnCurent TipTaxaScolarizareStudentAnCurentGet(long ID_Student, long ID_AnUniv)
        {
            TipTaxaScolarizareStudentAnCurent retEnum = TipTaxaScolarizareStudentAnCurent.Bugetat;
            object ret = SqlHelper.ExecuteScalar(_connectionString, "StudentGetTipTaxaScolarizareStudentAnUnivCurent", ID_Student, ID_AnUniv);

            string s = Convert.ToString(ret);
            if (!string.IsNullOrEmpty(s))
            {
                retEnum = (TipTaxaScolarizareStudentAnCurent)Enum.Parse(typeof(TipTaxaScolarizareStudentAnCurent), s);
            }
            return retEnum;
        }

        /*public long TaxaScolarizareAdd(TaxaScolarizareInfo taxaInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "TaxaScolarizareAdd",
                taxaInfo.ID_Student,
                taxaInfo.ID_AnUniv,
                taxaInfo.TipTaxa,
                taxaInfo.ValoareTaxa,
                taxaInfo.DataIncepere,
                taxaInfo.DataSfarsit);

            return Convert.ToInt64(id);
        } */

        public void TaxaScolarizareDelete(long idTaxa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "TaxaScolarizareDelete", idTaxa);
        }
    }
}
