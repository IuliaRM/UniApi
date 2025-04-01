using System;

namespace UniApi.Info
{
	public partial class CuplajInfo
	{
		#region "Constructors"

		public CuplajInfo()
		{
		}

		public CuplajInfo(long iD_Cuplaj, string descriere, long iD_AnUniv, int nrFormatiiCurs, int nrFormatiiSeminar, int nrFormatiiLaborator, int nrFormatiiProiect, long iD_Catedra, long iD_Facultate, long tip, long iD_CatedraPrestatoareCurs, long iD_CatedraPrestatoareAplicatii)
		{
			ID_Cuplaj = iD_Cuplaj;
			Descriere = descriere;
			ID_AnUniv = iD_AnUniv;
			NrFormatiiCurs = nrFormatiiCurs;
			NrFormatiiSeminar = nrFormatiiSeminar;
			NrFormatiiLaborator = nrFormatiiLaborator;
			NrFormatiiProiect = nrFormatiiProiect;
			ID_Catedra = iD_Catedra;
			ID_Facultate = iD_Facultate;
			Tip = tip;
			ID_CatedraPrestatoareCurs = iD_CatedraPrestatoareCurs;
			ID_CatedraPrestatoareAplicatii = iD_CatedraPrestatoareAplicatii;
		}

		#endregion

		#region "Public Properties"

		public long ID_Cuplaj { get; set; }

		public string Descriere { get; set; }

		public long ID_AnUniv { get; set; }

		public int NrFormatiiCurs { get; set; }

		public int NrFormatiiSeminar { get; set; }

		public int NrFormatiiLaborator { get; set; }

		public int NrFormatiiProiect { get; set; }

		public long ID_Catedra { get; set; }

		public long ID_Facultate { get; set; }

		public long Tip { get; set; }

		public long ID_CatedraPrestatoareCurs { get; set; }

		public long ID_CatedraPrestatoareAplicatii { get; set; }

        public long ID_DetaliuPlanSemestruPrincipal { get; set; }

        public decimal NrOreCurs { get; set; }
        public decimal NrOreSeminar { get; set; }
        public decimal NrOreLaborator { get; set; }
        public decimal NrOreProiect { get; set; }

		public int OwnerID { get; set; }
		public DateTime	DataModificare { get; set; }
		public int Status { get; set; }

		public string DenumireCatedra { get; set; }
		public string DenumireFacultate { get; set; }
		public string DenumireCatedraPrestatoareCurs { get; set; }
		public string DenumireCatedraPrestatoareAplicatii { get; set; }

		public int NumarUtilizariCuplaj { get; set; }

		#endregion
	}
}