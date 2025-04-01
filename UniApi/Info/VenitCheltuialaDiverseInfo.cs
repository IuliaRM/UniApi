using System;
namespace UniApi.Info
{
	public partial class VenitCheltuialaDiverseInfo
	{
		long _iD_VenitCheltuialaDiverse;
		string _nivelVenitCheltuialaDiverse;
		long _iD_Facultate;
		long _iD_Catedra;
		long _iD_Trunchi;
		string _tipVenitCheltuialaDiverse;
		string _denumireVenitCheltuialaDiverse;
		decimal _valoareVenitCheltuialaDiverse;
		long _iD_AnUniv;
		DateTime _startPerioadaVenitCheltuialaDiverse;
		DateTime _sfarsitPerioadaVenitCheltuialaDiverse;

		public VenitCheltuialaDiverseInfo()
		{
		}

		public VenitCheltuialaDiverseInfo(long iD_VenitCheltuialaDiverse, string nivelVenitCheltuialaDiverse, long iD_Facultate, long iD_Catedra, long iD_Trunchi, string tipVenitCheltuialaDiverse, string denumireVenitCheltuialaDiverse, decimal valoareVenitCheltuialaDiverse, long iD_AnUniv, DateTime startPerioadaVenitCheltuialaDiverse, DateTime sfarsitPerioadaVenitCheltuialaDiverse)
		{
			this.ID_VenitCheltuialaDiverse = iD_VenitCheltuialaDiverse;
			this.NivelVenitCheltuialaDiverse = nivelVenitCheltuialaDiverse;
			this.ID_Facultate = iD_Facultate;
			this.ID_Catedra = iD_Catedra;
			this.ID_Trunchi = iD_Trunchi;
			this.TipVenitCheltuialaDiverse = tipVenitCheltuialaDiverse;
			this.DenumireVenitCheltuialaDiverse = denumireVenitCheltuialaDiverse;
			this.ValoareVenitCheltuialaDiverse = valoareVenitCheltuialaDiverse;
			this.ID_AnUniv = iD_AnUniv;
			this.StartPerioadaVenitCheltuialaDiverse = startPerioadaVenitCheltuialaDiverse;
			this.SfarsitPerioadaVenitCheltuialaDiverse = sfarsitPerioadaVenitCheltuialaDiverse;
		}

		public long ID_VenitCheltuialaDiverse
		{
			get { return _iD_VenitCheltuialaDiverse; }
			set { _iD_VenitCheltuialaDiverse = value; }
		}

		public string NivelVenitCheltuialaDiverse
		{
			get { return _nivelVenitCheltuialaDiverse; }
			set { _nivelVenitCheltuialaDiverse = value; }
		}

		public long ID_Facultate
		{
			get { return _iD_Facultate; }
			set { _iD_Facultate = value; }
		}

		public long ID_Catedra
		{
			get { return _iD_Catedra; }
			set { _iD_Catedra = value; }
		}

		public long ID_Trunchi
		{
			get { return _iD_Trunchi; }
			set { _iD_Trunchi = value; }
		}

		public string TipVenitCheltuialaDiverse
		{
			get { return _tipVenitCheltuialaDiverse; }
			set { _tipVenitCheltuialaDiverse = value; }
		}

		public string DenumireVenitCheltuialaDiverse
		{
			get { return _denumireVenitCheltuialaDiverse; }
			set { _denumireVenitCheltuialaDiverse = value; }
		}

		public decimal ValoareVenitCheltuialaDiverse
		{
			get { return _valoareVenitCheltuialaDiverse; }
			set { _valoareVenitCheltuialaDiverse = value; }
		}

		public long ID_AnUniv
		{
			get { return _iD_AnUniv; }
			set { _iD_AnUniv = value; }
		}

		public DateTime StartPerioadaVenitCheltuialaDiverse
		{
			get { return _startPerioadaVenitCheltuialaDiverse; }
			set { _startPerioadaVenitCheltuialaDiverse = value; }
		}

		public DateTime SfarsitPerioadaVenitCheltuialaDiverse
		{
			get { return _sfarsitPerioadaVenitCheltuialaDiverse; }
			set { _sfarsitPerioadaVenitCheltuialaDiverse = value; }
		}

		public string DenumireFacultate { get; set; }
		public int OrdineFacultate { get; set; }

		public string DenumireCatedra { get; set; }

		public string DenumireTrunchi { get; set; }

		public string DenumireAnUniv { get; set; }
	}
}
