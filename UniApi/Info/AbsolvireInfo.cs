namespace UniApi.Info
{
	public partial class AbsolvireInfo
	{
		public AbsolvireInfo()
		{
		}

		public AbsolvireInfo(long iD_Absolvent, long iD_Student, long iD_AnUnivAbsolvire, long iD_SpecializareAbsolvire, int anCalendaristicAbsolvire, string serieDiploma, string numarDiploma, string numarRegistru, string anRegistru)
		{
			ID_Absolvent = iD_Absolvent;
			ID_Student = iD_Student;
			ID_AnUnivAbsolvire = iD_AnUnivAbsolvire;
			ID_SpecializareAbsolvire = iD_SpecializareAbsolvire;
			AnCalendaristicAbsolvire = anCalendaristicAbsolvire;
			SerieDiploma = serieDiploma;
			NumarDiploma = numarDiploma;
			NumarRegistru = numarRegistru;
			AnRegistru = anRegistru;
		}

		public long ID_Absolvent { get; set; }

		public long ID_Student { get; set; }

		public long ID_AnUnivAbsolvire { get; set; }

		public long ID_SpecializareAbsolvire { get; set; }

		public int AnCalendaristicAbsolvire { get; set; }

		public string SerieDiploma { get; set; }

		public string NumarDiploma { get; set; }

		public string NumarRegistru { get; set; }

		public string AnRegistru { get; set; }
	}
}