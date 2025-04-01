using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniApi.Info
{
    public partial class SumaPerioadaAcordareBursaSpecializareInfo
    {
        public long ID_PerioadaAcordareBursaSpecializare { get; set; }

        public long ID_TipPerioadaAcordareBursa { get; set; }

        public long ID_Specializare { get; set; }

        public int NrZile { get; set; }

        public int NrZileAniTerminali { get; set; }

        public DateTime DataModificare { get; set; }

        public int OwnerID { get; set; }
    }
}