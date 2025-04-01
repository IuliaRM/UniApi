namespace UniApi.Info
{
	public partial class PachetAbsolvireInfo
	{
		public PachetAbsolvireInfo(long ID_AnUniv, long ID_Specializare, string denumirePachet, string denumireSesiuneAbsolvire, int anSesiuneAbsolvire)
		{
			Id_AnUnivAbsolvire = ID_AnUniv;
			Id_Specializare = ID_Specializare;
			DenumirePachet = denumirePachet;
			DenumireSesiuneAbsolvire = denumireSesiuneAbsolvire;
			AnSesiuneAbsolvire = anSesiuneAbsolvire;
		}

		public PachetAbsolvireInfo()
		{
		}

		public long Id_PachetAbsolvire { get; set; }

		public long Id_AnUnivAbsolvire { get; set; }

		public long Id_Specializare { get; set; }

		public string DenumirePachet { get; set; }

		public string DenumireSesiuneAbsolvire { get; set; }

        public bool ActivaInscriereStudenti { get; set; }

        public long ID_ProfesorPresedinteComisie { get; set; }
        public string NumeIntregPresedinteComisie { get; set; }

        public string CSVUsernameSecretariComisie { get; set; }
        public string CSVUsernameMembriComisie { get; set; }

        public int AnSesiuneAbsolvire { get; set; }

		public string JSONMembriComisie { get; set; }
		public string JSONSecretariComisie { get; set; }

        public int NrProbeInPachetAbsolvireSiSesiune { get; set; }

        public string DenumireCicluInv { get; set; }
        public string DenumireFormaInv { get; set; }
    }
}