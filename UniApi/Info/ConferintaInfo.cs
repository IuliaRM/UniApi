using System;
namespace UniApi.Info
{
    public partial class ConferintaInfo
    {
        long _iD_Conferinta;
        int _anConferinta;
        string _denumireConferinta;
        string _uRLConferinta;
        DateTime _dataStartConferinta;
        DateTime _dataEndConferinta;
        string _locatieConferinta;
        int _numarParticipanti;
        int _numarLucrari;
        long _iD_TipConferinta;
		long _ID_FacultateOrganizatoare;

        public ConferintaInfo()
        {
        }

		public ConferintaInfo(long iD_Conferinta, int anConferinta, string denumireConferinta, string uRLConferinta, DateTime dataStartConferinta, DateTime dataEndConferinta, string locatieConferinta, int numarParticipanti, int numarLucrari, long iD_TipConferinta, long iD_FacultateOrganizatoare)
        {
            this.ID_Conferinta = iD_Conferinta;
            this.AnConferinta = anConferinta;
            this.DenumireConferinta = denumireConferinta;
            this.URLConferinta = uRLConferinta;
            this.DataStartConferinta = dataStartConferinta;
            this.DataEndConferinta = dataEndConferinta;
            this.LocatieConferinta = locatieConferinta;
            this.NumarParticipanti = numarParticipanti;
            this.NumarLucrari = numarLucrari;
            this.ID_TipConferinta = iD_TipConferinta;
			this.ID_FacultateOrganizatoare = iD_FacultateOrganizatoare;
        }

        public long ID_Conferinta
        {
            get { return _iD_Conferinta; }
            set { _iD_Conferinta = value; }
        }

        public int AnConferinta
        {
            get { return _anConferinta; }
            set { _anConferinta = value; }
        }

        public string DenumireConferinta
        {
            get { return _denumireConferinta; }
            set { _denumireConferinta = value; }
        }

        public string URLConferinta
        {
            get { return _uRLConferinta; }
            set { _uRLConferinta = value; }
        }

        public DateTime DataStartConferinta
        {
            get { return _dataStartConferinta; }
            set { _dataStartConferinta = value; }
        }

        public DateTime DataEndConferinta
        {
            get { return _dataEndConferinta; }
            set { _dataEndConferinta = value; }
        }

        public string LocatieConferinta
        {
            get { return _locatieConferinta; }
            set { _locatieConferinta = value; }
        }

        public int NumarParticipanti
        {
            get { return _numarParticipanti; }
            set { _numarParticipanti = value; }
        }

        public int NumarLucrari
        {
            get { return _numarLucrari; }
            set { _numarLucrari = value; }
        }

        public long ID_TipConferinta
        {
            get { return _iD_TipConferinta; }
            set { _iD_TipConferinta = value; }
        }

		public long ID_FacultateOrganizatoare
        {
            get { return _ID_FacultateOrganizatoare; }
			set { _ID_FacultateOrganizatoare = value; }
        }

		public string DenumireFacultateOrganizatoare { get; set; }

		public string ListaDomeniiFundamentaleSelectate { get; set; }
		
    }
}
