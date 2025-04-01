using System;
namespace UniApi.Info
{
	public partial class TipBursaInfo
	{
		long _iD_TipBursa;
		long _iD_Utilizator;
		DateTime _dataModificare;
		string _denumireTipBursa;
		long _iD_N_Bursa;

		public TipBursaInfo()
		{
		}

		public TipBursaInfo(long iD_TipBursa, long iD_Utilizator, DateTime dataModificare, string denumireTipBursa, long iD_N_Bursa)
		{
			this.ID_TipBursa = iD_TipBursa;
			this.ID_Utilizator = iD_Utilizator;
			this.DataModificare = dataModificare;
			this.DenumireTipBursa = denumireTipBursa;
			this.ID_N_Bursa = iD_N_Bursa;
		}

		public long ID_TipBursa
		{
			get { return _iD_TipBursa; }
			set { _iD_TipBursa = value; }
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

		public string DenumireTipBursa
		{
			get { return _denumireTipBursa; }
			set { _denumireTipBursa = value; }
		}

		public long ID_N_Bursa
		{
			get { return _iD_N_Bursa; }
			set { _iD_N_Bursa = value; }
		}

        public long ID_TipPerioadaAcordareBursa { get; set; }

        public string TipRaportBursa { get; set; }
    }
}
