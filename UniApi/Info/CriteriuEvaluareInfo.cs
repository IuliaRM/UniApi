using System;
using System.Collections.Generic;

namespace UniApi.Info
{
    public partial class CriteriuEvaluareInfo
    {
        
        #region "Constructors"

        public CriteriuEvaluareInfo()
        {
        }

        public CriteriuEvaluareInfo(long iD_CriteriuEvaluare, long iD_Chestionar, string intrebare, string modVizualizare, bool raspunsObligatoriu, string valoareMinimaRaspuns, string valoareMaximaRaspuns)
        {
            this.ID_CriteriuEvaluare = iD_CriteriuEvaluare;
            this.ID_Chestionar = iD_Chestionar;
            this.Intrebare = intrebare;
            this.ModVizualizare = modVizualizare;
            this.RaspunsObligatoriu = raspunsObligatoriu;
            this.ValoareMinimaRaspuns = valoareMinimaRaspuns;
            this.ValoareMaximaRaspuns = valoareMaximaRaspuns;
        }
        #endregion

        #region "Public Properties"

        public long ID_CriteriuEvaluare { get; set; }

        public long ID_Chestionar { get; set; }

        public string Intrebare { get; set; }

        public string ModVizualizare { get; set; }

        public bool RaspunsObligatoriu { get; set; }

        public string ValoareMinimaRaspuns { get; set; }

        public string ValoareMaximaRaspuns { get; set; }

        public List<CriteriuEvaluareVarianteRaspunsInfo> VarianteRaspuns
        { get; set; }

        #endregion
    }
}
