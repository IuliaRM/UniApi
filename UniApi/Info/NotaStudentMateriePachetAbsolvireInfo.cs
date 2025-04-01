using System;

namespace UniApi.Info
{
	public partial class NotaStudentMateriePachetAbsolvireInfo
	{
		public NotaStudentMateriePachetAbsolvireInfo()
		{
		}

		public NotaStudentMateriePachetAbsolvireInfo(long iD_NotaStudentMateriePachetAbsolvire, long iD_Student, long iD_MateriePachetAbsolvire, decimal nota, DateTime dataNota)
		{
			ID_NotaStudentMateriePachetAbsolvire = iD_NotaStudentMateriePachetAbsolvire;
			ID_Student = iD_Student;
			ID_MateriePachetAbsolvire = iD_MateriePachetAbsolvire;
			Nota = nota;
			DataNota = dataNota;
		}

		public long ID_NotaStudentMateriePachetAbsolvire { get; set; }

		public long ID_Student { get; set; }

		public long ID_MateriePachetAbsolvire { get; set; }

		public decimal Nota { get; set; }

		public DateTime DataNota { get; set; }
	}
}