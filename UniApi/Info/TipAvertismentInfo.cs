namespace UniApi.Info
{
	public partial class TipAvertismentInfo
	{
		#region "Constructors"

		public TipAvertismentInfo()
		{
		}

		public TipAvertismentInfo(long iD_TipAvertisment, string denumireAvertisment)
		{
			ID_TipAvertisment = iD_TipAvertisment;
			DenumireAvertisment = denumireAvertisment;
		}

		#endregion

		#region "Public Properties"

		public long ID_TipAvertisment { get; set; }

		public string DenumireAvertisment { get; set; }

		#endregion
	}
}