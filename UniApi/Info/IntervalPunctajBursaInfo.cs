namespace UniApi.Info
{
	public partial class IntervalPunctajBursaInfo
	{
		public IntervalPunctajBursaInfo()
		{
		}

		public IntervalPunctajBursaInfo(long iD_IntervalPunctajBursa, long iD_AnUniv, long iD_AnUnivBursa, long numarSemestruBursa, long numarSemestruCalculPunctaj, long iD_FC, long iD_FCForma, long iD_Domeniu, long iD_AnStudiu, long iD_Specializare, decimal valoareMinPunctaj, decimal valoareMaxPunctaj)
		{
			ID_IntervalPunctajBursa = iD_IntervalPunctajBursa;
			ID_AnUniv = iD_AnUniv;
			ID_AnUnivBursa = iD_AnUnivBursa;
			NumarSemestruBursa = numarSemestruBursa;
			NumarSemestruCalculPunctaj = numarSemestruCalculPunctaj;
			ID_FC = iD_FC;
			ID_FCForma = iD_FCForma;
			ID_Domeniu = iD_Domeniu;
			ID_AnStudiu = iD_AnStudiu;
			ID_Specializare = iD_Specializare;
			ValoareMinPunctaj = valoareMinPunctaj;
			ValoareMaxPunctaj = valoareMaxPunctaj;
		}

		public long ID_IntervalPunctajBursa { get; set; }

		public long ID_AnUniv { get; set; }

		public long ID_AnUnivBursa { get; set; }

		public long NumarSemestruBursa { get; set; }

		public long NumarSemestruCalculPunctaj { get; set; }

		public long ID_FC { get; set; }

		public long ID_FCForma { get; set; }

		public long ID_Domeniu { get; set; }

		public long ID_AnStudiu { get; set; }

		public long ID_Specializare { get; set; }

		public decimal ValoareMinPunctaj { get; set; }

		public decimal ValoareMaxPunctaj { get; set; }

		public long ID_TipBursa { get; set; }

		public string DenumireCicluInv { get; set; }

		public string DenumireFormaInv { get; set; }

		public string DenumireDomeniu { get; set; }

		public string DenumireSpecializare { get; set; }

		public string DenumireAnStudiu { get; set; }
	}
}