using System;

namespace UniApi.Info
{
	public partial class CatedraProfesorInfo
	{
		public CatedraProfesorInfo()
		{
		}

		public CatedraProfesorInfo(long iD_CatedraProfesor, long iD_Catedra, long iD_Profesor, DateTime dataDeCand, DateTime dataPanaCand, bool catedraProfesorActiv)
		{
			ID_CatedraProfesor = iD_CatedraProfesor;
			ID_Catedra = iD_Catedra;
			ID_Profesor = iD_Profesor;
			DataDeCand = dataDeCand;
			DataPanaCand = dataPanaCand;
			CatedraProfesorActiv = catedraProfesorActiv;
		}

		public long ID_CatedraProfesor { get; set; }

		public long ID_Catedra { get; set; }

		public long ID_Profesor { get; set; }

		public DateTime DataDeCand { get; set; }

		public DateTime DataPanaCand { get; set; }

		public bool CatedraProfesorActiv { get; set; }

		public string NumeIntreg { get; set; }

		public string DenumireCatedra { get; set; }

		public long ID_Facultate { get; set; }

		public int UserID { get; set; }

		public long ID_AnUniv { get; set; }

		public long ID_TipGradDidactic { get; set; }

		public string DidCerc { get; set; }

        public string Username { get; set; }
    }
}