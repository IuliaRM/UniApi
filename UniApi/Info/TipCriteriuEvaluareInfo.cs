using System.Collections.Generic;

namespace UniApi.Info
{
	public partial class TipCriteriuEvaluareInfo
	{
		#region "Constructors"

		public TipCriteriuEvaluareInfo()
		{
		}

		public TipCriteriuEvaluareInfo(long iD_TipCriteriuEvaluare, string descriereCriteriu, string modVizualizare, string intrebare, long iDRaspunsDefault, string iDText, bool raspunsObligatoriu, string minText, string maxText, int dimensiune, List<TipCriteriuEvaluareVarianteRaspunsInfo> raspunsuri)
		{
			ID_TipCriteriuEvaluare = iD_TipCriteriuEvaluare;
			DescriereCriteriu = descriereCriteriu;
			ModVizualizare = modVizualizare;
			Intrebare = intrebare;
			IDRaspunsDefault = iDRaspunsDefault;
			IDText = iDText;
			RaspunsObligatoriu = raspunsObligatoriu;
			MinText = minText;
			MaxText = maxText;
			Dimensiune = dimensiune;
			Raspunsuri = raspunsuri;
		}

		#endregion

		#region "Public Properties"

		public long ID_TipCriteriuEvaluare { get; set; }

		public string DescriereCriteriu { get; set; }

		public string ModVizualizare { get; set; }

		public string Intrebare { get; set; }

		public long IDRaspunsDefault { get; set; }

		public string IDText { get; set; }

		public bool RaspunsObligatoriu { get; set; }

		public string MinText { get; set; }

		public string MaxText { get; set; }

		public int Dimensiune { get; set; }

		public List<TipCriteriuEvaluareVarianteRaspunsInfo> Raspunsuri { get; set; }

		#endregion
	}
}