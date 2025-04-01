using System;

/// <summary>
/// Summary description for Taxe
/// </summary>
namespace UniApi.Info
{
	public partial class TaxeInfo
	{
		protected DateTime _dataModificare;
		protected long _facultate;
		protected long _id;
		protected long _id_camin;
		protected long _iD_Utilizator;
		protected int _status;
		protected long _tip;

		public TaxeInfo()
		{
		}

		public TaxeInfo(long _id, long _tip, long _facultate, long _ID_TipCiclu, long _ID_TipFormaInv, long _ID_AnUniv, long _iD_Utilizator, DateTime _dataModificare, int _status, int _PortalId, long _id_camin)
		{
			this._id = _id;
			this._tip = _tip;
			this._facultate = _facultate;
			this._iD_Utilizator = _iD_Utilizator;
			this._dataModificare = _dataModificare;
			this._status = _status;
			ID_TipCiclu = _ID_TipCiclu;
			ID_TipFormaInv = _ID_TipFormaInv;
			ID_AnUniv = _ID_AnUniv;
			PortalId = _PortalId;
			this._id_camin = _id_camin;
		}

		public TaxeInfo(string perioada, string sumaPlatita, string dataPlatii, DateTime startPerioada, long ID_TaxeStudent)
		{
			Perioada = perioada;
			SumaPlatita = sumaPlatita;
			DataPlatii = dataPlatii;
			StartPerioada = startPerioada;
			this.ID_TaxeStudent = ID_TaxeStudent;
		}

		public long ID
		{
			get { return _id; }
			set { _id = value; }
		}

		public long Tip
		{
			get { return _tip; }
			set { _tip = value; }
		}

		public long ID_Facultate
		{
			get { return _facultate; }
			set { _facultate = value; }
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

		public long ID_TipCiclu { get; set; }

		public long ID_TipFormaInv { get; set; }

		public long ID_AnUniv { get; set; }

		public int PortalId { get; set; }

		public long ID_Camin
		{
			get { return _id_camin; }
			set { _id_camin = value; }
		}

		public string DataPlatii { get; set; }

		public string SumaPlatita { get; set; }

		public string Perioada { get; set; }

		public DateTime StartPerioada { get; set; }

		public long ID_TaxeStudent { set; get; }
	}
}