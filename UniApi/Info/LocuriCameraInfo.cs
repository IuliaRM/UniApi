namespace UniApi.Info
{
	public partial class LocuriCameraInfo
	{
		#region "Constructors"

		public LocuriCameraInfo()
		{
		}

		public LocuriCameraInfo(long iD_LocuriCamera, long iD_Camera, int nrLocuri, long iD_AnUniv)
		{
			ID_LocuriCamera = iD_LocuriCamera;
			ID_Camera = iD_Camera;
			NrLocuri = nrLocuri;
			ID_AnUniv = iD_AnUniv;
		}

		#endregion

		#region "Public Properties"

		public long ID_LocuriCamera { get; set; }

		public long ID_Camera { get; set; }

		public int NrLocuri { get; set; }

		public long ID_AnUniv { get; set; }

		#endregion
	}
}