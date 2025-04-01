using System;

namespace UniApi.Info
{
	public partial class CerereAdeverintaInfo
	{
		#region "Constructors"

		public CerereAdeverintaInfo()
		{
		}

		public CerereAdeverintaInfo(long iD_CerereAdeverinta, long iD_Student, long iD_AnUniv, long iD_Grupe, long iD_MotivCerereAdeverinta, long iD_NumarInregistrare, long iD_TipCerereAdeverinta, string descriereMotivStudent, DateTime dataCerere)
		{
			ID_CerereAdeverinta = iD_CerereAdeverinta;
			ID_Student = iD_Student;
			ID_AnUniv = iD_AnUniv;
			ID_Grupe = iD_Grupe;
			ID_MotivCerereAdeverinta = iD_MotivCerereAdeverinta;
			ID_NumarInregistrare = iD_NumarInregistrare;
			ID_TipCerereAdeverinta = iD_TipCerereAdeverinta;
			DescriereMotivStudent = descriereMotivStudent;
			DataCerere = dataCerere;
		}

		#endregion

		#region "Public Properties"

		public string Data { set; get; }

		public long ID_CerereAdeverinta { get; set; }

		public long ID_Student { get; set; }

		public long ID_AnUniv { get; set; }

		public long ID_Grupe { get; set; }

		public long ID_MotivCerereAdeverinta { get; set; }

		public long ID_NumarInregistrare { get; set; }

		public long ID_TipCerereAdeverinta { get; set; }

		public string DescriereMotivStudent { get; set; }

		public DateTime DataCerere { get; set; }

		public bool Aprobat { get; set; }

		public bool Tiparit { get; set; }

		public string Denumire { get; set; }

		public string DenumireTip { get; set; }

		public string DenumireMotiv { get; set; }

		public string Sablon { get; set; }

		public long NumarInregistrare { get; set; }

		#endregion

		//
		//
	}
}