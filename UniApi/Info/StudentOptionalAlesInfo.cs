using System;
namespace UniApi.Info
{
	public partial class StudentOptionalAlesInfo
	{
		long _iD_StudentOptionalAles;
		long _iD_Student;
		long _iD_DetaliuPlanSemestru;

		public StudentOptionalAlesInfo()
		{
		}

		public StudentOptionalAlesInfo(long iD_StudentOptionalAles, long iD_Student, long iD_DetaliuPlanSemestru)
		{
			this.ID_StudentOptionalAles = iD_StudentOptionalAles;
			this.ID_Student = iD_Student;
			this.ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
		}

		public long ID_StudentOptionalAles
		{
			get { return _iD_StudentOptionalAles; }
			set { _iD_StudentOptionalAles = value; }
		}

		public long ID_Student
		{
			get { return _iD_Student; }
			set { _iD_Student = value; }
		}

		public long ID_DetaliuPlanSemestru
		{
			get { return _iD_DetaliuPlanSemestru; }
			set { _iD_DetaliuPlanSemestru = value; }
		}

		public string NumeIntreg { get; set; }
	}
}
