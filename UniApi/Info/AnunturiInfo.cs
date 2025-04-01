using System;
using System.ComponentModel;

namespace UniApi.Info
{
    public partial class AnunturiInfo
    {

        long _idAnunt;
        string _titluAnunt;
        string _mesajAnunt;
        DateTime _dataPostare;
        DateTime _dataExpirare;
        bool _anuntProfesori;
        bool _anuntStudenti;
        long _iD_Facultate;
        long _iD_FC;
        long _iD_FCForma;
        string _iD_Catedra;
        long _iD_AnUniv;
        long _iD_AnStudiu;
        long _iD_Domeniu;
        long _iD_Specializare;
        long _iD_Grupe;
        int _portalID;
        int _userID;

        DateTime _dataModificare;

        public AnunturiInfo()
        {
        }

        public AnunturiInfo(long idAnunt, string titluAnunt, string mesajAnunt, DateTime dataPostare, DateTime dataExpirare, bool anuntProfesori, bool anuntStudenti, long iD_Facultate, long iD_FC, long iD_FCForma,
        string iD_Catedra, long iD_AnUniv, long iD_AnStudiu, long iD_Domeniu, long iD_Specializare, long iD_Grupe, int portalID, int userID, DateTime dataModificare, string tipFisier, string caleFisier)
        {
            this.IdAnunt = idAnunt;
            this.TitluAnunt = titluAnunt;
            this.MesajAnunt = mesajAnunt;
            this.DataPostare = dataPostare;
            this.DataExpirare = dataExpirare;
            this.AnuntProfesori = anuntProfesori;
            this.AnuntStudenti = anuntStudenti;
            this.ID_Facultate = iD_Facultate;
            this.ID_Catedra = iD_Catedra;
            this._iD_FC = iD_FC;
            this.ID_FCForma = iD_FCForma;
            this.ID_AnUniv = iD_AnUniv;
            this.ID_AnStudiu = iD_AnStudiu;
            this.ID_Domeniu = iD_Domeniu;
            this.ID_Specializare = iD_Specializare;
            this.ID_Grupe = iD_Grupe;
            this.PortalID = portalID;
            this.UserID = userID;
            this.DataModificare = dataModificare;
            this.TipFisier = tipFisier;
            this.CaleFisier = caleFisier;
        }


        [DataObjectField(true)]
        public DateTime DataModificare
        {
            get { return _dataModificare; }
            set { _dataModificare = value; }
        }

        [DataObjectFieldAttribute(true)]
        public long ID_FC
        {
            get { return _iD_FC; }
            set { _iD_FC = value; }
        }

        [DataObjectFieldAttribute(true)]
        public long ID_FCForma
        {

            get { return _iD_FCForma; }
            set { _iD_FCForma = value; }
        }

        [DataObjectFieldAttribute(true)]
        public long IdAnunt
        {
            get { return _idAnunt; }
            set { _idAnunt = value; }
        }

        [DataObjectFieldAttribute(false)]
        public string TitluAnunt
        {
            get { return _titluAnunt; }
            set { _titluAnunt = value; }
        }

        [DataObjectFieldAttribute(false)]
        public string MesajAnunt
        {
            get { return _mesajAnunt; }
            set { _mesajAnunt = value; }
        }

        [DataObjectFieldAttribute(false)]
        public DateTime DataPostare
        {
            get { return _dataPostare; }
            set { _dataPostare = value; }
        }

        [DataObjectFieldAttribute(false)]
        public DateTime DataExpirare
        {
            get { return _dataExpirare; }
            set { _dataExpirare = value; }
        }

        [DataObjectFieldAttribute(false)]
        public bool AnuntProfesori
        {
            get { return _anuntProfesori; }
            set { _anuntProfesori = value; }
        }

        [DataObjectFieldAttribute(false)]
        public bool AnuntStudenti
        {
            get { return _anuntStudenti; }
            set { _anuntStudenti = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_Facultate
        {
            get { return _iD_Facultate; }
            set { _iD_Facultate = value; }
        }

        [DataObjectFieldAttribute(false)]
        public string ID_Catedra
        {
            get { return _iD_Catedra; }
            set { _iD_Catedra = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_AnUniv
        {
            get { return _iD_AnUniv; }
            set { _iD_AnUniv = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_AnStudiu
        {
            get { return _iD_AnStudiu; }
            set { _iD_AnStudiu = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_Domeniu
        {
            get { return _iD_Domeniu; }
            set { _iD_Domeniu = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_Specializare
        {
            get { return _iD_Specializare; }
            set { _iD_Specializare = value; }
        }

        [DataObjectFieldAttribute(false)]
        public long ID_Grupe
        {
            get { return _iD_Grupe; }
            set { _iD_Grupe = value; }
        }

        [DataObjectFieldAttribute(false)]
        public int PortalID
        {
            get { return _portalID; }
            set { _portalID = value; }
        }

        [DataObjectFieldAttribute(false)]
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }


        string _Facultate;
        public string Facultate
        {
            get { return _Facultate; }
            set { _Facultate = value; }
        }


        string _CicluInvatamant;
        public string CicluInvatamant
        {
            get { return _CicluInvatamant; }
            set { _CicluInvatamant = value; }
        }


        string _FormaInvatamant;
        public string FormaInvatamant
        {
            get { return _FormaInvatamant; }
            set { _FormaInvatamant = value; }
        }


        string _Domeniu;
        public string Domeniu
        {
            get { return _Domeniu; }
            set { _Domeniu = value; }
        }


        string _AnStudiu;
        public string AnStudiu
        {
            get { return _AnStudiu; }
            set { _AnStudiu = value; }
        }


        string _Specializare;
        public string Specializare
        {
            get { return _Specializare; }
            set { _Specializare = value; }
        }


        string _Grupa;
        public string Grupa
        {
            get { return _Grupa; }
            set { _Grupa = value; }
        }



        string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public string TipFisier { get; set; }
        public string CaleFisier { get; set; }

        public string NumeFisier { get; set; }

        public string DenumireFCFDSG { get; set; }

        public string VizibilStudProf { get; set; }

        public byte[] ContinutFisier { get; set; }

        public bool TrimitePrinEmail { get; set; }

        public bool AnuntProgramareExamene { get; set; }
        public bool TrimiteNotificareMobil { get; set; }
    }
}
