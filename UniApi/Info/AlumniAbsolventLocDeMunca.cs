using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class AlumniAbsolventLocDeMuncaInfo: AlumniAbsolventInfo
    {
        public long ID_AbsolventLocDeMunca { get; set; }

        public string DenumireFirma { get; set; }

        public string Pozitie { get; set; }

        public int PozitieAnInceput { get; set; }

        public int PozitieAnSfarsit { get; set; }

        public string CodCOR { get; set; }

        public string DenumireCOR { get; set; }
    }
}
