using System;
using UniApi.Info;

namespace UniApi.Info
{
	public partial class BursaInfo : StudentInfo  //Cred ca trebuie StudentDatePersonale
	{
//		public long ID_Bursa { get; set; }

		public long ID_TipBursa { get; set; }

		/// <summary>
		/// Numarul Semestrului PENTRU CARE se acorda Bursa
		/// </summary>
		public long NumarSemestruBursa { get; set; }

		/// <summary>
		/// anul universitar in care se acorda bursa. Poate sa fie diferit de anul univ. curent
		/// </summary>
		public long ID_AnUnivBursa { get; set; }


		/// <summary>
		/// Daca bursa/media se calculeaza pentru un student la nivel de AnUniv. Trebuie luat in calcul si la calculul Punctajului
		/// </summary>
		public string NuSeCalculeazaBursa { get; set; }

		/// <summary>
		/// Daca studentul este Creditat (cu examene restante din anii precedenti)
		/// </summary>
		public string StudentCreditat { get; set; }

		/// <summary>
		/// Numarul Semestrului din care se ia in calcul Punctajul pentru acordarea bursei. Daca este -1, se ia in calcul AnulUniv
		/// </summary>
		public long NumarSemestruCalculPunctaj { get; set; }

		public decimal SumaCrediteToateMateriile { get; set; }

		/// <summary>
		/// Bursa se acorda studentului de la un anumit Domeniu, Specializare, AnStudiu pentru studentii din mai multi ani universitari
		/// </summary>
//		public long ID_Domeniu { get; set; }

		/// <summary>
		/// Bursa se acorda studentului de la un anumit Domeniu, Specializare, AnStudiu pentru studentii din mai multi ani universitari
		/// </summary>
//		public long ID_Specializare { get; set; }

		/// <summary>
		/// Bursa se acorda studentului de la un anumit Domeniu, Specializare, AnStudiu pentru studentii din mai multi ani universitari
		/// </summary>
//		public long ID_AnStudiu { get; set; }


		public decimal SumaCrediteMateriiPromovate { get; set; }
		public decimal SumaPuncteValoriceMateriiPromovate { get; set; }
		public decimal PunctajDacaIntegralist { get; set; }
		public decimal MedieDacaIntegralist { get; set; }

		public string TipBursa { get; set; }

		/// <summary>
		/// Suprascrie mediepunctaj calculata in functie de semestru. Daca <>0, aceasta are prioritate
		/// </summary>
		public decimal MediePunctajDeUtilizat { get; set; }

        /// <summary>
        /// tipul de bursa RMU asociat semestrului
        /// </summary>
        public string ID_N_BursaS1 { get; set; }
        public string ID_N_BursaS2 { get; set; }

        public string ListaAlteBurseS1 { get; set; }
        public string ListaAlteBurseS2 { get; set; }

        //        public string Repetent { get; set; }

        public bool NuSeCalculeazaMedia { get; set; }

        public string ObservatiiStudent { get; set; }

        public decimal MedieAdmitere { get; set; }

        public decimal BugetBursaDisponibil { get; set; }

        public decimal BugetBursaRamas { get; set; }

    }
}