using System;
namespace UniApi.Info
{
    public partial class StudentStudiiAnterioareFacultateInfo : ProgramStudiuRMUInfo
    {
        long _iD_StudentStudiiAnterioareFacultate;
        long _iD_Student;
        string _cNP;
        Guid _iD_CandidatFacultateAdmitere;
        int _iD_N_TaraFacultateAbsolvita;
        int _iD_N_JudetFacultateAbsolvita;
        int _iD_N_LocalitateFacultateAbsolvita;
        string _formaInvFacultateAbsolvita;
        long _iD_AnUnivAbsolvire;
        int _iD_N_UniversitateAbsolvita;
        int _anAbsolvireFacultate;
        int _durataStudiiFacultateAbsolvita;
        int _iD_N_FacultateAbsolvita;
        int _iD_N_DomeniuStudiuFacultateAbsolvita;
        int _iD_N_FormaInvFacultateAbsolvita;
        int _iD_N_ProgramSpecializareFacultateAbsolvita;
        int _iD_N_TitluObtinutFacultateAbsolvita;
        int _iD_N_FormaFinantareFacultateAbsolvita;
        int _iD_N_TipDiplomaFacultateAbsolvita;
        string _diplomaFacultate_Seria;
        string _diplomaFacultate_Numar;
        int _iD_N_UniversitateEmitentaDiplomaFacultateAbsolvita;
        int _diplomaFacultate_AnEmitere;
        string _aLTE_OBSERVATII;

        public StudentStudiiAnterioareFacultateInfo()
        {
        }

        public StudentStudiiAnterioareFacultateInfo(long iD_StudentStudiiAnterioareFacultate, long iD_Student, string cNP, Guid iD_CandidatFacultateAdmitere, int iD_N_TaraFacultateAbsolvita, int iD_N_JudetFacultateAbsolvita, int iD_N_LocalitateFacultateAbsolvita, string formaInvFacultateAbsolvita, long iD_AnUnivAbsolvire, int iD_N_UniversitateAbsolvita, int anAbsolvireFacultate, int durataStudiiFacultateAbsolvita, int iD_N_FacultateAbsolvita, int iD_N_DomeniuStudiuFacultateAbsolvita, int iD_N_FormaInvFacultateAbsolvita, int iD_N_ProgramSpecializareFacultateAbsolvita, int iD_N_TitluObtinutFacultateAbsolvita, int iD_N_FormaFinantareFacultateAbsolvita, int iD_N_TipDiplomaFacultateAbsolvita, string diplomaFacultate_Seria, string diplomaFacultate_Numar, int iD_N_UniversitateEmitentaDiplomaFacultateAbsolvita, int diplomaFacultate_AnEmitere, string aLTE_OBSERVATII,
            int AnIncepereFacultate, string LocalitateStudiiStrainatate, string UniversitateStudiiStrainatate, string SpecializareStudiiStrainatate, int NrSemestreFinantate, int AnFinalizareFacultate, decimal MedieAbsolvire, int ID_N_JudetUniversitateEmitenta, int ID_N_LocalitateUniversitateEmitenta, string LocalitateEmitentStrainatate)
        {
            this.ID_StudentStudiiAnterioareFacultate = iD_StudentStudiiAnterioareFacultate;
            this.ID_Student = iD_Student;
            this.CNP = cNP;
            this.ID_CandidatFacultateAdmitere = iD_CandidatFacultateAdmitere;
            this.ID_N_TaraFacultateAbsolvita = iD_N_TaraFacultateAbsolvita;
            this.ID_N_JudetFacultateAbsolvita = iD_N_JudetFacultateAbsolvita;
            this.ID_N_LocalitateFacultateAbsolvita = iD_N_LocalitateFacultateAbsolvita;
            this.FormaInvFacultateAbsolvita = formaInvFacultateAbsolvita;
            this.ID_AnUnivAbsolvire = iD_AnUnivAbsolvire;
            this.ID_N_UniversitateAbsolvita = iD_N_UniversitateAbsolvita;
            this.AnAbsolvireFacultate = anAbsolvireFacultate;
            this.DurataStudiiFacultateAbsolvita = durataStudiiFacultateAbsolvita;
            this.ID_N_FacultateAbsolvita = iD_N_FacultateAbsolvita;
            this.ID_N_DomeniuStudiuFacultateAbsolvita = iD_N_DomeniuStudiuFacultateAbsolvita;
            this.ID_N_FormaInvFacultateAbsolvita = iD_N_FormaInvFacultateAbsolvita;
            this.ID_N_ProgramSpecializareFacultateAbsolvita = iD_N_ProgramSpecializareFacultateAbsolvita;
            this.ID_N_TitluObtinutFacultateAbsolvita = iD_N_TitluObtinutFacultateAbsolvita;
            this.ID_N_FormaFinantareFacultateAbsolvita = iD_N_FormaFinantareFacultateAbsolvita;
            this.ID_N_TipDiplomaFacultateAbsolvita = iD_N_TipDiplomaFacultateAbsolvita;
            this.DiplomaFacultate_Seria = diplomaFacultate_Seria;
            this.DiplomaFacultate_Numar = diplomaFacultate_Numar;
            this.ID_N_UniversitateEmitentaDiplomaFacultateAbsolvita = iD_N_UniversitateEmitentaDiplomaFacultateAbsolvita;
            this.DiplomaFacultate_AnEmitere = diplomaFacultate_AnEmitere;
            this.ALTE_OBSERVATII = aLTE_OBSERVATII;

            this.AnIncepereFacultate = AnIncepereFacultate;
            this.LocalitateStudiiStrainatate = LocalitateStudiiStrainatate;
            this.UniversitateStudiiStrainatate = UniversitateStudiiStrainatate;
            this.SpecializareStudiiStrainatate = SpecializareStudiiStrainatate;
            this.NrSemestreFinantate = NrSemestreFinantate;
            this.AnFinalizareFacultate = AnFinalizareFacultate;
            this.MedieAbsolvire = MedieAbsolvire;
            this.ID_N_JudetUniversitateEmitenta = ID_N_JudetUniversitateEmitenta;
            this.ID_N_LocalitateUniversitateEmitenta = ID_N_LocalitateUniversitateEmitenta;
            this.LocalitateEmitentStrainatate = LocalitateEmitentStrainatate;
        }

        public long ID_StudentStudiiAnterioareFacultate
        {
            get { return _iD_StudentStudiiAnterioareFacultate; }
            set { _iD_StudentStudiiAnterioareFacultate = value; }
        }

        public long ID_Student
        {
            get { return _iD_Student; }
            set { _iD_Student = value; }
        }

        public string CNP
        {
            get { return _cNP; }
            set { _cNP = value; }
        }

        public Guid ID_CandidatFacultateAdmitere
        {
            get { return _iD_CandidatFacultateAdmitere; }
            set { _iD_CandidatFacultateAdmitere = value; }
        }

        public int ID_N_TaraFacultateAbsolvita
        {
            get { return _iD_N_TaraFacultateAbsolvita; }
            set { _iD_N_TaraFacultateAbsolvita = value; }
        }

        public int ID_N_JudetFacultateAbsolvita
        {
            get { return _iD_N_JudetFacultateAbsolvita; }
            set { _iD_N_JudetFacultateAbsolvita = value; }
        }

        public int ID_N_LocalitateFacultateAbsolvita
        {
            get { return _iD_N_LocalitateFacultateAbsolvita; }
            set { _iD_N_LocalitateFacultateAbsolvita = value; }
        }

        public string FormaInvFacultateAbsolvita
        {
            get { return _formaInvFacultateAbsolvita; }
            set { _formaInvFacultateAbsolvita = value; }
        }

        public long ID_AnUnivAbsolvire
        {
            get { return _iD_AnUnivAbsolvire; }
            set { _iD_AnUnivAbsolvire = value; }
        }

        public int ID_N_UniversitateAbsolvita
        {
            get { return _iD_N_UniversitateAbsolvita; }
            set { _iD_N_UniversitateAbsolvita = value; }
        }

        public int AnAbsolvireFacultate
        {
            get { return _anAbsolvireFacultate; }
            set { _anAbsolvireFacultate = value; }
        }

        public int DurataStudiiFacultateAbsolvita
        {
            get { return _durataStudiiFacultateAbsolvita; }
            set { _durataStudiiFacultateAbsolvita = value; }
        }

        public int ID_N_FacultateAbsolvita
        {
            get { return _iD_N_FacultateAbsolvita; }
            set { _iD_N_FacultateAbsolvita = value; }
        }

        public int ID_N_DomeniuStudiuFacultateAbsolvita
        {
            get { return _iD_N_DomeniuStudiuFacultateAbsolvita; }
            set { _iD_N_DomeniuStudiuFacultateAbsolvita = value; }
        }

        public int ID_N_FormaInvFacultateAbsolvita
        {
            get { return _iD_N_FormaInvFacultateAbsolvita; }
            set { _iD_N_FormaInvFacultateAbsolvita = value; }
        }

        public int ID_N_ProgramSpecializareFacultateAbsolvita
        {
            get { return _iD_N_ProgramSpecializareFacultateAbsolvita; }
            set { _iD_N_ProgramSpecializareFacultateAbsolvita = value; }
        }

        public int ID_N_TitluObtinutFacultateAbsolvita
        {
            get { return _iD_N_TitluObtinutFacultateAbsolvita; }
            set { _iD_N_TitluObtinutFacultateAbsolvita = value; }
        }

        public int ID_N_FormaFinantareFacultateAbsolvita
        {
            get { return _iD_N_FormaFinantareFacultateAbsolvita; }
            set { _iD_N_FormaFinantareFacultateAbsolvita = value; }
        }

        public int ID_N_TipDiplomaFacultateAbsolvita
        {
            get { return _iD_N_TipDiplomaFacultateAbsolvita; }
            set { _iD_N_TipDiplomaFacultateAbsolvita = value; }
        }

        public string DiplomaFacultate_Seria
        {
            get { return _diplomaFacultate_Seria; }
            set { _diplomaFacultate_Seria = value; }
        }

        public string DiplomaFacultate_Numar
        {
            get { return _diplomaFacultate_Numar; }
            set { _diplomaFacultate_Numar = value; }
        }

        public int ID_N_UniversitateEmitentaDiplomaFacultateAbsolvita
        {
            get { return _iD_N_UniversitateEmitentaDiplomaFacultateAbsolvita; }
            set { _iD_N_UniversitateEmitentaDiplomaFacultateAbsolvita = value; }
        }

        public int DiplomaFacultate_AnEmitere
        {
            get { return _diplomaFacultate_AnEmitere; }
            set { _diplomaFacultate_AnEmitere = value; }
        }

        public string ALTE_OBSERVATII
        {
            get { return _aLTE_OBSERVATII; }
            set { _aLTE_OBSERVATII = value; }
        }

        public string DenumireUniversitateAbsolvita { get; set; }

        public string DenumireUniversitateEmitenta { get; set; }

        //  AnIncepereFacultate
        //,LocalitateStudiiStrainatate
        //,UniversitateStudiiStrainatate
        //,SpecializareStudiiStrainatate
        //,NrSemestreFinantate
        //,AnFinalizareFacultate
        //,MedieAbsolvire
        //,ID_N_JudetUniversitateEmitenta
        //,ID_N_LocalitateUniversitateEmitenta
        //,LocalitateEmitentStrainatate

        public int AnIncepereFacultate { get; set; }

        public string LocalitateStudiiStrainatate { get; set; }

        public string UniversitateStudiiStrainatate { get; set; }

        public string SpecializareStudiiStrainatate { get; set; }

        public int NrSemestreFinantate { get; set; }

        public int AnFinalizareFacultate { get; set; }

        public decimal MedieAbsolvire { get; set; }

        public int ID_N_JudetUniversitateEmitenta { get; set; }

        public int ID_N_LocalitateUniversitateEmitenta { get; set; }

        public string LocalitateEmitentStrainatate { get; set; }

        public int ID_N_CicluStudii { get; set; }

        public string Text_UniversitateAbsolvita { get; set; }
        public string Text_DenumireFacultateAbsolvita { get; set; }
        public string Text_DomeniuStudiuFacultateAbsolvita { get; set; }
        public string Text_FormaInvFacultateAbsolvita { get; set; }
        public string Text_ProgramSpecializareFacultateAbsolvita { get; set; }
        public string Text_TitluObtinutFacultateAbsolvita { get; set; }
        public string Text_UniversitateEmitentaDiplomaFacultateAbsolvita { get; set; }
        public string Text_CicluStudii { get; set; }

        public int NrCrediteFacultateAbsolvita { get; set; }
    }
}
