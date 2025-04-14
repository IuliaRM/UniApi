using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public interface IAbsolvireStudentRepo
    {
        AbsolvireStudentInfo AbsolvireStudentGet(long idAbsolvireStudent);
        List<AbsolvireStudentInfo> AbsolvireStudentGetByStudent(long idStudent);
        List<AbsolvireStudentInfo> AbsolvireStudentList();
        long AbsolvireStudentAdd(AbsolvireStudentInfo studentInfo);
        void AbsolvireStudentUpdate(AbsolvireStudentInfo studentInfo);
        void AbsolvireStudentDelete(long idAbsolvireStudent);
        void AbsolvireStudentDeleteByStudent(long idStudent);
        void AbsolvireStudentCalcuMedieGeneralaSpecializare(long idAnUniv, long idFacultate, long idSpecializare);
        decimal AbsolvireStudentCalculMedieGeneralaStudent(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent);
        void AbsolvireStudentImportSerieNumarDiplomaByStudent(long idStudent);
        void AbsolvireStudentUpdateRegistry(long idStudent, int anRegistru, string nrRegistru);
        void AbsolvireStudentUpdateThesisDetails(long idStudent, string titluLucrare, string csvUsernameConducatori, decimal notaMedie);
        void AbsolvireStudentUpdateDetaliiLucrareFinalizareStructura(long idStudent, string titluLucrare, string structuraLucrare);
        string AbsolvireStudentRegistruByStudent(long idStudent);

    }

    public class AbsolvireStudentRepo : IAbsolvireStudentRepo
    {
        private readonly string _connectionString;

        public AbsolvireStudentRepo()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"]?.ConnectionString;

            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Connection string 'AGSISSqlServer' not found.");
        }

        public AbsolvireStudentInfo AbsolvireStudentGet(long idAbsolvireStudent)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentGet", idAbsolvireStudent))
                {
                    return CBO.FillObject<AbsolvireStudentInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudent.", ex);
            }
        }

        public List<AbsolvireStudentInfo> AbsolvireStudentGetByStudent(long idStudent)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentGetByStudent", idStudent))
                {
                    return CBO.FillCollection<AbsolvireStudentInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudent list by student.", ex);
            }
        }

        public List<AbsolvireStudentInfo> AbsolvireStudentList()
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentList"))
                {
                    return CBO.FillCollection<AbsolvireStudentInfo>(reader);
                }
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving AbsolvireStudent list.", ex);
            }
        }

        public long AbsolvireStudentAdd(AbsolvireStudentInfo studentInfo)
        {
            if (studentInfo == null)
                throw new ArgumentNullException(nameof(studentInfo));

            try
            {
                var id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentAdd", studentInfo);
                return Convert.ToInt64(id);
            }
            catch (Exception ex)
            {
                throw new DataException("Error adding AbsolvireStudent.", ex);
            }
        }

        public void AbsolvireStudentUpdate(AbsolvireStudentInfo studentInfo)
        {
            if (studentInfo == null)
                throw new ArgumentNullException(nameof(studentInfo));

            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdate", studentInfo);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating AbsolvireStudent.", ex);
            }
        }

        public void AbsolvireStudentDelete(long idAbsolvireStudent)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDelete", idAbsolvireStudent);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AbsolvireStudent.", ex);
            }
        }

        public void AbsolvireStudentDeleteByStudent(long idStudent)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDeleteByStudent", idStudent);
            }
            catch (Exception ex)
            {
                throw new DataException("Error deleting AbsolvireStudent by student.", ex);
            }
        }

        public void AbsolvireStudentCalcuMedieGeneralaSpecializare(long idAnUniv, long idFacultate, long idSpecializare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentCalcuMedieGeneralaSpecializare", idAnUniv, idFacultate, idSpecializare);
            }
            catch (Exception ex)
            {
                throw new DataException("Error calculating average by specialization.", ex);
            }
        }

        public decimal AbsolvireStudentCalculMedieGeneralaStudent(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent)
        {
            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentCalculMedieGeneralaStudent",
                    idAnUniv, idFacultate, idFC, idTipCiclu, idStudent);
                return Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                throw new DataException("Error calculating average for student.", ex);
            }
        }

        public void AbsolvireStudentImportSerieNumarDiplomaByStudent(long idStudent)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentImportSerieNumarDiplomaByStudent", idStudent);
            }
            catch (Exception ex)
            {
                throw new DataException("Error importing diploma series and number.", ex);
            }
        }

        public void AbsolvireStudentUpdateRegistry(long idStudent, int anRegistru, string nrRegistru)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateRegistry", idStudent, anRegistru, nrRegistru);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating registry number.", ex);
            }
        }

        public void AbsolvireStudentUpdateThesisDetails(long idStudent, string titluLucrare, string csvUsernameConducatori, decimal notaMedie)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateThesisDetails",
                    idStudent, titluLucrare, csvUsernameConducatori, notaMedie);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating thesis details.", ex);
            }
        }
        public void AbsolvireStudentUpdateDetaliiLucrareFinalizareStructura(long idStudent, string titluLucrare, string structuraLucrare)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateDetaliiLucrareFinalizareStructura", idStudent, titluLucrare, structuraLucrare);
            }
            catch (Exception ex)
            {
                throw new DataException("Error updating thesis details with structure.", ex);
            }
        }

        public string AbsolvireStudentRegistruByStudent(long idStudent)
        {
            try
            {
                var result = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentRegistruByStudent", idStudent);
                return result?.ToString();
            }
            catch (Exception ex)
            {
                throw new DataException("Error retrieving registru by student.", ex);
            }
        }

    }
}
