using System;

namespace UniApi.Info
{
	public partial class DepartamentProfesorInfo
	{
		public DepartamentProfesorInfo()
		{
		}

		public DepartamentProfesorInfo(long iD_DepartamentProfesor, long iD_Departament, long iD_Profesor, DateTime dataDeCand, DateTime dataPanaCand, bool departamentProfesorActiv, long iD_AnUnivDepartament)
		{
			ID_DepartamentProfesor = iD_DepartamentProfesor;
			ID_Departament = iD_Departament;
			ID_Profesor = iD_Profesor;
			DataDeCand = dataDeCand;
			DataPanaCand = dataPanaCand;
			DepartamentProfesorActiv = departamentProfesorActiv;
			ID_AnUnivDepartament = iD_AnUnivDepartament;
		}

		public long ID_DepartamentProfesor { get; set; }

		public long ID_Departament { get; set; }

		public long ID_Profesor { get; set; }

		public DateTime DataDeCand { get; set; }

		public DateTime DataPanaCand { get; set; }

		public bool DepartamentProfesorActiv { get; set; }

		public string NumeIntreg { get; set; }

		public string DenumireDepartament { get; set; }

		public long ID_AnUnivDepartament { get; set; }
	}
}