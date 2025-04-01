using System;

namespace UniApi.Info
{
	public partial class DetaliuPlanSemestruStudentInfo : DetaliuPlanSemestruInfo
	{
		public decimal NrMaximCredite { get; set; }

		public long ID_Nota { get; set; }

		public long ID_StudentNota { get; set; }

		public DateTime DataNota { get; set; }

		public bool UltimaNotaActiva { get; set; }

		public DateTime DataModificare { get; set; }

		public string Nota { get; set; }

		public bool Promovat { get; set; }

		public long ID_NotaOADPS { get; set; }

        public int ID_TipAcordareNota
        {
            get;
            set;
        }

        public String DenumireTipAcordareNota
        {
            get;
            set;
        }

        public bool MaterieStearsa { get; set; }

        public long ID_DetaliuPlanSemestruStudent { get; set; }
    }
}