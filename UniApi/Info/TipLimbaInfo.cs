using System;

namespace UniApi.Info
{
	public partial class TipLimbaInfo
	{
		public TipLimbaInfo()
		{
		}

		public TipLimbaInfo(long iD_TipLimba, string denumire, long iD_Utilizator, DateTime dataModificare, string status)
		{
			ID_TipLimba = iD_TipLimba;
			Denumire = denumire;
			ID_Utilizator = iD_Utilizator;
			DataModificare = dataModificare;
			Status = status;
		}

		public long ID_TipLimba { get; set; }

		public string Denumire { get; set; }

		public long ID_Utilizator { get; set; }

		public DateTime DataModificare { get; set; }

		public string Status { get; set; }
	}
}