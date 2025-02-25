using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;


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

        public AbsolvireStudentInfo AbsolvireStudentGetByStudent(long idStudent)
        {
            return DotNetNuke.Common.Utilities.CBO.FillObject<AbsolvireStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentGetByStudent", idStudent));
        }

        public List<AbsolvireStudentInfo> AbsolvireStudentList()
        {
            return DotNetNuke.Common.Utilities.CBO.FillCollection<AbsolvireStudentInfo>(
                SqlHelper.ExecuteReader(_connectionString, "AbsolvireStudentList"));
        }

        public long AbsolvireStudentAdd(AbsolvireStudentInfo studentInfo)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentAdd",
                studentInfo.ID_Student,
                studentInfo.Nume,
                studentInfo.Initiale,
                studentInfo.Prenume,
                studentInfo.NumeCasatorie,
                studentInfo.DataNastere,
                studentInfo.ID_LocalitateNastere,
                studentInfo.ID_JudetNastere,
                studentInfo.ID_TaraNastere,
                studentInfo.MedieFinalaAbsolvire,
                studentInfo.MedieFinalaAni,
                studentInfo.SerieDiploma,
                studentInfo.NrDiploma,
                studentInfo.NrOrdineIntern,
                studentInfo.ID_AbsolvireProgram);

            return Convert.ToInt64(id);
        }

        public void AbsolvireStudentUpdate(AbsolvireStudentInfo studentInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdate",
                studentInfo.ID_AbsolvireStudent,
                studentInfo.ID_Student,
                studentInfo.Nume,
                studentInfo.Initiale,
                studentInfo.Prenume,
                studentInfo.NumeCasatorie,
                studentInfo.DataNastere,
                studentInfo.ID_LocalitateNastere,
                studentInfo.ID_JudetNastere,
                studentInfo.ID_TaraNastere,
                studentInfo.MedieFinalaAbsolvire,
                studentInfo.MedieFinalaAni,
                studentInfo.SerieDiploma,
                studentInfo.NrDiploma,
                studentInfo.NrOrdineIntern,
                studentInfo.ID_AbsolvireProgram);
        }

        public void AbsolvireStudentDelete(long idAbsolvireStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDelete", idAbsolvireStudent);
        }

        public void AbsolvireStudentDeleteByStudent(long idStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentDeleteByStudent", idStudent);
        }

        public void AbsolvireStudentCalculMedieGeneralaSpecializare(long idAnUniv, long idFacultate, long idSpecializare)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentCalculMedieGeneralaSpecializare", idAnUniv, idFacultate, idSpecializare);
        }

        public decimal AbsolvireStudentCalculMedieGeneralaStudent(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent)
        {
            object result = SqlHelper.ExecuteScalar(_connectionString, "AbsolvireStudentCalculMedieGeneralaStudent", idAnUniv, idFacultate, idFC, idTipCiclu, idStudent);
            return Convert.ToDecimal(result);
        }

        public void AbsolvireStudentImportSerieNumarDiplomaByStudent(long idStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentImportSerieNumarDiplomaByStudent", idStudent);
        }

        public void AbsolvireStudentUpdateRegistruByStudent(long idStudent, int anRegistru, string nrRegistru)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateRegistruByStudent", idStudent, anRegistru, nrRegistru);
        }

        public void AbsolvireStudentUpdateDetaliiLucrareFinalizareStudiiByStudent(long idStudent, string titluLucrare, string csvUsernameConducatori, decimal notaMedie)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "AbsolvireStudentUpdateDetaliiLucrareFinalizareStudiiByStudent", idStudent, titluLucrare, csvUsernameConducatori, notaMedie);
        }
    }
}
