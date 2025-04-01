using System;
namespace UniApi.Info
{
    public partial class AbsolvireProgramProbaInfo
    {
        long _iD_AbsolvireProgramProba;
        long _iD_AbsolvireProgram;
        string _denumireProba;
        decimal _nrCrediteProba;
        decimal _notaMinimaPromovare;
        long _iD_PachetAbsolvire;

        public AbsolvireProgramProbaInfo()
        {
        }

        public AbsolvireProgramProbaInfo(long iD_AbsolvireProgramProba, long iD_AbsolvireProgram, string denumireProba, decimal nrCrediteProba, decimal notaMinimaPromovare, long iD_PachetAbsolvire)
        {
            this.ID_AbsolvireProgramProba = iD_AbsolvireProgramProba;
            this.ID_AbsolvireProgram = iD_AbsolvireProgram;
            this.DenumireProba = denumireProba;
            this.NrCrediteProba = nrCrediteProba;
            this.NotaMinimaPromovare = notaMinimaPromovare;
            this.ID_PachetAbsolvire = iD_PachetAbsolvire;
        }

        public long ID_AbsolvireProgramProba
        {
            get { return _iD_AbsolvireProgramProba; }
            set { _iD_AbsolvireProgramProba = value; }
        }

        public long ID_AbsolvireProgram
        {
            get { return _iD_AbsolvireProgram; }
            set { _iD_AbsolvireProgram = value; }
        }

        public string DenumireProba
        {
            get { return _denumireProba; }
            set { _denumireProba = value; }
        }

        public decimal NrCrediteProba
        {
            get { return _nrCrediteProba; }
            set { _nrCrediteProba = value; }
        }

        public decimal NotaMinimaPromovare
        {
            get { return _notaMinimaPromovare; }
            set { _notaMinimaPromovare = value; }
        }

        public long ID_PachetAbsolvire
        {
            get { return _iD_PachetAbsolvire; }
            set { _iD_PachetAbsolvire = value; }
        }

        public string DenumireSesiuneAbsolvire { get; set; }
    }
}
