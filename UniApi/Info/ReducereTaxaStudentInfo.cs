using System;

namespace UniApi.Info
{
	public partial class ReducereTaxaStudentInfo
	{
		//string _MotivReducere;

		public ReducereTaxaStudentInfo()
		{
		}

		public ReducereTaxaStudentInfo(long iD_ReducereStudent, long iD_Student, long iD_TipReducere, DateTime dataDeCand, DateTime dataPanaCand, string _MotivReducere)
		{
			ID_ReducereStudent = iD_ReducereStudent;
			ID_Student = iD_Student;
			ID_TipReducere = iD_TipReducere;
			DataDeCand = dataDeCand;
			DataPanaCand = dataPanaCand;
			MotivReducere = _MotivReducere;
		}

		public long ID_ReducereStudent { get; set; }

		public long ID_Student { get; set; }

		public long ID_TipReducere { get; set; }

		public DateTime DataDeCand { get; set; }

		public DateTime DataPanaCand { get; set; }

		public string MotivReducere { get; set; }

		public decimal ProcentStandardReducere { get; set; }

		public long ID_TipTaxa { get; set; }
	}
}