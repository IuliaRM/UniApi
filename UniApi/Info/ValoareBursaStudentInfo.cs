using System;

namespace UniApi.Info
{
	public partial class ValoareBursaStudentInfo : System.ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public ValoareBursaStudentInfo()
		{
		}

		public ValoareBursaStudentInfo(long iD_ValoareBursa, long iD_Bursa, int numarLuna, decimal valoareBursa, long iD_AnUnivBursa)
		{
			ID_ValoareBursa = iD_ValoareBursa;
			ID_Bursa = iD_Bursa;
			NumarLuna = numarLuna;
			ValoareBursa = valoareBursa;
			ID_AnUnivBursa = iD_AnUnivBursa;
		}

		public long ID_ValoareBursa { get; set; }

		public long ID_Bursa { get; set; }

        public long ID_Student { get; set; }

        public int NumarLuna { get; set; }

		public decimal ValoareBursa { get; set; }

		public long ID_AnUnivBursa { get; set; }

		/// <summary>
		/// Pentru Toti studentii cu valoare True, valoare poate fi actualizata automat.
		/// </summary>
		public bool BursaSpecialaStudent { get; set; }

        public bool BursaPlatitaLuna { get; set; }

        public decimal BugetBursaRamas { get; set; }

        public DateTime DataModificare { get; set; }

        public int UserID { get; set; }
    }
}