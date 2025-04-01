using System;
namespace UniApi.Info
{
    public partial class AbsolvireStudentInfo
    {
        long _iD_AbsolvireStudent;
        long _iD_Student;
        string _nume;
        string _initiale;
        string _prenume;
        string _numeCasatorie;
        DateTime _dataNastere;
        string _iD_LocalitateNastere;
		string _iD_JudetNastere;
        long _iD_TaraNastere;
        decimal _medieFinalaAbsolvire;
        decimal _medieFinalaAni;
        string _serieDiploma;
        string _nrDiploma;
        long _nrOrdineIntern;

        public AbsolvireStudentInfo()
        {
        }

		public AbsolvireStudentInfo(long iD_AbsolvireStudent, long iD_Student, string nume, string initiale, string prenume, string numeCasatorie, DateTime dataNastere, string iD_LocalitateNastere, string iD_JudetNastere, long iD_TaraNastere, decimal medieFinalaAbsolvire, decimal medieFinalaAni, string serieDiploma, string nrDiploma, long nrOrdineIntern)
        {
            this.ID_AbsolvireStudent = iD_AbsolvireStudent;
            this.ID_Student = iD_Student;
            this.Nume = nume;
            this.Initiale = initiale;
            this.Prenume = prenume;
            this.NumeCasatorie = numeCasatorie;
            this.DataNastere = dataNastere;
            this.ID_LocalitateNastere = iD_LocalitateNastere;
            this.ID_JudetNastere = iD_JudetNastere;
            this.ID_TaraNastere = iD_TaraNastere;
            this.MedieFinalaAbsolvire = medieFinalaAbsolvire;
            this.MedieFinalaAni = medieFinalaAni;
            this.SerieDiploma = serieDiploma;
            this.NrDiploma = nrDiploma;
            this.NrOrdineIntern = nrOrdineIntern;
        }

        public long ID_AbsolvireStudent
        {
            get { return _iD_AbsolvireStudent; }
            set { _iD_AbsolvireStudent = value; }
        }

        public long ID_Student
        {
            get { return _iD_Student; }
            set { _iD_Student = value; }
        }

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }

        public string Initiale
        {
            get { return _initiale; }
            set { _initiale = value; }
        }

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }

        public string NumeCasatorie
        {
            get { return _numeCasatorie; }
            set { _numeCasatorie = value; }
        }

        public DateTime DataNastere
        {
            get { return _dataNastere; }
            set { _dataNastere = value; }
        }

		public string ID_LocalitateNastere
        {
            get { return _iD_LocalitateNastere; }
            set { _iD_LocalitateNastere = value; }
        }

		public string ID_JudetNastere
        {
            get { return _iD_JudetNastere; }
            set { _iD_JudetNastere = value; }
        }

        public long ID_TaraNastere
        {
            get { return _iD_TaraNastere; }
            set { _iD_TaraNastere = value; }
        }

        public decimal MedieFinalaAbsolvire
        {
            get { return _medieFinalaAbsolvire; }
            set { _medieFinalaAbsolvire = value; }
        }

        public decimal MedieFinalaAni
        {
            get { return _medieFinalaAni; }
            set { _medieFinalaAni = value; }
        }

        public string SerieDiploma
        {
            get { return _serieDiploma; }
            set { _serieDiploma = value; }
        }

        public string NrDiploma
        {
            get { return _nrDiploma; }
            set { _nrDiploma = value; }
        }

        public long NrOrdineIntern
        {
            get { return _nrOrdineIntern; }
            set { _nrOrdineIntern = value; }
        }

		public long ID_AbsolvireProgram { get; set; }

		public string DenumireJudetNastere { get; set; }
		public string DenumireLocalitateNastere { get; set; }
		public string DenumireTaraNastere { get; set; }
        public string TitluLucrareFinalizareStudii { get; set; }
        public string CSVUsernameConducatori { get; set; }
        public decimal NotaMediaLucrareFinalizareStudii { get; set; }
    }
}
