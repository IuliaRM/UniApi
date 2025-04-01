using System;
namespace UniApi.Info
{
	public partial class IntervalChitantaInfo
	{
		long _iD_IntervalChitanta;
		long _nrInitialInterval;
		long _nrFinalInterval;
		int _iD_UtilizatorAsociat;
		long _UltimulNrChitantaID_Utilizator;
		long _NrChitantaDeFolosit;
		DateTime _ultimaDataChitantaID_Utilizator;
		int _iD_Utilizator;
		DateTime _dataModificare;
		int _status;
		bool _activ;
		int _ordine;

		public IntervalChitantaInfo()
		{
		}

		public IntervalChitantaInfo(long iD_IntervalChitanta, long nrInitialInterval, long nrFinalInterval, int iD_UtilizatorAsociat, long UltimulNrChitantaID_Utilizator, DateTime ultimaDataChitantaID_Utilizator, long nrChitantaDeFolosit, int iD_Utilizator, DateTime dataModificare, int status, bool activ, int ordine)
		{
			this.ID_IntervalChitanta = iD_IntervalChitanta;
			this.NrInitialInterval = nrInitialInterval;
			this.NrFinalInterval = nrFinalInterval;
			this.ID_UtilizatorAsociat = iD_UtilizatorAsociat;
			this.UltimulNrChitantaID_Utilizator = UltimulNrChitantaID_Utilizator;
			this.UltimaDataChitantaID_Utilizator = ultimaDataChitantaID_Utilizator;
			this.ID_Utilizator = iD_Utilizator;
			this.DataModificare = dataModificare;
			this.Status = status;
			this.Activ = activ;
			this.Ordine = ordine;
			this.NrChitantaDeFolosit = nrChitantaDeFolosit;
		}


		public long ID_IntervalChitanta
		{
			get { return _iD_IntervalChitanta; }
			set { _iD_IntervalChitanta = value; }
		}

		public long NrInitialInterval
		{
			get { return _nrInitialInterval; }
			set { _nrInitialInterval = value; }
		}

		public long NrFinalInterval
		{
			get { return _nrFinalInterval; }
			set { _nrFinalInterval = value; }
		}

		public int ID_UtilizatorAsociat
		{
			get { return _iD_UtilizatorAsociat; }
			set { _iD_UtilizatorAsociat = value; }
		}

		public long NrChitantaDeFolosit
		{
			get { return _NrChitantaDeFolosit; }
			set { _NrChitantaDeFolosit = value; }
		}

		public long UltimulNrChitantaID_Utilizator
		{
			get { return _UltimulNrChitantaID_Utilizator; }
			set { _UltimulNrChitantaID_Utilizator = value; }
		}

		public DateTime UltimaDataChitantaID_Utilizator
		{
			get { return _ultimaDataChitantaID_Utilizator; }
			set { _ultimaDataChitantaID_Utilizator = value; }
		}

		public int ID_Utilizator
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

		public bool Activ
		{
			get { return _activ; }
			set { _activ = value; }
		}

		public int Ordine
		{
			get { return _ordine; }
			set { _ordine = value; }
		}
	}
}
