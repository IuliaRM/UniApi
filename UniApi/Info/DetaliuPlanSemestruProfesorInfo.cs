using System;
using System.ComponentModel;
namespace UniApi.Info
{
	public partial class DetaliuPlanSemestruProfesorInfo : DetaliuPlanSemestruInfo
	{
        public long ID_DetaliuPlanSemestru { get; set; }

		public decimal ProcentPozitiePost { get; set; }

		public long ID_Post { get; set; }

		public long ID_PostProfesor { get; set; }

		public string NrPozitie { get; set; }

		public decimal NrMaximCredite { get; set; }

		public decimal NrOrePredateCurs { get; set; }

		public decimal NrOrePredateSeminar { get; set; }

		public decimal NrOrePredateLaborator { get; set; }

		public decimal NrOrePredateProiect { get; set; }

		public long ID_DetaliuPlanSemestruProfesor { get; set; }

		public long ID_Profesor { get; set; }

		public long ID_Catedra { get; set; }

		public long ID_TipOrePredate { get; set; }

		public decimal NumarOrePredate { get; set; }

		public decimal NumarOrePredateFizice { get; set; }

		public string DenumireOrePredate { get; set; }

		public string Marca { get; set; }

		public string Nume { get; set; }

		public string NumeIntreg { get; set; }

		public string Prenume { get; set; }

		public string NumeScurt { get; set; }

		public int MoodleUserId { get; set; }

		public string MoodleIdNumber { get; set; }

		public string MoodleUsername { get; set; }

		public int UserID { get; set; }

		public string Username { get; set; }

		public string Email { get; set; }

		public string ParolaInitiala { get; set; }

		public string DenumireProgrameDeStudiuDinCuplaj { get; set; }

		public string ID_DetaliuPlanSemestru_ID_Cuplaj { get; set; }

		public long ID_Scenariu { get; set; }
		
		//ciprian 14.05.2012
		public string DenumireDisciplina{get; set;}

		//public string DenumireAnStudiu{get; set;}

        public bool Evaluat { get; set; }

        public string TipActivitate { get; set; }

        public string DenumireScurtaSpecializare { get; set; }

        public string DenumireSpecializare { get; set; }

        public string DenumireMetaSpecializare { get; set; }
    }
}
