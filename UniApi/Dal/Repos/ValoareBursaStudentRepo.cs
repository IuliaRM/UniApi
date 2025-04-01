using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{
    public class ValoareBursaStudentRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public ValoareBursaStudentInfo ValoareBursaStudentGet(long idValoareBursa)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentGet", idValoareBursa));
        }

        public ValoareBursaStudentInfo ValoareBursaStudentByBursaLunaGet(long idBursa, int numarLuna, long idAnUnivBursa)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentGetByBursaLuna", idBursa, numarLuna, idAnUnivBursa));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListGet()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentList"));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListByLunaGet(int numarLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentListByLuna", numarLuna));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListByBursaGet(long idBursa)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentListByBursa", idBursa));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListByAnUnivLunaBancaGet(long idAnUnivBursa, int numarLuna, long idTipBanca, bool bursaPlatitaLuna)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentListByAnUnivLunaBanca", idAnUnivBursa, numarLuna, idTipBanca, bursaPlatitaLuna));
        }

        public List<ValoareBursaStudentInfo> ValoareBursaStudentListByAnUniversitarGet(long idAnUniv)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<ValoareBursaStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "ValoareBursaStudentListByAnUniversitar", idAnUniv));
        }

        public int ValoareBursaStudentAdd(ValoareBursaStudentInfo valoareBursaStudent)
        {
            object ret = SqlHelper.ExecuteScalar(_connectionString, "ValoareBursaStudentAdd", valoareBursaStudent.ID_Bursa, valoareBursaStudent.NumarLuna, valoareBursaStudent.ValoareBursa, valoareBursaStudent.ID_AnUnivBursa, valoareBursaStudent.BursaSpecialaStudent, valoareBursaStudent.BursaPlatitaLuna, valoareBursaStudent.UserID);
            return Convert.ToInt32(ret);
        }

        public void ValoareBursaStudentUpdate(ValoareBursaStudentInfo valoareBursaStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentUpdate", valoareBursaStudent.ID_ValoareBursa, valoareBursaStudent.ID_Bursa, valoareBursaStudent.NumarLuna, valoareBursaStudent.ValoareBursa, valoareBursaStudent.ID_AnUnivBursa, valoareBursaStudent.BursaSpecialaStudent, valoareBursaStudent.BursaPlatitaLuna, valoareBursaStudent.UserID);
        }

        public void ValoareBursaStudentDelete(ValoareBursaStudentInfo valoareBursaStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentDelete", valoareBursaStudent.ID_ValoareBursa);
        }

        public void BugetRamasUpdate(ValoareBursaStudentInfo obj)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "ValoareBursaStudentUpdateBugetRamas", obj.ID_AnUnivBursa, obj.ID_Student, obj.ValoareBursa, obj.BursaPlatitaLuna, obj.UserID);
        }
    }
}
