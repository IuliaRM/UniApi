namespace UniApi.Info
{
	public partial class DepartamentInfo
	{
		public DepartamentInfo()
		{
		}

		public DepartamentInfo(long iD_Departament, string denumireDepartament, string denumireScurtaDepartament)
		{
			ID_Departament = iD_Departament;
			DenumireDepartament = denumireDepartament;
			DenumireScurtaDepartament = denumireScurtaDepartament;
		}

		public long ID_Departament { get; set; }

		public string DenumireDepartament { get; set; }

		public string DenumireScurtaDepartament { get; set; }

	}
}