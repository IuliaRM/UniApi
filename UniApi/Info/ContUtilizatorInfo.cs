using System;
namespace UniApi.Info
{
    public partial class ContUtilizatorInfo
    {
        long _iD_ContUtilizator;
        string _nume;
        string _prenume;
        string _username;
        string _emailAlternativ;
        string _cNP;
        string _marca;
        string _tipUtilizator;
        string _tipIncadrare;
        string _tipPersonal;
        string _facultateServiciu;
        string _departamentCompartiment;
        string _functie;
        string _rolPrincipal;

        public ContUtilizatorInfo()
        {
        }

        public ContUtilizatorInfo(long iD_ContUtilizator, string nume, string prenume, string username, string emailAlternativ, string cNP, string marca, string tipUtilizator, string tipIncadrare, string tipPersonal, string facultateServiciu, string departamentCompartiment, string functie, string rolPrincipal)
        {
            this.ID_ContUtilizator = iD_ContUtilizator;
            this.Nume = nume;
            this.Prenume = prenume;
            this.Username = username;
            this.EmailAlternativ = emailAlternativ;
            this.CNP = cNP;
            this.Marca = marca;
            this.TipUtilizator = tipUtilizator;
            this.TipIncadrare = tipIncadrare;
            this.TipPersonal = tipPersonal;
            this.FacultateServiciu = facultateServiciu;
            this.DepartamentCompartiment = departamentCompartiment;
            this.Functie = functie;
            this.RolPrincipal = rolPrincipal;
        }

        public long ID_ContUtilizator
        {
            get { return _iD_ContUtilizator; }
            set { _iD_ContUtilizator = value; }
        }

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string EmailAlternativ
        {
            get { return _emailAlternativ; }
            set { _emailAlternativ = value; }
        }

        public string CNP
        {
            get { return _cNP; }
            set { _cNP = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string TipUtilizator
        {
            get { return _tipUtilizator; }
            set { _tipUtilizator = value; }
        }

        public string TipIncadrare
        {
            get { return _tipIncadrare; }
            set { _tipIncadrare = value; }
        }

        public string TipPersonal
        {
            get { return _tipPersonal; }
            set { _tipPersonal = value; }
        }

        public string FacultateServiciu
        {
            get { return _facultateServiciu; }
            set { _facultateServiciu = value; }
        }

        public string DepartamentCompartiment
        {
            get { return _departamentCompartiment; }
            set { _departamentCompartiment = value; }
        }

        public string Functie
        {
            get { return _functie; }
            set { _functie = value; }
        }

        public string RolPrincipal
        {
            get { return _rolPrincipal; }
            set { _rolPrincipal = value; }
        }
    }
}
