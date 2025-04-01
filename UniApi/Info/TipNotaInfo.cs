namespace UniApi.Info
{
	public partial class TipNotaInfo
	{
		public TipNotaInfo()
		{
		}

		public TipNotaInfo(int iD_TipNota, string nota, bool promovat)
		{
			ID_TipNota = iD_TipNota;
			Nota = nota;
			Promovat = promovat;
		}

		public int ID_TipNota { get; set; }

		public string Nota { get; set; }

		public bool Promovat { get; set; }
	}
}