using System;
namespace UniApi.Info
{
	public partial class TipTaraInfo
	{
		long _iD_TipTara;
		string _denumireTara;
		long _iD_Utilizator;
		DateTime _dataModificare;
		string _status;
		long _id_n_tara;
        string _cod_tara;

		public TipTaraInfo()
		{
		}

		public TipTaraInfo(long iD_TipTara, string denumireTara, long iD_Utilizator, DateTime dataModificare, string status, long id_n_tara, string cod_tara)
		{
			this.ID_TipTara = iD_TipTara;
			this.DenumireTara = denumireTara;
			this.ID_Utilizator = iD_Utilizator;
			this.DataModificare = dataModificare;
			this.Status = status;
			this.id_n_tara = id_n_tara;
            
		}

        public string cod_tara
        {
            get { return _cod_tara; }
            set { _cod_tara = value; }
        }

		public long ID_TipTara
		{
			get { return _iD_TipTara; }
			set { _iD_TipTara = value; }
		}

		public string DenumireTara
		{
			get { return _denumireTara; }
			set { _denumireTara = value; }
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

		public string Status
		{
			get { return _status; }
			set { _status = value; }
		}

		public long id_n_tara
		{
			get { return _id_n_tara; }
			set { _id_n_tara = value; }
		}
	}
}
