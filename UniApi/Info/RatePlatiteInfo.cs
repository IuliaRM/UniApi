using System;

namespace UniApi.Info
{
	public partial class RatePlatiteInfo
	{
		public long ID_Student { get; set; }

		public string Nume { get; set; }

		public string Prenume { get; set; }

		public string Initiale { get; set; }

		public string NumeIntreg { get; set; }

		public long ID_TipCiclu { get; set; }

		public long ID_TipFormaInv { get; set; }

		public long ID_Facultate { get; set; }

		public string DenumireFacultate { get; set; }

		public string TipDS { get; set; }

		public long ID_Grupe { get; set; }

		public long ID_AnStudiu { get; set; }

		public string DenumireAnStudiu { get; set; }

		public string DenumireGrupa { get; set; }

		public long ID_IstoricTaxe { get; set; }

		public int Procent { get; set; }

		public double SumaFixa { get; set; }

		public decimal ValoareFaraReducere { get; set; }

		public decimal VALOARE { get; set; }

		public DateTime StartPerioada { get; set; }

		public DateTime EndPerioada { get; set; }

		public DateTime DataDeCand { get; set; }

		public DateTime DataPanaCand { get; set; }

		public bool Valid { get; set; }

		public string DenumireTaxa { get; set; }

		public long ID_Taxe { get; set; }

		public string DenumireIntreaga { get; set; }

		public string Moneda { get; set; }

		public int PortalID { get; set; }

		public string DenumireCicluInv { get; set; }

		public string DenumireFormaInv { get; set; }

		public long ID_AnUniv { get; set; }

		public long ID_FCForma { get; set; }

		public string DenumireAnUniv { get; set; }

		public long ID_FC { get; set; }

		public long ID_TipTaxa { get; set; }

		public long ID_TaxeStudent { get; set; }

		public long ID_Domeniu { get; set; }

		public long ID_Specializare { get; set; }

		public string NrMatricol { get; set; }

		public string DenumireDomeniu { get; set; }

		public string DenumireSpecializare { get; set; }

		public string ViewEditRoles { get; set; }

		public long ID_ReducereStudent { get; set; }

		public long ID_TipReducere { get; set; }

		public string MotivReducere { get; set; }

		public string DenumireTipReducere { get; set; }

		public decimal ProcentStandardReducere { get; set; }

		public long ID_Camin { get; set; }

		public string DenumireCamin { get; set; }

		public string DenumireCamera { get; set; }

		public bool TaxaAnulata { get; set; }

		public DateTime DataScadenta { get; set; }

		public bool EValoarePeZi { get; set; }

        public bool EValoarePeNoapte { get; set; }

        public DateTime Data_Plata { get; set; }

		public decimal SumaPlatita { get; set; }

		public string SerieChitanta { get; set; }

		public long NumarChitanta { get; set; }

		public long ID_RatePlatite { get; set; }

		public long ID_RataTaxa { get; set; }

		public string RatePlatiteStatus { get; set; }

		public long ID_Utilizator { get; set; }

		public decimal ValoareCursValutar { get; set; }

		public decimal SumaPlatitaMoneda { get; set; }

		public decimal SumaPenalizareMoneda { get; set; }

		public decimal SumaPenalizare { get; set; }

		public decimal ProcentPlatit { get; set; }

        public string EPID { get; set; }

        public long ID_ContContabil { get; set; }
    }
}