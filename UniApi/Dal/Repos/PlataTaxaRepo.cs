using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class PlataTaxaRepo
    {
        private static readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString + ";Application Name=PlataTaxaRepo;";

        public List<StudentDatePersonaleInfo> StudentByCaractereGet(string caractereDinNume, int lungimeLista, long idAnUniv)
        {
            return CBO.FillCollection<StudentDatePersonaleInfo>(SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetStudentByCaractere", caractereDinNume, lungimeLista, idAnUniv));
        }

        public long NextReceiptNumberGet(int userId)
        {
            long nrChitanta = -1;
            object o = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_GetUltimulNumarChitanta", userId);
            if ((o != DBNull.Value) && (o != null) && long.TryParse(o.ToString(), out nrChitanta))
            {
                nrChitanta += 1;
            }
            return nrChitanta;
        }

        public long InstallmentInsert(long idTaxeStudent, double sumaPlatita, DateTime dataChitanta, string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata, string epid)
        {
            long idRataTaxa = Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata_DacaNuExistaEPID", idTaxeStudent, sumaPlatita, dataChitanta, serieChitanta, numarChitanta, contContabil, userId, idTipPlata, epid));
            return idRataTaxa;
        }

        public long InstallmentDirectInsert(long idStudent, long idFacultate, long idTaxa, long idIstoricTaxe, DateTime dataChitanta, string serieChitanta, string numarChitanta, double sumaPlatita, long contContabil, long idFc, long idTipFormaInv, string idAnUnivCurent, long idCamin, int userId, DateTime primaZiDinLunaStart, DateTime ultimaZiDinLunaStart, double sumaPenalizareCalculateInProgram, int idTipPlata)
        {
            long idRataTaxa = Convert.ToInt64(SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata_Direct_3", idStudent, idFacultate, idTaxa, idIstoricTaxe, dataChitanta, serieChitanta, numarChitanta, sumaPlatita, contContabil, idFc, idTipFormaInv, idAnUnivCurent, idCamin, userId, primaZiDinLunaStart, ultimaZiDinLunaStart, sumaPenalizareCalculateInProgram, idTipPlata));
            return idRataTaxa;
        }

        public IDataReader ReceiptDataGenerate(long idRataTaxa)
        {
            return SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetStudentByID_RataTaxa_2", idRataTaxa);
        }

        public void ReceiptCancel(long idRataTaxa, int userId)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PlataTaxa_AnuleazaChitanta", idRataTaxa, userId);
        }

        public void ReceiptDelete(long idRataTaxa, int userId)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "PlataTaxa_StergeChitanta", idRataTaxa, userId);
        }

        public List<RatePlatiteInfo> CollectionsByPeriodTypeGet(DateTime deLaData, DateTime pinaLaData, long idFacultate, long idTipTaxa, int idUtilizator, long idAnUniv, int idTipPlata)
        {
            return CBO.FillCollection<RatePlatiteInfo>(SqlHelper.ExecuteReader(_connectionString, "Caserie_IncasariPerioadaTipTaxa", deLaData, pinaLaData, idFacultate, idTipTaxa, idUtilizator, idAnUniv, idTipPlata));
        }
    }
}
