using System;
namespace UniApi.Info
{
    public partial class AbsolvireStudentProbaInfo
    {
        long _iD_StudentAbsolventProba;
        long _iD_AbsolvireProgramProba;
        decimal _nota;
        long _iD_NotaStudentMateriePachetAbsolvire;

        public AbsolvireStudentProbaInfo()
        {
        }

        public AbsolvireStudentProbaInfo(long iD_StudentAbsolventProba, long iD_AbsolvireProgramProba, decimal nota, long iD_NotaStudentMateriePachetAbsolvire)
        {
            this.ID_StudentAbsolventProba = iD_StudentAbsolventProba;
            this.ID_AbsolvireProgramProba = iD_AbsolvireProgramProba;
            this.Nota = nota;
            this.ID_NotaStudentMateriePachetAbsolvire = iD_NotaStudentMateriePachetAbsolvire;
        }

        public long ID_StudentAbsolventProba
        {
            get { return _iD_StudentAbsolventProba; }
            set { _iD_StudentAbsolventProba = value; }
        }

        public long ID_AbsolvireProgramProba
        {
            get { return _iD_AbsolvireProgramProba; }
            set { _iD_AbsolvireProgramProba = value; }
        }

        public decimal Nota
        {
            get { return _nota; }
            set { _nota = value; }
        }

        public long ID_NotaStudentMateriePachetAbsolvire
        {
            get { return _iD_NotaStudentMateriePachetAbsolvire; }
            set { _iD_NotaStudentMateriePachetAbsolvire = value; }
        }

        public long ID_AbsolvireStudent { get; set; }
        public long ID_Student { get; set; }
    }
}
