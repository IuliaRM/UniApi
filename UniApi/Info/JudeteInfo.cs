using System;
namespace UniApi.Info
{
    public partial class JudeteInfo
    {
        #region "Private Members"

        #endregion
        #region "Constructors"

        public JudeteInfo()
        {
        }

        public JudeteInfo(string iD_Judet, string simbol, string judet)
        {
            this.ID_Judet = iD_Judet;
            this.Simbol = simbol;
            this.Judet = judet;
        }
        #endregion

        #region "Public Properties"

        public string ID_Judet { get; set; }

        public string Simbol { get; set; }

        public string Judet { get; set; }

		public int id_n_judet { get; set; }

        #endregion
    }
}
