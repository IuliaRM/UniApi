using System;
using System.Collections.Generic;
using Microsoft.ApplicationBlocks.Data;
using DotNetNuke.Common.Utilities;
using System.Configuration;
using UniApi;
using UniApi.Info;
using UniApi.DAL.Repos;

namespace UniApi.DAL.Repos
{

    public interface IStudentRepo
    {
        long StudentAdd(StudentInfo student);
        void StudentDelete(long idStudent);
        void StudentDeleteByIdCandidatFacultate(long idCandidatFacultate);
        bool StudentExistaCuIdCandidatFacultateAdmitere(long idCandidatFacultate);
        StudentInfo StudentGet(long idStudent);
        StudentInfo StudentGetbyAnUniv(long idAnUniv);
        StudentInfo StudentGetByEmailAnUniv(string email, long idAnUniv);
        StudentInfo StudentGetByFacultateCicluFormaDomeniuSpecializareNumeCNP(long idFacultate, long idCiclu, long idFormaInvatamant, long idDomeniu, long idSpecializare, string nume, string cnp);
        StudentInfo StudentGetByIdCandidatFacultate(long idCandidatFacultate);
        StudentInfo StudentGetByTaxaStudent(bool taxaStudent);
        StudentInfo StudentGetByTipActIdentitate(string tipActIdentitate);
        StudentInfo StudentGetByTipBanca(string tipBanca);
        StudentInfo StudentGetByTipCetatenie(string tipCetatenie);
        StudentInfo StudentGetByTipSituatieMilitara(string tipSituatieMilitara);
        StudentInfo StudentGetByTipStareCivila(string tipStareCivila);
        StudentInfo StudentGetByUserID(long userId);
        StudentInfo StudentGetByUserIDAnUnivID(long userId, long idAnUniv);
        StudentInfo StudentGetByUsername(string username);
        StudentInfo StudentGetByUsernameAnUniv(string username, long idAnUniv);
        StudentInfo StudentGetInformatiiCompleteSecretarSef(long idStudent);
        StudentInfo StudentGetOrAddByIdStudentSuperior(long idStudentSuperior);
        StudentInfo StudentGetTipTaxaScolarizareStudentAnUnivCurent(long idStudent);
        List<StudentInfo> StudentList();
        List<StudentInfo> StudentListByAnUniv(long idAnUniv);
        List<StudentInfo> StudentListByAnUnivLaMaiMulteFacultati(List<long> idFacultati, long idAnUniv);
        List<StudentInfo> StudentListByAnUnivMaiMareDeAn(long idAnUniv);
        List<StudentInfo> StudentListByCaractere(string caractere);
        List<StudentInfo> StudentListByFCFSAnUniv(long idFacultate, long idCiclu, long idFormaInvatamant, long idSpecializare, long idAnUniv);
        List<StudentInfo> StudentListByGrupa(long idGrupa);
        List<StudentInfo> StudentListByGrupaAsociatiPachetAbsolvire(long idGrupa);
        List<StudentInfo> StudentListByGrupaNeasociatiPachetAbsolvire(long idGrupa);
        List<StudentInfo> StudentListByGrupaSpecializare(long idGrupa, long idSpecializare);
        List<StudentInfo> StudentListByID_Student(long idStudent);
        List<StudentInfo> StudentListByMetaSpecializareAsociatiPachetAbsolvire(long idMetaSpecializare);
        List<StudentInfo> StudentListByMetaSpecializareSesiuneAsociatiPachetAbsolvire(long idMetaSpecializare, long idSesiune);
        List<StudentInfo> StudentListBySpecializareAsociatiPachetAbsolvire(long idSpecializare);
        List<StudentInfo> StudentListBySpecializareSesiuneAsociatiPachetAbsolvire(long idSpecializare, long idSesiune);
        List<StudentInfo> StudentListByTaxa(bool taxa);
        List<StudentInfo> StudentListByUsernameAnUniv(string username, long idAnUniv);
        List<string> StudentListDenumiriByAnUniv(long idAnUniv);
        void StudentUpdate(StudentInfo student);
        //void StudentUpdateAtributDinamic(StudentAtributDinamicInfo atributDinamic);
        //void StudentUpdateBancaSiContBanca(StudentBancaInfo bancaInfo);
        void StudentUpdateInfoPentruBursa(BursaInfo bursaInfo);
        //void StudentUpdateInfoUser(StudentInfoUser userInfo);
        void StudentUpdatePasswordByUsername(string username, string password);
    }

    public class StudentRepo : IStudentRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["AGSISSqlServer"].ConnectionString;

        public long StudentAdd(StudentInfo student)
        {
            object id = SqlHelper.ExecuteScalar(_connectionString, "StudentAdd",
            student.Nume, student.Initiale, student.Prenume, student.ID_TipActIdentitate, student.CNP, student.Numar_serie,
            student.DataNastere, student.PrenumeTata, student.PrenumeMama, student.NumeCasatorie, student.Telefon, student.Email,
            student.Web, student.Adresa, student.ID_TipTara, student.ID_Nationalitate, student.ID_TipCetatenie,
            student.ID_ADouaCetatenie, student.ID_TipStareCivila, student.ID_TipSituatieMilitara, student.Sex, student.ID_TipBanca,
            student.ContBanca, student.VenitPerFamilie, student.AlteVenituri, student.NumeLiceuAbsolvit, student.NotaBacalaureat,
            student.Judet, student.Localitate, student.JudetNastere, student.LocalitateNastere, student.OrfanDeUnParinte,
            student.OrfanAmbiiParinti, student.ID_Utilizator, student.DataModificare, student.Status, student.PortalID, student.ID_CandidatFacultateAdmitere);

            return Convert.ToInt64(id);
        }

        public void StudentDelete(long idStudent)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentDelete", idStudent);
        }

        public void StudentDeleteByIdCandidatFacultate(long idCandidatFacultate)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentDeleteByIdCandidatFacultate", idCandidatFacultate);
        }

        public bool StudentExistaCuIdCandidatFacultateAdmitere(long idCandidatFacultate)
        {
            return Convert.ToBoolean(SqlHelper.ExecuteScalar(_connectionString, "StudentExistaCuIdCandidatFacultateAdmitere", idCandidatFacultate));
        }

        public StudentInfo StudentGet(long idStudent)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGet", idStudent));
        }

        public StudentInfo StudentGetbyAnUniv(long idAnUniv)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetbyAnUniv", idAnUniv));
        }

        public StudentInfo StudentGetByEmailAnUniv(string email, long idAnUniv)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByEmailAnUniv", email, idAnUniv));
        }

        public StudentInfo StudentGetByFacultateCicluFormaDomeniuSpecializareNumeCNP(long idFacultate, long idCiclu, long idFormaInvatamant, long idDomeniu, long idSpecializare, string nume, string cnp)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByFacultateCicluFormaDomeniuSpecializareNumeCNP", idFacultate, idCiclu, idFormaInvatamant, idDomeniu, idSpecializare, nume, cnp));
        }

        public StudentInfo StudentGetByIdCandidatFacultate(long idCandidatFacultate)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByIdCandidatFacultate", idCandidatFacultate));
        }

        public StudentInfo StudentGetByTaxaStudent(bool taxaStudent)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTaxaStudent", taxaStudent));
        }

        public StudentInfo StudentGetByTipActIdentitate(string tipActIdentitate)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTipActIdentitate", tipActIdentitate));
        }

        public StudentInfo StudentGetByTipBanca(string tipBanca)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTipBanca", tipBanca));
        }

        public StudentInfo StudentGetByTipCetatenie(string tipCetatenie)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTipCetatenie", tipCetatenie));
        }

        public StudentInfo StudentGetByTipSituatieMilitara(string tipSituatieMilitara)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTipSituatieMilitara", tipSituatieMilitara));
        }

        public StudentInfo StudentGetByTipStareCivila(string tipStareCivila)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByTipStareCivila", tipStareCivila));
        }

        public StudentInfo StudentGetByUserID(long userId)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByUserID", userId));
        }

        public StudentInfo StudentGetByUserIDAnUnivID(long userId, long idAnUniv)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByUserIDAnUnivID", userId, idAnUniv));
        }

        public StudentInfo StudentGetByUsername(string username)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByUsername", username));
        }

        public StudentInfo StudentGetByUsernameAnUniv(string username, long idAnUniv)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetByUsernameAnUniv", username, idAnUniv));
        }

        public StudentInfo StudentGetInformatiiCompleteSecretarSef(long idStudent)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetInformatiiCompleteSecretarSef", idStudent));
        }

        public StudentInfo StudentGetOrAddByIdStudentSuperior(long idStudentSuperior)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetOrAddByIdStudentSuperior", idStudentSuperior));
        }

        public StudentInfo StudentGetTipTaxaScolarizareStudentAnUnivCurent(long idStudent)
        {
            return CBO.FillObject<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentGetTipTaxaScolarizareStudentAnUnivCurent", idStudent));
        }

        public List<StudentInfo> StudentList()
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentList"));
        }

        public List<StudentInfo> StudentListByAnUniv(long idAnUniv)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByAnUniv", idAnUniv));
        }

        public List<StudentInfo> StudentListByAnUnivLaMaiMulteFacultati(List<long> idFacultati, long idAnUniv)
        {
            // Note: This needs to be adjusted based on how the stored procedure handles a list of IDs.
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByAnUnivLaMaiMulteFacultati", string.Join(",", idFacultati), idAnUniv));
        }

        public List<StudentInfo> StudentListByAnUnivMaiMareDeAn(long idAnUniv)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByAnUnivMaiMareDeAn", idAnUniv));
        }

        public List<StudentInfo> StudentListByCaractere(string caractere)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByCaractere", caractere));
        }

        public List<StudentInfo> StudentListByFCFSAnUniv(long idFacultate, long idCiclu, long idFormaInvatamant, long idSpecializare, long idAnUniv)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByFCFSAnUniv", idFacultate, idCiclu, idFormaInvatamant, idSpecializare, idAnUniv));
        }

        public List<StudentInfo> StudentListByGrupa(long idGrupa)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByGrupa", idGrupa));
        }

        public List<StudentInfo> StudentListByGrupaAsociatiPachetAbsolvire(long idGrupa)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByGrupaAsociatiPachetAbsolvire", idGrupa));
        }

        public List<StudentInfo> StudentListByGrupaNeasociatiPachetAbsolvire(long idGrupa)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByGrupaNeasociatiPachetAbsolvire", idGrupa));
        }

        public List<StudentInfo> StudentListByGrupaSpecializare(long idGrupa, long idSpecializare)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByGrupaSpecializare", idGrupa, idSpecializare));
        }

        public List<StudentInfo> StudentListByID_Student(long idStudent)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByID_Student", idStudent));
        }

        public List<StudentInfo> StudentListByMetaSpecializareAsociatiPachetAbsolvire(long idMetaSpecializare)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByMetaSpecializareAsociatiPachetAbsolvire", idMetaSpecializare));
        }

        public List<StudentInfo> StudentListByMetaSpecializareSesiuneAsociatiPachetAbsolvire(long idMetaSpecializare, long idSesiune)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByMetaSpecializareSesiuneAsociatiPachetAbsolvire", idMetaSpecializare, idSesiune));
        }

        public List<StudentInfo> StudentListBySpecializareAsociatiPachetAbsolvire(long idSpecializare)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListBySpecializareAsociatiPachetAbsolvire", idSpecializare));
        }

        public List<StudentInfo> StudentListBySpecializareSesiuneAsociatiPachetAbsolvire(long idSpecializare, long idSesiune)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListBySpecializareSesiuneAsociatiPachetAbsolvire", idSpecializare, idSesiune));
        }

        public List<StudentInfo> StudentListByTaxa(bool taxa)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByTaxa", taxa));
        }

        public List<StudentInfo> StudentListByUsernameAnUniv(string username, long idAnUniv)
        {
            return CBO.FillCollection<StudentInfo>(SqlHelper.ExecuteReader(_connectionString, "StudentListByUsernameAnUniv", username, idAnUniv));
        }

        public List<string> StudentListDenumiriByAnUniv(long idAnUniv)
        {
            return CBO.FillCollection<string>(SqlHelper.ExecuteReader(_connectionString, "StudentListDenumiriByAnUniv", idAnUniv));
        }

        public void StudentUpdate(StudentInfo student)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdate",
                student.Nume, student.Initiale, student.Prenume, student.ID_TipActIdentitate, student.CNP, student.Numar_serie,
                student.DataNastere, student.PrenumeTata, student.PrenumeMama, student.NumeCasatorie, student.Telefon, student.Email,
                student.Web, student.Adresa, student.ID_TipTara, student.ID_Nationalitate, student.ID_TipCetatenie,
                student.ID_ADouaCetatenie, student.ID_TipStareCivila, student.ID_TipSituatieMilitara, student.Sex, student.ID_TipBanca,
                student.ContBanca, student.VenitPerFamilie, student.AlteVenituri, student.NumeLiceuAbsolvit, student.NotaBacalaureat,
                student.Judet, student.Localitate, student.JudetNastere, student.LocalitateNastere, student.OrfanDeUnParinte,
                student.OrfanAmbiiParinti, student.ID_Utilizator, student.DataModificare, student.Status, student.PortalID, student.ID_CandidatFacultateAdmitere);
        }

        /* public void StudentUpdateAtributDinamic(StudentAtributDinamicInfo atributDinamic)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdateAtributDinamic",
                atributDinamic.ID_StudentAtributDinamic, atributDinamic.ID_Student, atributDinamic.ValoareAtribut, atributDinamic.ID_AtributDinamic);
        }

        public void StudentUpdateBancaSiContBanca(StudentBancaInfo bancaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdateBancaSiContBanca",
                bancaInfo.ID_Student, bancaInfo.ID_TipBanca, bancaInfo.ContBanca);
        } */

        public void StudentUpdateInfoPentruBursa(BursaInfo bursaInfo)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdateInfoPentruBursa",
                bursaInfo.ID_Student, bursaInfo.ID_TipBursa, bursaInfo.NumarSemestruBursa, bursaInfo.ID_AnUnivBursa, bursaInfo.NuSeCalculeazaBursa,
                bursaInfo.StudentCreditat, bursaInfo.NumarSemestruCalculPunctaj, bursaInfo.SumaCrediteToateMateriile, bursaInfo.SumaCrediteMateriiPromovate,
                bursaInfo.SumaPuncteValoriceMateriiPromovate, bursaInfo.PunctajDacaIntegralist, bursaInfo.MedieDacaIntegralist, bursaInfo.TipBursa,
                bursaInfo.MediePunctajDeUtilizat, bursaInfo.ID_N_BursaS1, bursaInfo.ID_N_BursaS2, bursaInfo.ListaAlteBurseS1, bursaInfo.ListaAlteBurseS2,
                bursaInfo.NuSeCalculeazaMedia, bursaInfo.ObservatiiStudent, bursaInfo.MedieAdmitere, bursaInfo.BugetBursaDisponibil, bursaInfo.BugetBursaRamas);
        }

        /* public void StudentUpdateInfoUser(StudentInfoUser userInfo)
         {
             SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdateInfoUser",
                 userInfo.ID_Student, userInfo.UserID, userInfo.Username);
         } */

        public void StudentUpdatePasswordByUsername(string username, string password)
        {
            SqlHelper.ExecuteNonQuery(_connectionString, "StudentUpdatePasswordByUsername", username, password);
        }
    }
}