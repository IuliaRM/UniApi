using System;

namespace UniApi.Info
{
    public partial class Firma
    {

        public Firma()
        { }

        public Firma(long iD_Firma, int userIDPortal, string denumireFirma, string numeDirector, string telefonDirector, string emailDirector, string numePersoanaContact, string telefonPersoanaContact, string emailPersoanaContact, string iD_Judet, DateTime dataModificare)
        {

            ID_Firma = iD_Firma;
            UserIDPortal = userIDPortal;
            DenumireFirma = denumireFirma;
            NumeDirector = numeDirector;
            TelefonDirector = telefonDirector;
            EmailDirector = emailDirector;
            NumePersoanaContact = numePersoanaContact;
            TelefonPersoanaContact = telefonPersoanaContact;
            EmailPersoanaContact = emailPersoanaContact;
            ID_Judet = iD_Judet;
            DataModificare = dataModificare;
        }

        public long ID_Firma { get; set; }

        public int UserIDPortal { get; set; }

        public string DenumireFirma { get; set; }

        public string NumeDirector { get; set; }

        public string TelefonDirector { get; set; }

        public string EmailDirector { get; set; }

        public string NumePersoanaContact { get; set; }

        public string TelefonPersoanaContact { get; set; }

        public string EmailPersoanaContact { get; set; }

        public string ID_Judet { get; set; }

        public DateTime DataModificare { get; set; }
    }
}