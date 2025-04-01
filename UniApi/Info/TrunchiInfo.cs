namespace UniApi.Info
{
	public partial class TrunchiInfo
	{
		long _iD_Trunchi;
		string _denumireTrunchi;
		int _userID_Coordonator;

		public TrunchiInfo()
		{
		}

		public TrunchiInfo(long iD_Trunchi, string denumireTrunchi, int userID_Coordonator)
		{
			this.ID_Trunchi = iD_Trunchi;
			this.DenumireTrunchi = denumireTrunchi;
			this.UserID_Coordonator = userID_Coordonator;
		}

		public long ID_Trunchi
		{
			get { return _iD_Trunchi; }
			set { _iD_Trunchi = value; }
		}

		public string DenumireTrunchi
		{
			get { return _denumireTrunchi; }
			set { _denumireTrunchi = value; }
		}

		public int UserID_Coordonator
		{
			get { return _userID_Coordonator; }
			set { _userID_Coordonator = value; }
		}

        
    }
}
