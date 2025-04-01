using System;
namespace UniApi.Info
{
	public partial class ScenariuInfo
	{
		long _iD_Scenariu;
		string _denumireScenariu;
		bool _scenariuActiv;
		long _iD_Catedra;
		long _iD_AnUniv;

		public ScenariuInfo()
		{
		}

		public ScenariuInfo(long iD_Scenariu, string denumireScenariu, bool scenariuActiv, long iD_Catedra, long iD_AnUniv, DateTime dataModificare, int iD_Utilizator)
		{
			this.ID_Scenariu = iD_Scenariu;
			this.DenumireScenariu = denumireScenariu;
			this.ScenariuActiv = scenariuActiv;
			this.ID_Catedra = iD_Catedra;
			this.ID_AnUniv = iD_AnUniv;
			this.DataModificare = dataModificare;
			this.ID_Utilizator = iD_Utilizator;
		}

		public long ID_Scenariu
		{
			get { return _iD_Scenariu; }
			set { _iD_Scenariu = value; }
		}

		public string DenumireScenariu
		{
			get { return _denumireScenariu; }
			set { _denumireScenariu = value; }
		}

		public bool ScenariuActiv
		{
			get { return _scenariuActiv; }
			set { _scenariuActiv = value; }
		}

		public long ID_Catedra
		{
			get { return _iD_Catedra; }
			set { _iD_Catedra = value; }
		}

		public long ID_AnUniv
		{
			get { return _iD_AnUniv; }
			set { _iD_AnUniv = value; }
		}

		public DateTime DataModificare { get; set; }

		public int ID_Utilizator { get; set; }

		public long ID_ScenariuSursa { get; set; }
	}
}
