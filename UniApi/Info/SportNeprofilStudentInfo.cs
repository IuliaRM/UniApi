using System;
namespace UniApi.Info
{
    public partial class SportNeprofilStudentInfo : StudentInfo
    {
        long _iD_SportNeprofilStudent;
        long _iD_SportNeprofil;
        long _iD_Student;

        public SportNeprofilStudentInfo()
        {
        }

        public SportNeprofilStudentInfo(long iD_SportNeprofilStudent, long iD_SportNeprofil, long iD_Student)
        {
            this.ID_SportNeprofilStudent = iD_SportNeprofilStudent;
            this.ID_SportNeprofil = iD_SportNeprofil;
            this.ID_Student = iD_Student;
        }

        public long ID_SportNeprofilStudent
        {
            get { return _iD_SportNeprofilStudent; }
            set { _iD_SportNeprofilStudent = value; }
        }

        public long ID_SportNeprofil
        {
            get { return _iD_SportNeprofil; }
            set { _iD_SportNeprofil = value; }
        }

        public long ID_Student
        {
            get { return _iD_Student; }
            set { _iD_Student = value; }
        }

        public string DenumireCompleta { get; set; }

        public string Zi { get; set; }

        public string Interval { get; set; }
        public string Disciplina { get; set; }
        public string CadruDidactic { get; set; }
        public string Locatie { get; set; }

        public int NrLocuriOcupate { get; set; }

        public int NrLocuriDisponibile { get; set; }

        public int NrLocuri { get; set; }

        public int NrSemestru { get; set; }
    }

    public partial class SportNeprofilStudentInfo2
    {
        long _iD_SportNeprofilStudent;
        long _iD_SportNeprofil;
        long _iD_Student;

        public SportNeprofilStudentInfo2()
        {
        }

        public SportNeprofilStudentInfo2(long iD_SportNeprofilStudent, long iD_SportNeprofil, long iD_Student)
        {
            this.ID_SportNeprofilStudent = iD_SportNeprofilStudent;
            this.ID_SportNeprofil = iD_SportNeprofil;
            this.ID_Student = iD_Student;
        }

        public long ID_SportNeprofilStudent
        {
            get { return _iD_SportNeprofilStudent; }
            set { _iD_SportNeprofilStudent = value; }
        }

        public long ID_SportNeprofil
        {
            get { return _iD_SportNeprofil; }
            set { _iD_SportNeprofil = value; }
        }

        public long ID_Student
        {
            get { return _iD_Student; }
            set { _iD_Student = value; }
        }

        public string DenumireCompleta { get; set; }

        public string Zi { get; set; }

        public string Interval { get; set; }
        public string Disciplina { get; set; }
        public string CadruDidactic { get; set; }
        public string Locatie { get; set; }

        public int NrLocuriOcupate { get; set; }

        public int NrLocuriDisponibile { get; set; }

        public int NrLocuri { get; set; }

        public int NrSemestru { get; set; }
    }
}
