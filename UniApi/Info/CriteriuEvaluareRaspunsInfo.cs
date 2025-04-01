using System;
    namespace UniApi.Info
{
    public partial class CriteriuEvaluareRaspunsInfo
    {
        #region "Private Members"

        #endregion
        #region "Constructors"

        public CriteriuEvaluareRaspunsInfo()
        {
        }

        public CriteriuEvaluareRaspunsInfo(long iD_CriteriuEvaluare, long iD_CriteriuEvaluareVarianteRaspuns, long iD_ChestionarEvaluat, string textRaspuns)
        {
            this.ID_CriteriuEvaluare = iD_CriteriuEvaluare;
            this.ID_CriteriuEvaluareVarianteRaspuns = iD_CriteriuEvaluareVarianteRaspuns;
            
			this.ID_ChestionarEvaluat = iD_ChestionarEvaluat;
            this.TextRaspuns = textRaspuns;
        }
        #endregion

        #region "Public Properties"

        public long ID_CriteriuEvaluareRaspuns { get; set; }

        public long ID_CriteriuEvaluare { get; set; }

        public long ID_CriteriuEvaluareVarianteRaspuns { get; set; }

        public long ID_ChestionarEvaluat { get; set; }

        public string TextRaspuns { get; set; }

        public DateTime DataModificare { get; set; }

        #endregion
    }
}