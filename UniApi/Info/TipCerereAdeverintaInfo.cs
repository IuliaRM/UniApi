namespace UniApi.Info
{
	public partial class TipCerereAdeverintaInfo
	{
		#region "Constructors"

		public TipCerereAdeverintaInfo()
		{
		}

		public TipCerereAdeverintaInfo(long iD_TipCerereAdeverinta, string denumire, string sablon)
		{
			ID_TipCerereAdeverinta = iD_TipCerereAdeverinta;
			DenumireTip = denumire;
			Sablon = sablon;
		}

		#endregion

		#region "Public Properties"

		public long ID_TipCerereAdeverinta { get; set; }

		public string DenumireTip { get; set; }

		public string Sablon { get; set; }

		#endregion
	}
}