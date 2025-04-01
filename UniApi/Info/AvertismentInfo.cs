using System;

namespace UniApi.Info
{
	public partial class AvertismentInfo
	{
		public AvertismentInfo()
		{
		}

		public AvertismentInfo(long iD_Avertisment, long iD_TipAvertisment, long iD_Cazare, DateTime dataAvertisment, string motiv, long iD_AnUniv)
		{
			ID_Avertisment = iD_Avertisment;
			ID_TipAvertisment = iD_TipAvertisment;
			ID_Cazare = iD_Cazare;
			DataAvertisment = dataAvertisment;
			Motiv = motiv;
			ID_AnUniv = iD_AnUniv;
		}

		public long ID_Avertisment { get; set; }

		public long ID_TipAvertisment { get; set; }

		public long ID_Cazare { get; set; }

		public DateTime DataAvertisment { get; set; }

		public string Motiv { get; set; }

		public long ID_AnUniv { get; set; }
	}
}