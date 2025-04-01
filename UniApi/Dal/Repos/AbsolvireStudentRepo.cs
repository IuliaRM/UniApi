using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AbsolvireStudentRepo
    {
        private readonly string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public AbsolvireStudentInfo AbsolvireStudentGet(long idAbsolvireStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentGet", idAbsolvireStudent));
        }

        public List<AbsolvireStudentInfo> AbsolvireStudentListByStudent(long idStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentListByStudent", idStudent));
        }

        public List<AbsolvireStudentInfo> AbsolvireStudentList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentList"));
        }

        public long AbsolvireStudentAdd(AbsolvireStudentInfo studentInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentAdd", studentInfo);
            return Convert.ToInt64(id);
        }

        public void AbsolvireStudentUpdate(AbsolvireStudentInfo studentInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdate", studentInfo);
        }

        public void AbsolvireStudentDelete(long idAbsolvireStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDelete", idAbsolvireStudent);
        }

        public void AbsolvireStudentDeleteByStudent(long idStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDeleteByStudent", idStudent);
        }

        public void AbsolvireStudentCalculateAverageBySpecialization(long idAnUniv, long idFacultate, long idSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentCalculateAverageBySpecialization", idAnUniv, idFacultate, idSpecializare);
        }

        public decimal AbsolvireStudentCalculateAverage(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentCalculateAverage", idAnUniv, idFacultate, idFC, idTipCiclu, idStudent);
            return Convert.ToDecimal(result);
        }

        public void AbsolvireStudentImportDiplomaSeriesAndNumber(long idStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentImportDiplomaSeriesAndNumber", idStudent);
        }

        public void AbsolvireStudentUpdateRegistry(long idStudent, int anRegistru, string nrRegistru)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateRegistry", idStudent, anRegistru, nrRegistru);
        }

        public void AbsolvireStudentUpdateThesisDetails(long idStudent, string titluLucrare, string csvUsernameConducatori, decimal notaMedie)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateThesisDetails", idStudent, titluLucrare, csvUsernameConducatori, notaMedie);
        }
    }
}