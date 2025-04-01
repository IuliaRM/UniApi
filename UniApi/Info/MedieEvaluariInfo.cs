namespace UniApi.Info
{
	public partial class MedieEvaluariInfo
	{
		public MedieEvaluariInfo()
		{
		}

		public MedieEvaluariInfo(long _ID_TipCriteriuEvaluare, long _ID_DetaliuPlanSemestru, string _Denumire, double _MediaRaspuns)
		{
			ID_TipCriteriuEvaluare = _ID_TipCriteriuEvaluare;
			ID_DetaliuPlanSemestru = _ID_DetaliuPlanSemestru;
			Denumire = _Denumire;
			MediaRaspuns = _MediaRaspuns;
		}

		public long ID_TipCriteriuEvaluare { get; set; }

		public long ID_DetaliuPlanSemestru { get; set; }

		public string Denumire { get; set; }

		public double MediaRaspuns { get; set; }
	}
}