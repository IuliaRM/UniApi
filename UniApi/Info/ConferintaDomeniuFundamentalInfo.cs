using System;
namespace UniApi.Info
{
	public partial class ConferintaDomeniuFundamentalInfo
	{
		long _iD_ConferintaDomeniuFundamental;
		long _iD_Conferinta;
		int _iD_N_DomeniuFundamental;

		public ConferintaDomeniuFundamentalInfo()
		{
		}

		public ConferintaDomeniuFundamentalInfo(long iD_ConferintaDomeniuFundamental, long iD_Conferinta, int iD_N_DomeniuFundamental)
		{
			this.ID_ConferintaDomeniuFundamental = iD_ConferintaDomeniuFundamental;
			this.ID_Conferinta = iD_Conferinta;
			this.ID_N_DomeniuFundamental = iD_N_DomeniuFundamental;
		}

		public long ID_ConferintaDomeniuFundamental
		{
			get { return _iD_ConferintaDomeniuFundamental; }
			set { _iD_ConferintaDomeniuFundamental = value; }
		}

		public long ID_Conferinta
		{
			get { return _iD_Conferinta; }
			set { _iD_Conferinta = value; }
		}

		public int ID_N_DomeniuFundamental
		{
			get { return _iD_N_DomeniuFundamental; }
			set { _iD_N_DomeniuFundamental = value; }
		}
	}
}
