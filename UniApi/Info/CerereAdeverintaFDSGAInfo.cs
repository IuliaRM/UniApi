using System;

namespace UniApi.Info
{
	public partial class CerereAdeverintaFSDGAInfo
	{
		#region "Constructors"

		public bool Sters { get; set; }

		public string Data { set; get; }

		public long ID_CerereAdeverinta { get; set; }

		public bool Tiparit { set; get; }

		public string Sablon { get; set; }

		public long ID_NumarInregistrare { get; set; }

		#endregion

		#region "Public Properties"

		public long ID_Student { get; set; }

		public string Nume { get; set; }

		public string Initiale { get; set; }

		public string Prenume { get; set; }

		public string NumeIntreg { get; set; }

		public string DenumireDomeniu { get; set; }

		public string DenumireSpecializare { get; set; }

		public long ID_Facultate { get; set; }

		public string DenumireFacultate { get; set; }

		public long ID_Domeniu { get; set; }

		public long ID_Specializare { get; set; }

		public string TipDS { get; set; }

		public long ID_Grupe { get; set; }

		public string DenumireAnStudiu { get; set; }

		public string DenumireCicluInv { get; set; }

		public string DenumireFormaInv { get; set; }

		public long ID_AnUniv { get; set; }

		public string DenumireAnUniv { get; set; }

		public long ID_FCForma { get; set; }

		public long ID_FC { get; set; }

		public long ID_AnStudiu { get; set; }

		public string DenumireGrupa { get; set; }

		public long ID_TipCiclu { get; set; }

		public long ID_TipFormaInv { get; set; }

		public long ID_GrupeStudenti { get; set; }

		public long NumarInregistrare { get; set; }

		public string DenumireTip { get; set; }

		public string DenumireMotiv { get; set; }

		public string DescriereMotivStudent { get; set; }

		public DateTime DataCerere { get; set; }

		public bool Aprobat { get; set; }

		public long ID_TipCerereAdeverinta { get; set; }

		#endregion
	}
}