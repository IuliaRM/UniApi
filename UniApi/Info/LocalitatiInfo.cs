using System;
namespace UniApi.Info
{
    public partial class LocalitatiInfo
    {
        #region "Private Members"

        #endregion
        #region "Constructors"

        public LocalitatiInfo()
        {
        }

        public LocalitatiInfo(string iD_Localitate, string localitate, string uRBAN_RURAL, string iD_Judet)
        {
            this.ID_Localitate = iD_Localitate;
            this.Localitate = localitate;
            this.URBAN_RURAL = uRBAN_RURAL;
            this.ID_Judet = iD_Judet;
        }
        #endregion

        #region "Public Properties"

        public string ID_Localitate { get; set; }

        public string Localitate { get; set; }

        public string URBAN_RURAL { get; set; }

        public string ID_Judet { get; set; }

		public int id_n_oras { get; set; }

        #endregion
    }
}
