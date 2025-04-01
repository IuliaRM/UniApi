using System;

namespace UniApi.Info
{
	public partial class ProfesorGradDidacticInfo
	{
		public ProfesorGradDidacticInfo()
		{
		}

		public ProfesorGradDidacticInfo(long iD_ProfesorGradDidactic, long iD_TipGradDidactic, long iD_Profesor, DateTime dataDeCand, DateTime dataPanaCand, bool gradDidacticActiv, bool titular)
		{
			ID_ProfesorGradDidactic = iD_ProfesorGradDidactic;
			ID_TipGradDidactic = iD_TipGradDidactic;
			ID_Profesor = iD_Profesor;
			DataDeCand = dataDeCand;
			DataPanaCand = dataPanaCand;
			GradDidacticActiv = gradDidacticActiv;
			Titular = titular;
		}

		public long ID_ProfesorGradDidactic { get; set; }

		public long ID_TipGradDidactic { get; set; }

		public long ID_Profesor { get; set; }

		public DateTime DataDeCand { get; set; }

		public DateTime DataPanaCand { get; set; }

		public bool GradDidacticActiv { get; set; }

		public bool Titular { get; set; }

		public long ID_AnUniv { get; set; }
	}
}