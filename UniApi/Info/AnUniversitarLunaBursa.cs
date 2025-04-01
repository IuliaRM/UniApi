using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniApi.Info
{
    public partial class AnUniversitarLunaBursaInfo
    {
        //ID_AnUnivLunaBursa, ID_AnUniv, NumarLuna, LunaInchisa, DataModificare, UserIDModificare, Luna, OrdineLuna, NrSemestru
        public long ID_AnUnivLunaBursa { get; set; }

        public long ID_AnUniv { get; set; }

        public int NumarLuna { get; set; }

        public bool LunaInchisa { get; set; }

        public DateTime DataModificare { get; set; }

        public int UserIDModificare { get; set; }

        public string Luna { get; set; }

        public int OrdineLuna { get; set; }

        public int NrSemestru { get; set; }
    }
}