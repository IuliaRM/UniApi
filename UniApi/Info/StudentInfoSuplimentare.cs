using System;

namespace UniApi.Info
{
	public partial class StudentInfoSuplimentare
	{
		public StudentInfoSuplimentare()
		{
		}

        public StudentInfoSuplimentare(long iD_StudentInformatii, long iD_Student, long iD_Specializare, string studentInfo, string studentInfoEngleza, string tipInfoSuplimentara)
		{
			ID_StudentInformatii = iD_StudentInformatii;
			ID_Student = iD_Student;
			ID_Specializare = iD_Specializare;
			StudentInfo = studentInfo;
			StudentInfoEngleza = studentInfoEngleza;
            TipInfoSuplimentara = tipInfoSuplimentara;
		}

		public long ID_StudentInformatii { get; set; }

		public long ID_Student { get; set; }

		public long ID_Specializare { get; set; }

		public String StudentInfo { get; set; }

		public String StudentInfoEngleza { get; set; }

        public string TipInfoSuplimentara { get; set; }
	}
}