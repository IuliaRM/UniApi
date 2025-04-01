using System;
namespace UniApi.Info
{
    public partial class ChestionarInfo
    {
        #region "Private Members"

       // long _portalID;
       // long _userID;

        #endregion
        #region "Constructors"

        public ChestionarInfo()
        {
        }

        public ChestionarInfo(long iD_Chestionar, string denumire, DateTime dataChestionar)
        {
            this.ID_Chestionar = iD_Chestionar;
            this.Denumire = denumire;
            //this.PortalID = portalID;
            //this.UserID = userID;
            this.DataChestionar = dataChestionar;
        }
        #endregion

        #region "Public Properties"

        public long ID_Chestionar { get; set; }

        public string Denumire { get; set; }

        public long PortalID
        {
            get { return Convert.ToInt64(this.PortalID); }
            //set { _portalID = Convert.ToInt64(this.PortalID); }
        }

        public long UserID
        {
            get { return Convert.ToInt64(this.UserID); }
            //set { _userID = Convert.ToInt64(this.UserID); }
        }

        public DateTime DataChestionar { get; set; }

        #endregion
    }
}