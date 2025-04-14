using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;
using UniTBv.AGSIS;


namespace UniApi.DAL.Repos
{

    public interface IPlataTaxaRepo
    {
        // Student operations
        List<StudentDatePersonaleInfo> PlataTaxa_GetStudentByCaractere(string caractereDinNume, int lungimeLista, long idAnUniv);
        StudentDatePersonaleInfo PlataTaxa_StudentGetByID(long idStudent);

        // Receipt operations
        long PlataTaxa_GetUltimulNumarChitanta(int userId);
        IDataReader PlataTaxa_GetStudentByID_RataTaxa(long idRataTaxa);
        List<RatePlatiteInfo> PlataTaxa_GhetChitanteDinData(DateTime dataChitanta);
        void PlataTaxa_AnuleazaChitanta(long idRataTaxa, int userId);
        void PlataTaxa_StergeChitanta(long idRataTaxa, int userId);

        // Installment operations
        long PlataTaxa_InsertRata(long idTaxeStudent, double sumaPlatita, DateTime dataChitanta, string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata);
        long PlataTaxa_InsertRata_DacaNuExistaEPID(long idTaxeStudent, double sumaPlatita, DateTime dataChitanta, string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata, string epid);
        long PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID(long idStudent, double sumaPlatita, DateTime dataChitanta, string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata, string epid);
        long PlataTaxa_InsertRata_Direct(long idStudent, long idFacultate, long idTaxa, long idIstoricTaxe, DateTime dataChitanta, string serieChitanta, string numarChitanta, double sumaPlatita, long contContabil, long idFc, long idTipFormaInv, string idAnUnivCurent, long idCamin, int userId, DateTime primaZiDinLunaStart, DateTime ultimaZiDinLunaStart, double sumaPenalizareCalculateInProgram, int idTipPlata);

        // Account and tax operations
        ContContabilInfo PlataTaxa_GetContContabil(long idContContabil);
        TaxeInfo PlataTaxa_GetTipTaxa(long idTipTaxa);

        
    }

    public class PlataTaxaRepo : IPlataTaxaRepo
    {
        private readonly string _connectionString;

        public PlataTaxaRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString + ";Application Name=PlataTaxaRepo;";

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        
        public List<StudentDatePersonaleInfo> PlataTaxa_GetStudentByCaractere(string caractereDinNume, int lungimeLista, long idAnUniv)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetStudentByCaractere",
                    caractereDinNume, lungimeLista, idAnUniv))
                {
                    return CBO.FillCollection<StudentDatePersonaleInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GetStudentByCaractere", ex);
            }
        }

        public StudentDatePersonaleInfo PlataTaxa_StudentGetByID(long idStudent)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_StudentGetByID", idStudent))
                {
                    return CBO.FillObject<StudentDatePersonaleInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_StudentGetByID", ex);
            }
        }
        

       
        public long PlataTaxa_GetUltimulNumarChitanta(int userId)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_GetUltimulNumarChitanta", userId);
                return (result != null && result != DBNull.Value) ? Convert.ToInt64(result) + 1 : -1;
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GetUltimulNumarChitanta", ex);
            }
        }

        public IDataReader PlataTaxa_GetStudentByID_RataTaxa(long idRataTaxa)
        {
            try
            {
                return SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetStudentByID_RataTaxa", idRataTaxa);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GetStudentByID_RataTaxa", ex);
            }
        }

        public List<RatePlatiteInfo> PlataTaxa_GhetChitanteDinData(DateTime dataChitanta)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GhetChitanteDinData", dataChitanta))
                {
                    return CBO.FillCollection<RatePlatiteInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GhetChitanteDinData", ex);
            }
        }

        public void PlataTaxa_AnuleazaChitanta(long idRataTaxa, int userId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PlataTaxa_AnuleazaChitanta", idRataTaxa, userId);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_AnuleazaChitanta", ex);
            }
        }

        public void PlataTaxa_StergeChitanta(long idRataTaxa, int userId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "PlataTaxa_StergeChitanta", idRataTaxa, userId);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_StergeChitanta", ex);
            }
        }
        

        
        public long PlataTaxa_InsertRata(long idTaxeStudent, double sumaPlatita, DateTime dataChitanta,
            string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata",
                    idTaxeStudent, sumaPlatita, dataChitanta, serieChitanta, numarChitanta,
                    contContabil, userId, idTipPlata);
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_InsertRata", ex);
            }
        }

        public long PlataTaxa_InsertRata_DacaNuExistaEPID(long idTaxeStudent, double sumaPlatita, DateTime dataChitanta,
            string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata, string epid)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata_DacaNuExistaEPID",
                    idTaxeStudent, sumaPlatita, dataChitanta, serieChitanta, numarChitanta,
                    contContabil, userId, idTipPlata, epid);
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_InsertRata_DacaNuExistaEPID", ex);
            }
        }

        public long PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID(long idStudent, double sumaPlatita, DateTime dataChitanta,
            string serieChitanta, string numarChitanta, long contContabil, int userId, int idTipPlata, string epid)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID",
                    idStudent, sumaPlatita, dataChitanta, serieChitanta, numarChitanta,
                    contContabil, userId, idTipPlata, epid);
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID", ex);
            }
        }

        public long PlataTaxa_InsertRata_Direct(long idStudent, long idFacultate, long idTaxa, long idIstoricTaxe, DateTime dataChitanta,
            string serieChitanta, string numarChitanta, double sumaPlatita, long contContabil, long idFc, long idTipFormaInv,
            string idAnUnivCurent, long idCamin, int userId, DateTime primaZiDinLunaStart, DateTime ultimaZiDinLunaStart,
            double sumaPenalizareCalculateInProgram, int idTipPlata)
        {
            try
            {
                object result = SqlHelper.ExecuteScalar(_connectionString, "PlataTaxa_InsertRata_Direct",
                    idStudent, idFacultate, idTaxa, idIstoricTaxe, dataChitanta, serieChitanta, numarChitanta, sumaPlatita,
                    contContabil, idFc, idTipFormaInv, idAnUnivCurent, idCamin, userId, primaZiDinLunaStart,
                    ultimaZiDinLunaStart, sumaPenalizareCalculateInProgram, idTipPlata);
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_InsertRata_Direct", ex);
            }
        }
        

        
        public ContContabilInfo PlataTaxa_GetContContabil(long idContContabil)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetContContabil", idContContabil))
                {
                    return CBO.FillObject<ContContabilInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GetContContabil", ex);
            }
        }

        public TaxeInfo PlataTaxa_GetTipTaxa(long idTipTaxa)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "PlataTaxa_GetTipTaxa", idTipTaxa))
                {
                    return CBO.FillObject<TaxeInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in PlataTaxa_GetTipTaxa", ex);
            }
        }
        

        
        public List<RatePlatiteInfo> Caserie_IncasariPerioadaTipTaxa(DateTime deLaData, DateTime pinaLaData,
            long idFacultate, long idTipTaxa, int idUtilizator, long idAnUniv, int idTipPlata)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "Caserie_IncasariPerioadaTipTaxa",
                    deLaData, pinaLaData, idFacultate, idTipTaxa, idUtilizator, idAnUniv, idTipPlata))
                {
                    return CBO.FillCollection<RatePlatiteInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error in Caserie_IncasariPerioadaTipTaxa", ex);
            }
        }
      
    }

}