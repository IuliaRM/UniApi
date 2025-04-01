using System;

/// <summary>
/// This object represents the properties and methods of a Penalizari.
/// </summary>
namespace UniApi.Info
{
	public partial class PenalizariInfo
	{
		protected DateTime _dataModificare;
		protected long _id;
		protected long _iD_Utilizator;
		protected decimal _procent;
		protected int _status;
		protected double _sumaFixa;

		public PenalizariInfo()
		{
		}

		public PenalizariInfo(int _id, decimal _procent, double _sumaFixa, long _iD_Utilizator, DateTime _dataModificare, int _status)
		{
			this._id = _id;
			this._procent = _procent;
			this._sumaFixa = _sumaFixa;
			this._iD_Utilizator = _iD_Utilizator;
			this._dataModificare = _dataModificare;
			this._status = _status;
		}

		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public decimal Procent
		{
			get { return _procent; }
			set { _procent = value; }
		}

		public double SumaFixa
		{
			get { return _sumaFixa; }
			set { _sumaFixa = value; }
		}

		public long ID_Utilizator
		{
			get { return _iD_Utilizator; }
			set { _iD_Utilizator = value; }
		}

		public DateTime DataModificare
		{
			get { return _dataModificare; }
			set { _dataModificare = value; }
		}

		public int Status
		{
			get { return _status; }
			set { _status = value; }
		}
	}
}