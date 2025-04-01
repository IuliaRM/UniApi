using System;

namespace UniApi.Info
{
	public partial class TaxaStudentInfo
	{
		#region "Constructors"

		#endregion

		#region "Public Properties"

		public long ID_Student { get; set; }

		public string Nume { get; set; }

		public string Prenume { get; set; }

		public string Initiale { get; set; }

		public string NumeIntreg { get; set; }

		public long ID_TipCiclu { get; set; }

		public long ID_TipFormaInv { get; set; }

		public long ID_Facultate { get; set; }

		public string DenumireFacultate { get; set; }

		public long ID_Domeniu { get; set; }

		public string DenumireDomeniu { get; set; }

		public long ID_Specializare { get; set; }

		public string DenumireSpecializare { get; set; }

		public string TipDS { get; set; }

		public long ID_Grupe { get; set; }

		public long ID_AnStudiu { get; set; }

		public string DenumireAnStudiu { get; set; }

		public string DenumireGrupa { get; set; }

		public string DenumireCicluInv { get; set; }

		public string DenumireFormaInv { get; set; }

		public long ID_AnUniv { get; set; }

		public long ID_FCForma { get; set; }

		public string DenumireAnUniv { get; set; }

		public long ID_FC { get; set; }

		public long ID_TaxeStudent { get; set; }

		public long ID_IstoricTaxe { get; set; }

		public decimal Procent { get; set; }

		public double SumaFixa { get; set; }

		public decimal Valoare { get; set; }

		public DateTime StartPerioada { get; set; }

		public DateTime EndPerioada { get; set; }

		public bool Valid { get; set; }

		public long ID_Taxe { get; set; }

		public string DenumireIntreaga { get; set; }

		public string Moneda { get; set; }

		public long ID_TipTaxa { get; set; }

		public DateTime Data_Plata { get; set; }

		public decimal SumaPlatita { get; set; }

		public string SerieChitanta { get; set; }

		public long NumarChitanta { get; set; }

		public long ID_RatePlatite { get; set; }

		public long ID_RataTaxa { get; set; }

		public string RatePlatiteStatus { get; set; }

		public decimal SumaPlatitaMoneda { get; set; }

		public decimal SumaPenalizareMoneda { get; set; }

		public decimal ValoareCursValutar { get; set; }

		public string Denumire { get; set; }

		public string ViewEditRoles { get; set; }

		public DateTime DataDeCand { get; set; }
		public DateTime DataPanaCand { get; set; }
		public DateTime DataScadenta { get; set; }

		public string MotivReducere { get; set; }
		public string DenumireTaxa { get; set; }
		public decimal ValoareFaraReducere { get; set; }

		public bool TaxaAnulata { get; set; }
		public bool EValoarePeZi { get; set; }
        public bool EValoarePeNoapte { get; set; }

        public decimal ProcentStandardReducere { get; set; }

		public float RestDePlata { get; set; }

		public decimal SumaPenalizareDePlata { get; set; }

		public long ID_PlanSemestru { get; set; }

		public long ID_PlanInvatamant { get; set; }

		public string DenumirePlanInvatamant { get; set; }
		public int NumarSemestru { get; set; }
		public int NumarSemestruDinAn { get; set; }
		public string DenumireDisciplina { get; set; }
		public string Observatii { get; set; }

		public long ID_Materie { get; set; }

		private string _DetaliiTaxa;
		public string DetaliiTaxa
		{
			get
			{
				return _DetaliiTaxa;
			}
			set
			{
				_DetaliiTaxa = value;

				_DetaliiTaxaasXML = null;

				FillDetaliiTaxaXML();
			}
		}

		private DetaliiTaxaXML _DetaliiTaxaasXML = null;
		public DetaliiTaxaXML DetaliiTaxaasXML
		{
			get
			{
				FillDetaliiTaxaXML();
				return _DetaliiTaxaasXML;
			}
			set
			{
				_DetaliiTaxaasXML = value;
			}
		}

		private void FillDetaliiTaxaXML()
		{
			if (_DetaliiTaxaasXML == null)
			{
				if (String.IsNullOrEmpty(_DetaliiTaxa))
					_DetaliiTaxaasXML = new DetaliiTaxaXML();
				//else
					//_DetaliiTaxaasXML = UniTBv.AGSIS.Utils.XmlToEntity<DetaliiTaxaXML>(_DetaliiTaxa);
			}
		}

        public bool TaxaPlatibila { get; set; }

        public bool TaxaPlatibilaOnline { get; set; }

        public bool TaxaPlatibilaOnlinePartial { get; set; }

        #endregion
    }
}