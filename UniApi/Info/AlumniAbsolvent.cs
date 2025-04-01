using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class AlumniAbsolventInfo
    {
        public long ID_Absolvent { get; set; }
        public string NumeAbsolvent { get; set; }
        public string PrenumeAbsolvent { get; set; }
        public string NumeDupaCasatorie { get; set; }
        public bool Casatorit { get; set; }
        public string Sex { get; set; }

        public string DetaliiContact { get; set; }

        public string CaleFoto { get; set; }

        public DateTime DataInregistrare { get; set; }

        public string Username { get; set; }
    }
}
