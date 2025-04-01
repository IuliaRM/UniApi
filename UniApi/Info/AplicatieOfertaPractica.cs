using System;

namespace UniApi.Info
{
    public partial class AplicatieOfertaPractica
    {
        public AplicatieOfertaPractica()
		{
		}
        public long ID_AplicatieOfertaPractica { get; set; }

        public long ID_OfertaPracticaFacultate { get; set; }

        public long ID_Student { get; set; }

        public string AdresaFisier { get; set; }

        public DateTime DataAplicatieStudent { get; set; }

        public bool AcceptatFacultate { get; set; }

        public DateTime AcceptatFacultateData { get; set; }

        public bool AcceptatFirma { get; set; }

        public DateTime AcceptatFirmaData { get; set; }

        public bool ConfirmareStagiuFirma { get; set; }

        public string TitluProiectPractica { get; set; }

        public int ID_TipCalificativPractica { get; set; }

        public DateTime DataModificareCalificativ { get; set; }

        public long ID_MentorPracticaFirma { get; set; }
    }
}