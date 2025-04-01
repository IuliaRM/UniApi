using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class AlumniSpecializareAbsolvitaInfo
    {
        public long ID_SpecializareAbsolvita { get; set; }
        public long ID_Facultate { get; set; }
        public long ID_TipFormaInv { get; set; }
        public long ID_TipCiclu { get; set; }
        public string DenumireSpecializareAbsolvita { get; set; }
        public int AnAbsolvire { get; set; }

        public string DenumireFacultate { get; set; }
        public string DenumireCicluInv { get; set; }
        public string DenumireFormaInv { get; set; }

        public long ID_Specializare { get; set; }

    }
}
