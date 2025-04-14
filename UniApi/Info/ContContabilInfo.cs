namespace UniTBv.AGSIS
{
    public class ContContabilInfo
    {
        private long _iD_ContContabil;
        private string _denumire;

        public ContContabilInfo()
        {
        }

        public ContContabilInfo(long iD_ContContabil, string denumire)
        {
        }

        public long ID_ContContabil
        {
            get { return _iD_ContContabil; }
            set { _iD_ContContabil = value; }
        }

        public string Denumire
        {
            get { return _denumire; }
            set { _denumire = value; }
        }
    }
}