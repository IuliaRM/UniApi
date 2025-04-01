using System;

namespace UniApi.Info
{
	public partial class StudentDatePersonaleInfo
	{
		#region "Constructors"

		#endregion

		#region "Public Properties"

		public string Nume { get; set; }

		public string Initiale { get; set; }

		public string Prenume { get; set; }

		public string NumeIntreg { get; set; }

		public string NrMatricol { get; set; }

		public string DenumireDomeniu { get; set; }

		public string DenumireSpecializare { get; set; }

		public long ID_Facultate { get; set; }

		public string DenumireFacultate { get; set; }

		public long ID_Domeniu { get; set; }

		public long ID_Specializare { get; set; }

		public string TipDS { get; set; }

		public long ID_Grupe { get; set; }

		public string DenumireGrupa { get; set; }

		public long ID_AnStudiu { get; set; }

		public string DenumireAnStudiu { get; set; }

		public string DenumireCicluInv { get; set; }

		public string DenumireFormaInv { get; set; }

		public long ID_AnUniv { get; set; }

		public string DenumireAnUniv { get; set; }

		public long ID_FCForma { get; set; }

		public long ID_FC { get; set; }

		public long ID_TipCiclu { get; set; }

		public long ID_TipFormaInv { get; set; }

		public int PortalID { get; set; }

		public int Promovat { get; set; }

		public bool Exmatriculat { get; set; }

		public bool Creditat { get; set; }

		public bool Repetent { get; set; }

		public string Denumire { get; set; }

		public string TipTaxa { get; set; }

		public long ID_TaxeStudent { get; set; }

		public string CNP { get; set; }

		public string Numar_serie { get; set; }

		public long ID_GrupeStudenti { get; set; }

		public long ID_Student { get; set; }

		public long Expr1 { get; set; }

		public bool UltimaNotaActiva { get; set; }

		public DateTime DataNota { get; set; }

		public DateTime DataModificare { get; set; }

		public int ID_TipNota { get; set; }

		public string Nota { get; set; }

		public bool Expr2 { get; set; }

		public decimal SumaCrediteMateriiPromovate { get; set; }

		public string Username { get; set; }
		public string ParolaInitiala { get; set; }
		public string email { get; set; }

        public string TipIE { get; set; }

		public string DenumireScurtaFacultate { get; set; }

		public bool ContNou { get; set; }

		public int NrCrt { get; set; }

		public DateTime DataNastere { get; set; }

		public bool AreCNP { get; set; }

		public bool StudentStrain { get; set; }

		public string SNPasaportStrain { get; set; }

		#endregion
	}
}