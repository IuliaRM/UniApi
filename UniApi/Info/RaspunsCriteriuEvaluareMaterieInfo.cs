namespace UniApi.Info
{
	public partial class RaspunsCriteriuEvaluareMaterieInfo
	{
		#region "Constructors"

		public RaspunsCriteriuEvaluareMaterieInfo()
		{
		}

		public RaspunsCriteriuEvaluareMaterieInfo(long iD_RaspunsCriteriuEvaluareMaterie, long iD_DetaliuPlanSemestru, long iD_TipCriteriuEvaluareVariantaRaspuns, string comentariuRaspuns)
		{
			ID_RaspunsCriteriuEvaluareMaterie = iD_RaspunsCriteriuEvaluareMaterie;
			ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
			ID_TipCriteriuEvaluareVariantaRaspuns = iD_TipCriteriuEvaluareVariantaRaspuns;
			ComentariuRaspuns = comentariuRaspuns;
		}

		#endregion

		#region "Public Properties"

		public long ID_RaspunsCriteriuEvaluareMaterie { get; set; }

		public long ID_DetaliuPlanSemestru { get; set; }

		public long ID_TipCriteriuEvaluareVariantaRaspuns { get; set; }

		public string ComentariuRaspuns { get; set; }

		#endregion
	}
}