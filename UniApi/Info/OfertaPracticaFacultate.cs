using System;

namespace UniApi.Info
{
    public partial class OfertaPracticaFacultate
    {
        public long ID_OfertaPracticaFacultate { get; set; }

        public long ID_OfertaPractica { get; set; }

        public long ID_Facultate { get; set; }

        public long ID_AnStudiu { get; set; }

        public long ID_Specializare { get; set; }

        public long ID_Domeniu { get; set; }

        public long ID_FC { get; set; }

        public long ID_FCForma { get; set; }

        public DateTime DataModificare { get; set; }

        public int Status { get; set; }

        public int NrLocuri { get; set; }
    }
}