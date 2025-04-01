namespace UniApi.Info
{
	public partial class TipReducereInfo
	{
		public TipReducereInfo()
		{
		}

		public TipReducereInfo(long iD_TipReducere, string denumireTipReducere, decimal procentStandardReducere, long iD_Taxe)
		{
			ID_TipReducere = iD_TipReducere;
			DenumireTipReducere = denumireTipReducere;
			ProcentStandardReducere = procentStandardReducere;
			ID_Taxe = iD_Taxe;
		}

		public long ID_TipReducere { get; set; }

		public string DenumireTipReducere { get; set; }

		public decimal ProcentStandardReducere { get; set; }

		public long ID_Taxe { get; set; }

		public long ID_TipTaxa { get; set; }
	}
}