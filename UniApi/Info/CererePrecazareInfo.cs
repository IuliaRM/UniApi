using System;
using UniApi.Info;

namespace UniApi.Info
{
    public partial class CererePrecazareInfo : StudentInfoSuplimentare
    {
        public CererePrecazareInfo() { }

        public CererePrecazareInfo(long iD_CererePrecazare, long iD_Student, long doresteInID_Camera, decimal mediaPunctaj, int nrExameneCreditate, DateTime dataCerere, int status)
        {
            ID_CererePrecazare = iD_CererePrecazare;
            ID_Student = iD_Student;
            DoresteInID_Camera = doresteInID_Camera;
            MediaPunctaj = mediaPunctaj;
            NrExameneCreditate = nrExameneCreditate;
            DataCerere = dataCerere;
            Status = status;
        }
        public int Status { get; set; }

        public long ID_CererePrecazare { get; set; }
        public long DoresteInID_Camera { get; set; }
        public string NumarCamera { get; set; }
        public decimal MediaPunctaj { get; set; }
        public int NrExameneCreditate { get; set; }
        public DateTime DataCerere { get; set; }
        public string DenumireTipCiclu { get; set; }
        public long ID_Camin { get; set; }
        public bool StudentCazatDeja { get; set; }
        public string Stare_sociala_speciala { get; set; }
        public string Situatie_medicala_speciala { get; set; }
        public bool NuAConfirmatLaCazare { get; set; }
        public bool CazareExpirataLaDataCurenta { get; set; }

        // Adãugat pentru a rezolva eroarea
        public long ID_Camera { get; set; }
        public string Motiv { get; set; }
        public long ID_AnUniv { get; set; }
    }
}
