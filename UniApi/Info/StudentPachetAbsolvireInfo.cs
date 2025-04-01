namespace UniApi.Info
{
	public partial class StudentPachetAbsolvireInfo
	{
		public StudentPachetAbsolvireInfo()
		{
		}

		public StudentPachetAbsolvireInfo(long iD_StudentPachetAbsolvire, long iD_Student, long iD_AnUnivAbsolvire, long iD_PachetAbsolvire)
		{
			ID_StudentPachetAbsolvire = iD_StudentPachetAbsolvire;
			ID_Student = iD_Student;
			ID_AnUnivAbsolvire = iD_AnUnivAbsolvire;
			ID_PachetAbsolvire = iD_PachetAbsolvire;
		}

		public long Id_MateriePachetAbsolvire { get; set; }

		public string NumeIntreg { get; set; }

		private string _DenumirePachet;
		public string DenumirePachet
		{
			get
			{
				return _DenumirePachet;
			}
			set
			{
				_DenumirePachet = value;
			}
		}

		public long ID_StudentPachetAbsolvire { get; set; }

		public long ID_Student { get; set; }

		public long ID_AnUnivAbsolvire { get; set; }

		public long ID_PachetAbsolvire { get; set; }

		public decimal Nota { get; set; }

		public long Id_Materie { get; set; }

		public string Denumire { get; set; }

		public long ID_NotaStudentMateriePachetAbsolvire { get; set; }

		private string _DenumireSesiuneAbsolvire;
		public string DenumireSesiuneAbsolvire
		{
			get { return _DenumireSesiuneAbsolvire; }
			set { _DenumireSesiuneAbsolvire = value; }
		}

		public string DenumirePachetSiSesiune
		{
			get
			{
				return _DenumireSesiuneAbsolvire + ": " + _DenumirePachet;
			}
		}

        public decimal MedieExameneAbsolvire { get; set; }

        public decimal MedieFinalaAni { get; set; }

        public string DenumireAnUniv { get; set; }

        public long ID_Specializare { get; set; }

        public bool StudentVizibilDiplome { get; set; }
    }
}