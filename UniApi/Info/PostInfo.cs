using System;

namespace UniApi.Info
{
	public partial class PostInfo
	{
		#region "Constructors"

		public PostInfo()
		{
		}

		public PostInfo(long iD_Post, long iD_AnUniv, int nrPozitie, double totalOreConventionale, int tipPost, int modPlata)
		{
			ID_Post = iD_Post;
			ID_AnUniv = iD_AnUniv;
			NrPozitie = nrPozitie;
			TotalOreConventionale = totalOreConventionale;
			TipPost = tipPost;
			ModPlata = modPlata;
		}

		#endregion

		#region "Public Properties"

		public long ID_Post { get; set; }

		public long ID_AnUniv { get; set; }

		public int NrPozitie { get; set; }

		public double TotalOreConventionale { get; set; }

		public int TipPost { get; set; }

		public int ModPlata { get; set; }

		public long ID_Catedra { get; set; }

		public int OwnerID { get; set; }
		public DateTime DataModificare { get; set; }
		public int Status { get; set; }

		public int ID_NivelTipGradDidactic { get; set; }
		public string DenumireGradDidactic { get; set; }
		public long ID_ProfesorTitular { get; set; }

		public long ID_Scenariu { get; set; }

		#endregion
	}
}