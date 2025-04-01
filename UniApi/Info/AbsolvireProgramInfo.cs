using System;
namespace UniApi.Info
{
    public partial class AbsolvireProgramInfo
    {
        long _iD_AbsolvireProgram;
        long _iD_AnUnivAbsolvire;
        int _iD_UniversitateAbsolvita;
        int _iD_FacultateAbsolvita;
        int _iD_DomeniuAbsolvit;
        int _iD_ProgramStudiuAbsolvit;
        int _nrCrediteProgram;
        string _titlulObtinut;
        long _iD_LocalitateProgram;
        int _iD_UniversitateAcordaDiploma;
        int _iD_FacultateAcordaDiploma;
        string _sesiuneExamenAbsolvire;
        int _anExamenAbsolvire;
        int _nrProbeExamenAbsolvire;
        decimal _medieMinimaPromovare;
        long _iD_CicluInv;
        long _iD_FormaInv;
        string _numeRector;
        string _numeDecan;
        string _numeSecretarSefUniversitate;
        string _numeSecretarSefFacultate;
        long _iD_PachetAbsolvire;

        public AbsolvireProgramInfo()
        {
        }

        public AbsolvireProgramInfo(long iD_AbsolvireProgram, long iD_AnUnivAbsolvire, int iD_UniversitateAbsolvita, int iD_FacultateAbsolvita, int iD_DomeniuAbsolvit, int iD_ProgramStudiuAbsolvit, int nrCrediteProgram, string titlulObtinut, long iD_LocalitateProgram, int iD_UniversitateAcordaDiploma, int iD_FacultateAcordaDiploma, string sesiuneExamenAbsolvire, int anExamenAbsolvire, int nrProbeExamenAbsolvire, decimal medieMinimaPromovare, long iD_CicluInv, long iD_FormaInv, string numeRector, string numeDecan, string numeSecretarSefUniversitate, string numeSecretarSefFacultate, long iD_PachetAbsolvire)
        {
            this.ID_AbsolvireProgram = iD_AbsolvireProgram;
            this.ID_AnUnivAbsolvire = iD_AnUnivAbsolvire;
            this.ID_UniversitateAbsolvita = iD_UniversitateAbsolvita;
            this.ID_FacultateAbsolvita = iD_FacultateAbsolvita;
            this.ID_DomeniuAbsolvit = iD_DomeniuAbsolvit;
            this.ID_ProgramStudiuAbsolvit = iD_ProgramStudiuAbsolvit;
            this.NrCrediteProgram = nrCrediteProgram;
            this.TitlulObtinut = titlulObtinut;
            this.ID_LocalitateProgram = iD_LocalitateProgram;
            this.ID_UniversitateAcordaDiploma = iD_UniversitateAcordaDiploma;
            this.ID_FacultateAcordaDiploma = iD_FacultateAcordaDiploma;
            this.SesiuneExamenAbsolvire = sesiuneExamenAbsolvire;
            this.AnExamenAbsolvire = anExamenAbsolvire;
            this.NrProbeExamenAbsolvire = nrProbeExamenAbsolvire;
            this.MedieMinimaPromovare = medieMinimaPromovare;
            this.ID_CicluInv = iD_CicluInv;
            this.ID_FormaInv = iD_FormaInv;
            this.NumeRector = numeRector;
            this.NumeDecan = numeDecan;
            this.NumeSecretarSefUniversitate = numeSecretarSefUniversitate;
            this.NumeSecretarSefFacultate = numeSecretarSefFacultate;
            this.ID_PachetAbsolvire = iD_PachetAbsolvire;
        }

        public long ID_AbsolvireProgram
        {
            get { return _iD_AbsolvireProgram; }
            set { _iD_AbsolvireProgram = value; }
        }

        public long ID_AnUnivAbsolvire
        {
            get { return _iD_AnUnivAbsolvire; }
            set { _iD_AnUnivAbsolvire = value; }
        }

        public int ID_UniversitateAbsolvita
        {
            get { return _iD_UniversitateAbsolvita; }
            set { _iD_UniversitateAbsolvita = value; }
        }

        public int ID_FacultateAbsolvita
        {
            get { return _iD_FacultateAbsolvita; }
            set { _iD_FacultateAbsolvita = value; }
        }

        public int ID_DomeniuAbsolvit
        {
            get { return _iD_DomeniuAbsolvit; }
            set { _iD_DomeniuAbsolvit = value; }
        }

        public int ID_ProgramStudiuAbsolvit
        {
            get { return _iD_ProgramStudiuAbsolvit; }
            set { _iD_ProgramStudiuAbsolvit = value; }
        }

        public int NrCrediteProgram
        {
            get { return _nrCrediteProgram; }
            set { _nrCrediteProgram = value; }
        }

        public string TitlulObtinut
        {
            get { return _titlulObtinut; }
            set { _titlulObtinut = value; }
        }

        public long ID_LocalitateProgram
        {
            get { return _iD_LocalitateProgram; }
            set { _iD_LocalitateProgram = value; }
        }

        public int ID_UniversitateAcordaDiploma
        {
            get { return _iD_UniversitateAcordaDiploma; }
            set { _iD_UniversitateAcordaDiploma = value; }
        }

        public int ID_FacultateAcordaDiploma
        {
            get { return _iD_FacultateAcordaDiploma; }
            set { _iD_FacultateAcordaDiploma = value; }
        }

        public string SesiuneExamenAbsolvire
        {
            get { return _sesiuneExamenAbsolvire; }
            set { _sesiuneExamenAbsolvire = value; }
        }

        public int AnExamenAbsolvire
        {
            get { return _anExamenAbsolvire; }
            set { _anExamenAbsolvire = value; }
        }

        public int NrProbeExamenAbsolvire
        {
            get { return _nrProbeExamenAbsolvire; }
            set { _nrProbeExamenAbsolvire = value; }
        }

        public decimal MedieMinimaPromovare
        {
            get { return _medieMinimaPromovare; }
            set { _medieMinimaPromovare = value; }
        }

        public long ID_CicluInv
        {
            get { return _iD_CicluInv; }
            set { _iD_CicluInv = value; }
        }

        public long ID_FormaInv
        {
            get { return _iD_FormaInv; }
            set { _iD_FormaInv = value; }
        }

        public string NumeRector
        {
            get { return _numeRector; }
            set { _numeRector = value; }
        }

        public string NumeDecan
        {
            get { return _numeDecan; }
            set { _numeDecan = value; }
        }

        public string NumeSecretarSefUniversitate
        {
            get { return _numeSecretarSefUniversitate; }
            set { _numeSecretarSefUniversitate = value; }
        }

        public string NumeSecretarSefFacultate
        {
            get { return _numeSecretarSefFacultate; }
            set { _numeSecretarSefFacultate = value; }
        }

        public long ID_PachetAbsolvire
        {
            get { return _iD_PachetAbsolvire; }
            set { _iD_PachetAbsolvire = value; }
        }

    }
}
