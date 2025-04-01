using System;
namespace UniApi.Info
{
	public partial class FluxDocumentRegistraturaInfo
	{
		long _iD_FluxDocReg;
		long _iD_DocReg;
		string _cOD_SEC;
		DateTime _dataInregistrare;
		string _tipIO;

		public FluxDocumentRegistraturaInfo()
		{
		}

		public FluxDocumentRegistraturaInfo(long iD_FluxDocReg, long iD_DocReg, string cOD_SEC, DateTime dataInregistrare, string tipIO)
		{
			this.ID_FluxDocReg = iD_FluxDocReg;
			this.ID_DocReg = iD_DocReg;
			this.COD_SEC = cOD_SEC;
			this.DataInregistrare = dataInregistrare;
			this.TipIO = tipIO;
		}

		public long ID_FluxDocReg
		{
			get { return _iD_FluxDocReg; }
			set { _iD_FluxDocReg = value; }
		}

		public long ID_DocReg
		{
			get { return _iD_DocReg; }
			set { _iD_DocReg = value; }
		}

		public string COD_SEC
		{
			get { return _cOD_SEC; }
			set { _cOD_SEC = value; }
		}

		public DateTime DataInregistrare
		{
			get { return _dataInregistrare; }
			set { _dataInregistrare = value; }
		}

		public string TipIO
		{
			get { return _tipIO; }
			set { _tipIO = value; }
		}

		public string DEN_SEC { get; set; }

		public bool Activ { get; set; }

		public int Zile { get; set; }
		public int Ore { get; set; }
		public int Minute { get; set; }

        public string UserModificat { get; set; }
        public DateTime DataModificat { get; set; }
        public string DocumentIdCodSec { get; set; }

        public Guid ID_FluxDocRegGUID { get; set; }
	}
}
