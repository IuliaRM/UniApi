using System;
namespace UniApi.Info
{
    public partial class TipConferintaInfo
    {
        long _iD_TipConferinta;
        string _denumireTipConferinta;

        public TipConferintaInfo()
        {
        }

        public TipConferintaInfo(long iD_TipConferinta, string denumireTipConferinta)
        {
            this.ID_TipConferinta = iD_TipConferinta;
            this.DenumireTipConferinta = denumireTipConferinta;
        }

        public long ID_TipConferinta
        {
            get { return _iD_TipConferinta; }
            set { _iD_TipConferinta = value; }
        }

        public string DenumireTipConferinta
        {
            get { return _denumireTipConferinta; }
            set { _denumireTipConferinta = value; }
        }
    }
}
