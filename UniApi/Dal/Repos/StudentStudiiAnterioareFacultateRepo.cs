using System;
using System.Collections.Generic;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using UniApi;
using UniApi.Info;

namespace UniApi.DAL.Repos
{

    public interface IStudentStudiiAnterioareFacultateRepo
    {
        StudentStudiiAnterioareFacultateInfo StudentStudiiAnterioareFacultateGet(long id);
        List<StudentStudiiAnterioareFacultateInfo> StudentStudiiAnterioareFacultateListByStudent(long idStudent);
        long StudentStudiiAnterioareFacultateAdd(StudentStudiiAnterioareFacultateInfo info);
        void StudentStudiiAnterioareFacultateUpdate(StudentStudiiAnterioareFacultateInfo info);
        void StudentStudiiAnterioareFacultateDelete(long id);
        void StudentStudiiAnterioareFacultateDeleteByIdCandidatFacultate(long idCandidatFacultate);
    }

    public class StudentStudiiAnterioareFacultateRepo : IStudentStudiiAnterioareFacultateRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public StudentStudiiAnterioareFacultateInfo StudentStudiiAnterioareFacultateGet(long id)
        {
            return CBO.FillObject<StudentStudiiAnterioareFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentStudiiAnterioareFacultateGet", id));
        }

        public List<StudentStudiiAnterioareFacultateInfo> StudentStudiiAnterioareFacultateListByStudent(long idStudent)
        {
            return CBO.FillCollection<StudentStudiiAnterioareFacultateInfo>(
                SqlHelper.ExecuteReader(_connectionString, "StudentStudiiAnterioareFacultateListByStudent", idStudent));
        }

        public long StudentStudiiAnterioareFacultateAdd(StudentStudiiAnterioareFacultateInfo info)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "StudentStudiiAnterioareFacultateAdd",
                info.ID_Student, info.CNP, info.ID_CandidatFacultateAdmitere, info.ID_N_TaraFacultateAbsolvita,
                info.ID_N_JudetFacultateAbsolvita, info.ID_N_LocalitateFacultateAbsolvita, info.FormaInvFacultateAbsolvita,
                info.ID_AnUnivAbsolvire, info.ID_N_UniversitateAbsolvita, info.AnAbsolvireFacultate,
                info.DurataStudiiFacultateAbsolvita, info.ID_N_FacultateAbsolvita, info.ID_N_DomeniuStudiuFacultateAbsolvita,
                info.ID_N_FormaInvFacultateAbsolvita, info.ID_N_ProgramSpecializareFacultateAbsolvita,
                info.ID_N_TitluObtinutFacultateAbsolvita, info.ID_N_FormaFinantareFacultateAbsolvita,
                info.ID_N_TipDiplomaFacultateAbsolvita, info.DiplomaFacultate_Seria, info.DiplomaFacultate_Numar,
                info.ID_N_UniversitateEmitentaDiplomaFacultateAbsolvita, info.DiplomaFacultate_AnEmitere,
                info.ALTE_OBSERVATII, info.AnIncepereFacultate, info.LocalitateStudiiStrainatate,
                info.UniversitateStudiiStrainatate, info.SpecializareStudiiStrainatate, info.NrSemestreFinantate,
                info.AnFinalizareFacultate, info.MedieAbsolvire, info.ID_N_JudetUniversitateEmitenta,
                info.ID_N_LocalitateUniversitateEmitenta, info.ID_N_CicluStudii, info.Text_UniversitateAbsolvita,
                info.Text_DenumireFacultateAbsolvita, info.Text_DomeniuStudiuFacultateAbsolvita,
                info.Text_FormaInvFacultateAbsolvita, info.Text_ProgramSpecializareFacultateAbsolvita,
                info.Text_TitluObtinutFacultateAbsolvita, info.Text_UniversitateEmitentaDiplomaFacultateAbsolvita,
                info.Text_CicluStudii, info.NrCrediteFacultateAbsolvita);
            return Convert.ToInt64(id);
        }

        public void StudentStudiiAnterioareFacultateUpdate(StudentStudiiAnterioareFacultateInfo info)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentStudiiAnterioareFacultateUpdate",
                info.ID_StudentStudiiAnterioareFacultate, info.ID_Student, info.CNP, info.ID_CandidatFacultateAdmitere,
                info.ID_N_TaraFacultateAbsolvita, info.ID_N_JudetFacultateAbsolvita, info.ID_N_LocalitateFacultateAbsolvita,
                info.FormaInvFacultateAbsolvita, info.ID_AnUnivAbsolvire, info.ID_N_UniversitateAbsolvita,
                info.AnAbsolvireFacultate, info.DurataStudiiFacultateAbsolvita, info.ID_N_FacultateAbsolvita,
                info.ID_N_DomeniuStudiuFacultateAbsolvita, info.ID_N_FormaInvFacultateAbsolvita,
                info.ID_N_ProgramSpecializareFacultateAbsolvita, info.ID_N_TitluObtinutFacultateAbsolvita,
                info.ID_N_FormaFinantareFacultateAbsolvita, info.ID_N_TipDiplomaFacultateAbsolvita,
                info.DiplomaFacultate_Seria, info.DiplomaFacultate_Numar, info.ID_N_UniversitateEmitentaDiplomaFacultateAbsolvita,
                info.DiplomaFacultate_AnEmitere, info.ALTE_OBSERVATII, info.AnIncepereFacultate,
                info.LocalitateStudiiStrainatate, info.UniversitateStudiiStrainatate, info.SpecializareStudiiStrainatate,
                info.NrSemestreFinantate, info.AnFinalizareFacultate, info.MedieAbsolvire,
                info.ID_N_JudetUniversitateEmitenta, info.ID_N_LocalitateUniversitateEmitenta,
                info.ID_N_CicluStudii, info.Text_UniversitateAbsolvita, info.Text_DenumireFacultateAbsolvita,
                info.Text_DomeniuStudiuFacultateAbsolvita, info.Text_FormaInvFacultateAbsolvita,
                info.Text_ProgramSpecializareFacultateAbsolvita, info.Text_TitluObtinutFacultateAbsolvita,
                info.Text_UniversitateEmitentaDiplomaFacultateAbsolvita, info.Text_CicluStudii, info.NrCrediteFacultateAbsolvita);
        }

        public void StudentStudiiAnterioareFacultateDelete(long id)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentStudiiAnterioareFacultateDelete", id);
        }

        public void StudentStudiiAnterioareFacultateDeleteByIdCandidatFacultate(long idCandidatFacultate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentStudiiAnterioareFacultateDeleteByIdCandidatFacultate", idCandidatFacultate);
        }
    }
}
