namespace UniApi.Info
{
	public partial class PostProfesorInfo : DetaliuPlanSemestruProfesorInfo
	{
		public PostProfesorInfo()
		{
		}

		public PostProfesorInfo(long iD_PostProfesor, long iD_Post, long iD_DetaliuPlanSemestruProfesor)
		{
			ID_PostProfesor = iD_PostProfesor;
			ID_Post = iD_Post;
			ID_DetaliuPlanSemestruProfesor = iD_DetaliuPlanSemestruProfesor;
		}

		public decimal ProcentPozitiePost { get; set; }

		public decimal NrOreConventionalePost { get; set; }

		public decimal ProcentPozitiePostSem1 { get; set; }

		public decimal ProcentPozitiePostSem2 { get; set; }

		public decimal NrOrePostCurs { get; set; }

		public decimal NrOrePostAplicatii { get; set; }

		public long ID_Scenariu { get; set; }

	}
}