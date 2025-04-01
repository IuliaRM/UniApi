using System;
namespace UniApi.Info
{
    public partial class SportNeprofilInfo
    {
        long _iD_SportNeprofil;
        long _iD_AnUniv;
        long _iD_Facultate;
        string _zi;
        string _interval;
        string _disciplina;
        string _locatie;
        string _cadruDidactic;
        int _nrLocuri;
        string _locIntilnire;

        public SportNeprofilInfo()
        {
        }

        public SportNeprofilInfo(long iD_SportNeprofil, long iD_AnUniv, long iD_Facultate, string zi, string interval, string disciplina, string locatie, string cadruDidactic, int nrLocuri, string locIntilnire)
        {
            this.ID_SportNeprofil = iD_SportNeprofil;
            this.ID_AnUniv = iD_AnUniv;
            this.ID_Facultate = iD_Facultate;
            this.Zi = zi;
            this.Interval = interval;
            this.Disciplina = disciplina;
            this.Locatie = locatie;
            this.CadruDidactic = cadruDidactic;
            this.NrLocuri = nrLocuri;
            this.LocIntilnire = locIntilnire;
        }

        public long ID_SportNeprofil
        {
            get { return _iD_SportNeprofil; }
            set { _iD_SportNeprofil = value; }
        }

        public long ID_AnUniv
        {
            get { return _iD_AnUniv; }
            set { _iD_AnUniv = value; }
        }

        public long ID_Facultate
        {
            get { return _iD_Facultate; }
            set { _iD_Facultate = value; }
        }

        public string Zi
        {
            get { return _zi; }
            set { _zi = value; }
        }

        public string Interval
        {
            get { return _interval; }
            set { _interval = value; }
        }

        public string Disciplina
        {
            get { return _disciplina; }
            set { _disciplina = value; }
        }

        public string Locatie
        {
            get { return _locatie; }
            set { _locatie = value; }
        }

        public string CadruDidactic
        {
            get { return _cadruDidactic; }
            set { _cadruDidactic = value; }
        }

        public int NrLocuri
        {
            get { return _nrLocuri; }
            set { _nrLocuri = value; }
        }

        public string LocIntilnire
        {
            get { return _locIntilnire; }
            set { _locIntilnire = value; }
        }

        public int NrLocuriOcupate { get; set; }

        public int NrLocuriDisponibile { get; set; }
    }
}
