using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniApi.Info
{
    public partial class AbsolventAlumniDTO
    {
        public string Nume { get; set; }

        public string Initiale { get; set; }

        public string Prenume { get; set; }

        public String Sex { get; set; }

        public string CNP { get; set; }

        public decimal MedieGenerala { get; set; }

        public DateTime DataNasterii { get; set; }

        public String Nationalitate { get; set; }

        public String Telefon { get; set; }

        public String Adresa { get; set; }

        public String Localitate { get; set; }

        public String Judet { get; set; }

        public String Email { get; set; }
    }
}