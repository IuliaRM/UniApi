namespace UniApi.Info
{
	public partial class FacultateCameraInfo
	{
		public FacultateCameraInfo()
		{
		}

		public FacultateCameraInfo(long iD_FacultateCamera, long iD_Facultate, long iD_Camera, long iD_AnUniv)
		{
			ID_FacultateCamera = iD_FacultateCamera;
			ID_Facultate = iD_Facultate;
			ID_Camera = iD_Camera;
			ID_AnUniv = iD_AnUniv;
		}

		public long ID_FacultateCamera { get; set; }

		public long ID_Facultate { get; set; }

		public long ID_Camera { get; set; }

		public long ID_AnUniv { get; set; }

		public string NumarCamera { get; set; }

        public string TipCameraMF { get; set; }

        public string Etaj { get; set; }

        public long ID_Camin { get; set; }

        public int NrLocuri { get; set; }

        public int NrStudentiCazati { get; set; }
    }
}