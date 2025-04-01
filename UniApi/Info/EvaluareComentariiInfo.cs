namespace UniApi.Info
{
	public partial class EvaluareComentariiInfo
	{
		public EvaluareComentariiInfo()
		{
		}

		public EvaluareComentariiInfo(long _ID_RaspunsCriteriuEvaluareMaterie, long _ID_DetaliuPlanSemestru, string _ComentariuRaspuns)
		{
			ID_RaspunsCriteriuEvaluareMaterie = _ID_RaspunsCriteriuEvaluareMaterie;
			ID_DetaliuPlanSemestru = _ID_DetaliuPlanSemestru;
			ComentariuRaspuns = _ComentariuRaspuns;
		}

		public long ID_RaspunsCriteriuEvaluareMaterie { get; set; }

		public long ID_DetaliuPlanSemestru { get; set; }

		public string ComentariuRaspuns { get; set; }
	}
}