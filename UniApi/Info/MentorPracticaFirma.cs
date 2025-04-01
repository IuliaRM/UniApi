using System;

namespace UniApi.Info
{
    public partial class MentorPracticaFirma
    {

        public long ID_MentorPracticaFirma { get; set; }

        public long ID_Firma { get; set; }

        public string NumeMentorPracticaFirma { get; set; }

        public string EmailMentorPracticaFirma { get; set; }

        public string TelefonMentorPracticaFirma { get; set; }

        public DateTime DataModificare { get; set; }

        public int Status { get; set; }
    }
}