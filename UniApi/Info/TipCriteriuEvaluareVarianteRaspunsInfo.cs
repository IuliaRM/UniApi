namespace UniApi.Info
{
	public partial class TipCriteriuEvaluareVarianteRaspunsInfo
	{
		#region "Constructors"

		public TipCriteriuEvaluareVarianteRaspunsInfo()
		{
		}

		public TipCriteriuEvaluareVarianteRaspunsInfo(long iD_TipCriteriuEvaluareVariantaRaspuns, long iD_TipCriteriuEvaluare, string textRaspuns, int valoareRaspuns)
		{
			ID_TipCriteriuEvaluareVariantaRaspuns = iD_TipCriteriuEvaluareVariantaRaspuns;
			ID_TipCriteriuEvaluare = iD_TipCriteriuEvaluare;
			TextRaspuns = textRaspuns;
			ValoareRaspuns = valoareRaspuns;
		}

		#endregion

		#region "Public Properties"

		public long ID_TipCriteriuEvaluareVariantaRaspuns { get; set; }

		public long ID_TipCriteriuEvaluare { get; set; }

		public string TextRaspuns { get; set; }

		public int ValoareRaspuns { get; set; }

		#endregion
	}
}