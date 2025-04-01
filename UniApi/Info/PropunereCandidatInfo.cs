using System;
namespace UniApi.Info
{
    public partial class PropunereCandidatInfo
    {
        long _id_PropunereCandidat;
        string _numeCandidat;
        string _prenumeCandidat;
        int _iD_n_Judet;
        int _iD_n_Localitate;
        string _strada;
        string _numar;
        string _bloc;
        string _scara;
        string _etaj;
        string _apartament;
        int _iD_N_Liceu;
        string _email;
        long _iD_FacultatePotrivitaCandidat;
        long _iD_StudentPropunere;
        long _iD_AnUniv;
        int _anUnivAdmitere;
        int _userIDPortal;

        public PropunereCandidatInfo()
        {
        }

        public PropunereCandidatInfo(long id_PropunereCandidat, string numeCandidat, string prenumeCandidat, int iD_N_Judet, int iD_N_Localitate, string strada, string numar, string bloc, string scara, string etaj, string apartament, string denumireLiceu, string email, long iD_FacultatePotrivitaCandidat, long iD_StudentPropunere, long iD_AnUniv, int anUnivAdmitere, int userIDPortal)
        {
            this.Id_PropunereCandidat = id_PropunereCandidat;
            this.NumeCandidat = numeCandidat;
            this.PrenumeCandidat = prenumeCandidat;
            this.ID_N_Judet = iD_N_Judet;
            this.ID_N_Localitate = iD_N_Localitate;
            this.Strada = strada;
            this.Numar = numar;
            this.Bloc = bloc;
            this.Scara = scara;
            this.Etaj = etaj;
            this.Apartament = apartament;
            this.DenumireLiceu = denumireLiceu;
            this.email = email;
            this.ID_FacultatePotrivitaCandidat = iD_FacultatePotrivitaCandidat;
            this.ID_StudentPropunere = iD_StudentPropunere;
            this.ID_AnUniv = iD_AnUniv;
            this.AnUnivAdmitere = anUnivAdmitere;
            this.UserIDPortal = userIDPortal;
        }

        public long Id_PropunereCandidat
        {
            get { return _id_PropunereCandidat; }
            set { _id_PropunereCandidat = value; }
        }

        public string NumeCandidat
        {
            get { return _numeCandidat; }
            set { _numeCandidat = value; }
        }

        public string PrenumeCandidat
        {
            get { return _prenumeCandidat; }
            set { _prenumeCandidat = value; }
        }

        public int ID_N_Judet
        {
            get { return _iD_n_Judet; }
            set { _iD_n_Judet = value; }
        }

        public int ID_N_Localitate
        {
            get { return _iD_n_Localitate; }
            set { _iD_n_Localitate = value; }
        }

        public string Strada
        {
            get { return _strada; }
            set { _strada = value; }
        }

        public string Numar
        {
            get { return _numar; }
            set { _numar = value; }
        }

        public string Bloc
        {
            get { return _bloc; }
            set { _bloc = value; }
        }

        public string Scara
        {
            get { return _scara; }
            set { _scara = value; }
        }

        public string Etaj
        {
            get { return _etaj; }
            set { _etaj = value; }
        }

        public string Apartament
        {
            get { return _apartament; }
            set { _apartament = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public long ID_FacultatePotrivitaCandidat
        {
            get { return _iD_FacultatePotrivitaCandidat; }
            set { _iD_FacultatePotrivitaCandidat = value; }
        }

        public long ID_StudentPropunere
        {
            get { return _iD_StudentPropunere; }
            set { _iD_StudentPropunere = value; }
        }

        public long ID_AnUniv
        {
            get { return _iD_AnUniv; }
            set { _iD_AnUniv = value; }
        }

        public int AnUnivAdmitere
        {
            get { return _anUnivAdmitere; }
            set { _anUnivAdmitere = value; }
        }

        public int UserIDPortal
        {
            get { return _userIDPortal; }
            set { _userIDPortal = value; }
        }

        public string DenumireJudet { get; set; }

        public string DenumireLocalitate { get; set; }

        public string Denumire { get; set; }

        public string NumeIntreg { get; set; }

        public string DenumireFacultate { get; set; }

        public string DenumireAnStudiu { get; set; }

        public string DenumireFacultatePotrivita { get; set; }

        public string DenumireLiceu { get; set; }

    }
}
