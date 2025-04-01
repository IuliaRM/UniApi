using System;
using UniApi.Info;

namespace UniApi.Info
{
    // Adaugă definiția enumerării dacă nu există deja în proiect
    public enum TipTaxaScolarizareStudentAnCurent
    {
        Bugetat,
        CuTaxa
    }

    public partial class CazareInfo : StudentAnUniversitarInfo
    {
        public long ID_Cazare { get; set; }
        public long ID_Camera { get; set; }
        public string NumarCamera { get; set; }
        public string DenumireCamin { get; set; }
        public DateTime DataDeCand { get; set; }
        public DateTime DataPanaCand { get; set; }
        public long ID_Camin { get; set; }

        private string _TipTaxaScolarizareStudent = string.Empty;

        public string TipTaxaScolarizareStudent
        {
            get
            {
                return _TipTaxaScolarizareStudent;
            }
            set
            {
                _TipTaxaScolarizareStudent = value;

                if (Enum.TryParse<TipTaxaScolarizareStudentAnCurent>(_TipTaxaScolarizareStudent, out var result))
                {
                    enumTipTaxaScolarizareStudent = result;
                }
                else
                {
                    enumTipTaxaScolarizareStudent = TipTaxaScolarizareStudentAnCurent.Bugetat;
                }
            }
        }

        public TipTaxaScolarizareStudentAnCurent enumTipTaxaScolarizareStudent { get; private set; }

        public long ID_TipTaxa { get; set; }
        public bool DepasitAnUniv { get; set; }
        public bool CazareExpirataLaDataCurenta { get; set; }
        public long ID_MotivScutiri { get; set; }
        public string UsernameCazat { get; set; }
        public bool CazareConfirmata { get; set; }
        public string Stare_sociala_speciala { get; set; }
        public string Situatie_medicala_speciala { get; set; }
        public string DenumireFormaFinantareInterna { get; set; }
        public long CerereTransferInID_Camin { get; set; }
        public DateTime CerereTransferInData { get; set; }
        public DateTime AdminCaminSursaDataAprobat { get; set; }
        public DateTime AdminCaminDestDataAprobat { get; set; }
        public long ID_CazareAnterioara { get; set; }
        public string SetariStudent { get; set; }
    }
}
