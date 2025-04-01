using System;
namespace UniApi.Info
{
    public partial class CriteriuEvaluareVarianteRaspunsInfo
    {
        #region "Private Members"

        #endregion
        #region "Constructors"

        public CriteriuEvaluareVarianteRaspunsInfo()
        {
        }

        public CriteriuEvaluareVarianteRaspunsInfo(long iD_CriteriuEvaluareVarianteRaspuns, long iD_CriteriuEvaluare, string textRaspuns, int valoareRaspuns)
        {
            this.ID_CriteriuEvaluareVarianteRaspuns = iD_CriteriuEvaluareVarianteRaspuns;
            this.ID_CriteriuEvaluare = iD_CriteriuEvaluare;
            this.TextRaspuns = textRaspuns;
            this.ValoareRaspuns = valoareRaspuns;
        }
        #endregion

        #region "Public Properties"

        public long ID_CriteriuEvaluareVarianteRaspuns { get; set; }

        public long ID_CriteriuEvaluare { get; set; }

        public string TextRaspuns { get; set; }

        public int ValoareRaspuns { get; set; }

        #endregion
    }
}
