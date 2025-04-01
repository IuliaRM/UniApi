namespace UniApi.Info
{
	public partial class CatedraInfo
	{
		public CatedraInfo()
		{
		}

		public CatedraInfo(long iD_Catedra, string denumireCatedra, string denumireScurtaCatedra, long iD_Facultate, long iD_ProfesorSefCatedra, long iD_AnUniv)
		{
			ID_Catedra = iD_Catedra;
			DenumireCatedra = denumireCatedra;
			DenumireScurtaCatedra = denumireScurtaCatedra;
			ID_Facultate = iD_Facultate;
			ID_ProfesorSefCatedra = iD_ProfesorSefCatedra;
            ID_AnUniv = iD_AnUniv;
		}

		public long ID_Catedra { get; set; }

		public string DenumireCatedra { get; set; }

		public string DenumireScurtaCatedra { get; set; }

		public long ID_Facultate { get; set; }

		public long ID_ProfesorSefCatedra { get; set; }

        public long ID_AnUniv { get; set; }

        public string UsernameSecretar { get; set; }

        public string UsernameCoordonatorCEAC { get; set; }
    }
}