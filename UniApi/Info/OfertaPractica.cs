using System;

namespace UniApi.Info
{
    public partial class OfertaPractica
    {

        public long ID_OfertaPractica { get; set; }

        public long ID_Firma { get; set; }

        public string DescriereOfertaPractica { get; set; }

        public DateTime PerioadaValabilitateStart { get; set; }

        public DateTime PerioadaValabilitateStop { get; set; }

        public string AdresaImagine { get; set; }

        public int NrLocuri { get; set; }

        public int ID_TipPractica { get; set; }

        public long ID_AnUniv { get; set; }

        public DateTime DataModificare { get; set; }

        public int Status { get; set; }

        public DateTime DataValabilitate { get; set; }

        public string NumeOferta { get; set; }
    }
}