namespace UniApi.Info
{
	public partial class ValoareTipBursaFacultateInfo
	{
		public ValoareTipBursaFacultateInfo()
		{
		}

		public ValoareTipBursaFacultateInfo(long iD_ValoareTipBursaFacultate, long iD_Facultate, long iD_TipBursa, int numarLuna, decimal valoareTipBursa, long iD_AnUnivBursa)
		{
			ID_ValoareTipBursaFacultate = iD_ValoareTipBursaFacultate;
			ID_Facultate = iD_Facultate;
			ID_TipBursa = iD_TipBursa;
			NumarLuna = numarLuna;
			ValoareTipBursa = valoareTipBursa;
			ID_AnUnivBursa = iD_AnUnivBursa;
		}

		public long ID_ValoareTipBursaFacultate { get; set; }

		public long ID_Facultate { get; set; }

		public long ID_TipBursa { get; set; }

		public int NumarLuna { get; set; }

		public decimal ValoareTipBursa { get; set; }

		public long ID_AnUnivBursa { get; set; }
	}
}