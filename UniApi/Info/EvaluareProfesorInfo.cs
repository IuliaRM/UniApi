using System;
namespace UniApi.Info
{
    public partial class EvaluareProfesorInfo
    {

        public EvaluareProfesorInfo()
        {
        }

        public EvaluareProfesorInfo(long iD_EvaluareProfesor, long iD_Profesor, long iD_Specializare, long iD_AnUniv, int nrSemestru, int status, long iD_DetaliuPlanSemestru)
        {
            this.ID_EvaluareProfesor = iD_EvaluareProfesor;
            this.ID_Profesor = iD_Profesor;
            this.ID_Specializare = iD_Specializare;
            this.ID_AnUniv = iD_AnUniv;
            this.NrSemestru = nrSemestru;
            this.Status = status;
            this.ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
        }
        public long ID_DetaliuPlanSemestru { get; set; }

        public long ID_EvaluareProfesor
        {
            get; set;
        }

        public long ID_Profesor
        {
            get; set;
        }

        public long ID_Specializare
        {
            get; set;
        }
        public long ID_AnUniv
        {
            get; set;
        }

        public int NrSemestru
        {
            get; set;
        }

        public int Status
        {
            get; set;
        }

        public string DenumireFacultate { get; set; }
        public string DenumireSpecializare { get; set; }
        public string DenumireCicluInv { get; set; }
        public string DenumireAnStudiu { get; set; }
        public string Denumire { get; set; }
        public string NumeIntreg { get; set; }
        public string DenumireCatedraMaterie { get; set; }
        public string DenumireCatedraProfesor { get; set; }

        public string TipCursEvaluat { get; set; }
        public string DenumireFormaInv { get; set; }

        public int NumarChestionare { get; set; }
    }
}
