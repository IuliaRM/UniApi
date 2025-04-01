using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniApi.Info
{
	public partial class DiplomaSupplementAdeverintaAbsolvireInfo
	{
		public string Nume { get; set; }
		public string Numecasatorie { get; set; }
		public string Initiale { get; set; }
		public string Prenume { get; set; }
		public string Annastere { get; set; }
		public string Lunanastere { get; set; }
		public string Zinastere { get; set; }
		public string Locnastere { get; set; }
		public string CNP { get; set; }
		public string Anulinmatricularii { get; set; }
		public string Sex { get; set; }
		public string PrenumeTata { get; set; }
		public string PrenumeMama { get; set; }
        public string DenumireCicluInv { get; set; }
		public decimal MediaMin { get; set; }
		public decimal MediaMax { get; set; }
		public decimal Media { get; set; }
		public string Total { get; set; }
		public string LocOcupat { get; set; }

		public decimal MedieFinala { get; set; }
        public string ProbeExamen { get; set; }
        public decimal NotaProba1 { get; set; }
        public decimal NotaProba2 { get; set; }
		public string DenumireSesiuneAbsolvire { get; set; }

		public string PerioadaAni { get; set; }
		public string CrediteECTS { get; set; }

        public bool StudentStrain { get; set; }
	}
}