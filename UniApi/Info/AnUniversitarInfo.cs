using System;

namespace UniApi.Info
{
	public partial class AnUniversitarInfo
	{
		private long _iD_AnUniv;
		private long _id_AnUnivPrecedent = -1;

		#region "Constructors"

		public AnUniversitarInfo()
		{
		}

		public AnUniversitarInfo(long iD_AnUniv, string denumire, int iD_Utilizator, DateTime dataModificare, int status, int portalID)
		{
			ID_AnUniv = iD_AnUniv;
			Denumire = denumire;
			ID_Utilizator = iD_Utilizator;
			DataModificare = dataModificare;
			Status = status;
			PortalID = portalID;
		}

		#endregion

		#region "Public Properties"

		public long ID_AnUniv
		{
			get { return _iD_AnUniv; }
			set { _iD_AnUniv = value; }
		}

		public string Denumire { get; set; }

		public int ID_Utilizator { get; set; }

		public DateTime DataModificare { get; set; }

		public int Status { get; set; }

		public int PortalID { get; set; }

		public long Id_AnUnivPrecedent
		{
			get { return _id_AnUnivPrecedent; }
			set { _id_AnUnivPrecedent = value; }
		}

		public String idAnUnivCurent_IdAnUnivPrecedent
		{
			get { return _iD_AnUniv + "_" + _id_AnUnivPrecedent; }
			set { ; //do nothing
			}
		}

		public DateTime DataInceputAnUniv { get; set; }

		public DateTime DataSfirsitAnUniv { get; set; }

		#endregion
	}
}