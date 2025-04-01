using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class AlumniAbsolventSpecializareAbsolvitaInfo : AlumniSpecializareAbsolvitaInfo
    {
        public long ID_AbsolventSpecializareAbsolvita { get; set; }

        public long ID_Absolvent { get; set; }

        public DateTime DataInregistrare { get; set; }

        public bool Validat { get; set; }

        public DateTime DataValidare { get; set; }

        public int UserIdValidare { get; set; }

        public string NumeAbsolvent { get; set; }
        public string PrenumeAbsolvent { get; set; }
        public string NumeDupaCasatorie { get; set; }
        public bool Casatorit { get; set; }
        public string Sex { get; set; }

        public string DetaliiContact { get; set; }

        public string CaleFoto { get; set; }

        public long ID_Student { get; set; }

    }
}
