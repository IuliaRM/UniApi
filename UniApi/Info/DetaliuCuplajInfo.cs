namespace UniApi.Info
{
	public partial class DetaliuCuplajInfo: DetaliuPlanSemestruInfo
	{
		#region "Constructors"

		public DetaliuCuplajInfo()
		{
		}

		public DetaliuCuplajInfo(long iD_DetaliuCuplaj, long iD_DetaliuPlanSemestru, long iD_Cuplaj)
		{
			ID_DetaliuCuplaj = iD_DetaliuCuplaj;
			ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
			ID_Cuplaj = iD_Cuplaj;
		}

		#endregion

		#region "Public Properties"

		public long ID_DetaliuCuplaj { get; set; }

		//public long ID_DetaliuPlanSemestru { get; set; }

		//public long ID_Cuplaj { get; set; }

		#endregion
	}
}