

namespace UniApi.Info
{
    public partial class ProfesorMaterieInfo
    {
        public string Materie {get; set;}

        public string NumeIntreg { get; set; }

        public ProfesorMaterieInfo()
        {}

        public ProfesorMaterieInfo(string nume, string prenume, long id_DetaliuPlanSemestruProfesor, long id_CodEvaluare, string tipMaterie)
        {
            Nume = nume;
            Prenume = prenume;
            ID_DetaliuPlanSemestruProfesor = id_DetaliuPlanSemestruProfesor;
            TipOrePredate = tipMaterie;
            ID_CodEvaluare = id_CodEvaluare;
        }
        public long ID_CodEvaluare
        { get; set; }

        public long ID_DetaliuPlanSemestruProfesor
        { get; set; }

        public string Nume
        { get; set;}

        public string Prenume
        { get; set; }

        //public string DenumireGradDidactic
        //{ get; set; }

        public string TipOrePredate
        { get; set; }//C , A
    }
}
