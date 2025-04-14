using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;


namespace UniApi.DAL.Repos
{

    public interface IValoareBursaStudentRepo
    {
        ValoareBursaStudentInfo ValoareBursaStudentGet(long idValoareBursa);
        ValoareBursaStudentInfo ValoareBursaStudentGetByBursaLuna(long idBursa, int numarLuna, long idAnUnivBursa);
        List<ValoareBursaStudentInfo> ValoareBursaStudentList();
        List<ValoareBursaStudentInfo> ValoareBursaStudentListByAnUnivLunaBanca(long idAnUnivBursa, int numarLuna, long idTipBanca, bool bursaPlatitaLuna);
        int ValoareBursaStudentAdd(ValoareBursaStudentInfo valoareBursaStudent);
        void ValoareBursaStudentUpdate(ValoareBursaStudentInfo valoareBursaStudent);
        void ValoareBursaStudentDelete(long idValoareBursa);
        decimal ValoareBursaStudentCalculBugetDisponibil(long idAnUnivBursa);
        void ValoareBursaStudentCopiaza(long idAnUnivBursaSursa, long idAnUnivBursaDestinatie, long userID);
        void ValoareBursaStudentPreluareLuna(long idAnUnivBursa, int numarLuna, long userID);
        void ValoareBursaStudentUpdateBugetRamas(long idAnUnivBursa, long idStudent, decimal valoareBursa, bool bursaPlatitaLuna, long userID);
        void ValoareBursaStudentUpdatePlatit(long idValoareBursa, bool bursaPlatitaLuna, long userID);
    }

    public class ValoareBursaStudentRepo : IValoareBursaStudentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ValoareBursaStudentInfo ValoareBursaStudentGet(long idValoareBursa)
        {
            return CBO.FillObject<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentGet", idValoareBursa));
        }

        public ValoareBursaStudentInfo ValoareBursaStudentGetByBursaLuna(long idBursa, int numarLuna, long idAnUnivBursa)
        {
            return CBO.FillObject<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentGetByBursaLuna", idBursa, numarLuna, idAnUnivBursa));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentList()
        {
            return CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentList"));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListByAnUnivLunaBanca(long idAnUnivBursa, int numarLuna, long idTipBanca, bool bursaPlatitaLuna)
        {
            return CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentListByAnUnivLunaBanca", idAnUnivBursa, numarLuna, idTipBanca, bursaPlatitaLuna));
        }

        public int ValoareBursaStudentAdd(ValoareBursaStudentInfo valoareBursaStudent)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "ValoareBursaStudentAdd",
                valoareBursaStudent.ID_Bursa,
                valoareBursaStudent.NumarLuna,
                valoareBursaStudent.ValoareBursa,
                valoareBursaStudent.ID_AnUnivBursa,
                valoareBursaStudent.BursaSpecialaStudent,
                valoareBursaStudent.BursaPlatitaLuna,
                valoareBursaStudent.UserID);
            return Convert.ToInt32(ret);
        }

        public void ValoareBursaStudentUpdate(ValoareBursaStudentInfo valoareBursaStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentUpdate",
                valoareBursaStudent.ID_ValoareBursa,
                valoareBursaStudent.ID_Bursa,
                valoareBursaStudent.NumarLuna,
                valoareBursaStudent.ValoareBursa,
                valoareBursaStudent.ID_AnUnivBursa,
                valoareBursaStudent.BursaSpecialaStudent,
                valoareBursaStudent.BursaPlatitaLuna,
                valoareBursaStudent.UserID);
        }

        public void ValoareBursaStudentDelete(long idValoareBursa)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentDelete", idValoareBursa);
        }

        public decimal ValoareBursaStudentCalculBugetDisponibil(long idAnUnivBursa)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "ValoareBursaStudentCalculBugetDisponibil", idAnUnivBursa);
            return Convert.ToDecimal(result);
        }

        public void ValoareBursaStudentCopiaza(long idAnUnivBursaSursa, long idAnUnivBursaDestinatie, long userID)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentCopiaza", idAnUnivBursaSursa, idAnUnivBursaDestinatie, userID);
        }

        public void ValoareBursaStudentPreluareLuna(long idAnUnivBursa, int numarLuna, long userID)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentPreluareLuna", idAnUnivBursa, numarLuna, userID);
        }

        public void ValoareBursaStudentUpdateBugetRamas(long idAnUnivBursa, long idStudent, decimal valoareBursa, bool bursaPlatitaLuna, long userID)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentUpdateBugetRamas", idAnUnivBursa, idStudent, valoareBursa, bursaPlatitaLuna, userID);
        }

        public void ValoareBursaStudentUpdatePlatit(long idValoareBursa, bool bursaPlatitaLuna, long userID)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentUpdatePlatit", idValoareBursa, bursaPlatitaLuna, userID);
        }
    }
}
