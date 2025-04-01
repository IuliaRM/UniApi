using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace UniApi.Info
{
    public partial class StudentInfo
    {
        private long _iD_Student;
        private string _nume;
        private string _initiale;
        private string _prenume;
        private long _iD_TipActIdentitate;
        private string _cNP;
        private string _numar_serie;
        private DateTime _dataNastere;
        private string _prenumeTata;
        private string _prenumeMama;
        private string _NumeCasatorie;
        private string _telefon;
        private string _email;
        private string _web;
        private string _adresa;
        private long _ID_TipTara;
        private long _iD_Nationalitate;
        private long _iD_TipCetatenie;
        private long _iD_ADouaCetatenie;
        private long _iD_TipStareCivila;
        private long _iD_TipSituatieMilitara;
        private string _sex;
        private long _iD_TipBanca;
        private string _contBanca;
        private double _venitPerFamilie;
        private double _alteVenituri;
        private string _numeLiceuAbsolvit;
        private double _notaBacalaureat;
        private string _judet;
        private string _localitate;
        private string _judetNastere;
        private string _localitateNastere;
        private bool _orfanDeUnParinte;
        private bool _orfanAmbiiParinti;
        private long _iD_Utilizator;
        private DateTime _dataModificare;
        private int _status;
        private string _dmy_facultate;
        private string _dmy_domeniu;
        private string _dmy_specializare;
        private string _dmy_grupa;
        private int _dmy_taxa;
        private string _dmy_anstudiu;
        private string _dmy_anuniv;
        private long _dmy_ORG_UNIT_ID_PK;
        private int _portalID;
        private Guid _ID_CandidatFacultateAdmitere;


        public StudentInfo()
        {
        }

        public StudentInfo(long iD_Student, string nume, string initiale, string prenume, long iD_TipActIdentitate, string cNP, string numar_serie, DateTime dataNastere, string prenumeTata, string prenumeMama, string telefon, string email, string web, string adresa, long iD_Nationalitate, long iD_TipCetatenie, long iD_ADouaCetatenie, long iD_TipStareCivila, long iD_TipSituatieMilitara, string sex, long iD_TipBanca, string contBanca, double venitPerFamilie, double alteVenituri, string numeLiceuAbsolvit, double notaBacalaureat, string judet, string localitate, bool orfanDeUnParinte, bool orfanAmbiiParinti, long iD_Utilizator, DateTime dataModificare, int status, string dmy_facultate, string dmy_domeniu, string dmy_specializare, string dmy_grupa, int dmy_taxa, string dmy_anstudiu, string dmy_anuniv, long dmy_ORG_UNIT_ID_PK, string _DenumireFormaInv, int portalID, Guid _ID_CandidatFacultateAdmitere)
        {

        }

        private string _DenumireFormaInv;
        public string DenumireFormaInv
        {
            get
            {
                return _DenumireFormaInv;
            }
            set
            {
                _DenumireFormaInv = value;
            }
        }

        public Guid ID_CandidatFacultateAdmitere
        {
            get
            {
                return _ID_CandidatFacultateAdmitere;
            }
            set
            {
                _ID_CandidatFacultateAdmitere = value;
            }
        }

        public long ID_Student
        {
            get
            {
                return _iD_Student;
            }
            set
            {
                _iD_Student = value;
            }
        }

        public string Nume
        {
            get
            {
                return _nume;
            }
            set
            {
                _nume = value;
            }
        }

        public string Initiale
        {
            get
            {
                return _initiale;
            }
            set
            {
                _initiale = value;
            }
        }

        public string Prenume
        {
            get
            {
                return _prenume;
            }
            set
            {
                _prenume = value;
            }
        }

        public long ID_TipActIdentitate
        {
            get
            {
                return _iD_TipActIdentitate;
            }
            set
            {
                _iD_TipActIdentitate = value;
            }
        }

        public string CNP
        {
            get
            {
                return _cNP;
            }
            set
            {
                _cNP = value;
            }
        }

        public string Numar_serie
        {
            get
            {
                return _ACT_IDENTITATE_NUMAR + " " + _ACT_IDENTITATE_SERIE;
            }
            set
            {
                _numar_serie = value;
            }
        }

        public DateTime DataNastere
        {
            get
            {
                return _dataNastere;
            }
            set
            {
                _dataNastere = value;
            }
        }

        public string PrenumeTata
        {
            get
            {
                return _prenumeTata;
            }
            set
            {
                _prenumeTata = value;
            }
        }

        public string PrenumeMama
        {
            get
            {
                return _prenumeMama;
            }
            set
            {
                _prenumeMama = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                _telefon = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        public string Web
        {
            get
            {
                return _web;
            }
            set
            {
                _web = value;
            }
        }

        public string Adresa
        {
            get
            {
                return _adresa;
            }
            set
            {
                _adresa = value;
            }
        }

        public long ID_TipTara
        {
            get
            {
                return _ID_TipTara;
            }
            set
            {
                _ID_TipTara = value;
            }
        }

        private string _DenumireTara;

        public string DenumireTara
        {
            get
            {
                return _DenumireTara;
            }
            set
            {
                _DenumireTara = value;
            }
        }


        public long ID_Nationalitate
        {
            get
            {
                return _iD_Nationalitate;
            }
            set
            {
                _iD_Nationalitate = value;
            }
        }

        public long ID_TipCetatenie
        {
            get
            {
                return _iD_TipCetatenie;
            }
            set
            {
                _iD_TipCetatenie = value;
            }
        }

        public long ID_ADouaCetatenie
        {
            get
            {
                return _iD_ADouaCetatenie;
            }
            set
            {
                _iD_ADouaCetatenie = value;
            }
        }

        public long ID_TipStareCivila
        {
            get
            {
                return _iD_TipStareCivila;
            }
            set
            {
                _iD_TipStareCivila = value;
            }
        }

        public long ID_TipSituatieMilitara
        {
            get
            {
                return _iD_TipSituatieMilitara;
            }
            set
            {
                _iD_TipSituatieMilitara = value;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }

        public long ID_TipBanca
        {
            get
            {
                return _iD_TipBanca;
            }
            set
            {
                _iD_TipBanca = value;
            }
        }

        public string ContBanca
        {
            get
            {
                return _contBanca;
            }
            set
            {
                _contBanca = value;
            }
        }

        public double VenitPerFamilie
        {
            get
            {
                return _venitPerFamilie;
            }
            set
            {
                _venitPerFamilie = value;
            }
        }

        public double AlteVenituri
        {
            get
            {
                return _alteVenituri;
            }
            set
            {
                _alteVenituri = value;
            }
        }

        public string NumeLiceuAbsolvit
        {
            get
            {
                return _numeLiceuAbsolvit;
            }
            set
            {
                _numeLiceuAbsolvit = value;
            }
        }

        public double NotaBacalaureat
        {
            get
            {
                return _notaBacalaureat;
            }
            set
            {
                _notaBacalaureat = value;
            }
        }

        public string Judet
        {
            get
            {
                return _judet;
            }
            set
            {
                _judet = value;
            }
        }

        public string Localitate
        {
            get
            {
                return _localitate;
            }
            set
            {
                _localitate = value;
            }
        }

        public bool OrfanDeUnParinte
        {
            get
            {
                return _orfanDeUnParinte;
            }
            set
            {
                _orfanDeUnParinte = value;
            }
        }

        public bool OrfanAmbiiParinti
        {
            get
            {
                return _orfanAmbiiParinti;
            }
            set
            {
                _orfanAmbiiParinti = value;
            }
        }

        public long ID_Utilizator
        {
            get
            {
                return _iD_Utilizator;
            }
            set
            {
                _iD_Utilizator = value;
            }
        }

        public DateTime DataModificare
        {
            get
            {
                return _dataModificare;
            }
            set
            {
                _dataModificare = value;
            }
        }

        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public string dmy_facultate
        {
            get
            {
                return _dmy_facultate;
            }
            set
            {
                _dmy_facultate = value;
            }
        }

        public string dmy_domeniu
        {
            get
            {
                return _dmy_domeniu;
            }
            set
            {
                _dmy_domeniu = value;
            }
        }

        public string dmy_specializare
        {
            get
            {
                return _dmy_specializare;
            }
            set
            {
                _dmy_specializare = value;
            }
        }

        public string dmy_grupa
        {
            get
            {
                return _dmy_grupa;
            }
            set
            {
                _dmy_grupa = value;
            }
        }

        public int dmy_taxa
        {
            get
            {
                return _dmy_taxa;
            }
            set
            {
                _dmy_taxa = value;
            }
        }

        public string dmy_anstudiu
        {
            get
            {
                return _dmy_anstudiu;
            }
            set
            {
                _dmy_anstudiu = value;
            }
        }

        public string dmy_anuniv
        {
            get
            {
                return _dmy_anuniv;
            }
            set
            {
                _dmy_anuniv = value;
            }
        }

        public long dmy_ORG_UNIT_ID_PK
        {
            get
            {
                return _dmy_ORG_UNIT_ID_PK;
            }
            set
            {
                _dmy_ORG_UNIT_ID_PK = value;
            }
        }

        public int PortalID
        {
            get
            {
                return _portalID;
            }
            set
            {
                _portalID = value;
            }
        }

        private string _NumeIntreg;

        public string NumeIntreg
        {
            get
            {
                return _NumeIntreg;
            }
            set
            {
                _NumeIntreg = value;
            }
        }

        private int _promovat;
        private bool _exmatriculat;

        public int Promovat
        {
            get
            {
                return _promovat;
            }
            set
            {
                _promovat = value;
            }
        }

        public bool Exmatriculat
        {
            get
            {
                return _exmatriculat;
            }
            set
            {
                _exmatriculat = value;
            }
        }


        private string _NrMatricol;

        public string NrMatricol
        {
            get
            {
                return _NrMatricol;
            }
            set
            {
                _NrMatricol = value;
            }
        }

        public string JudetNastere
        {
            get
            {
                return _judetNastere;
            }
            set
            {
                _judetNastere = value;
            }
        }

        public string LocalitateNastere
        {
            get
            {
                return _localitateNastere;
            }
            set
            {
                _localitateNastere = value;
            }
        }

        public string NumeCasatorie
        {
            get
            {
                return _NumeCasatorie;
            }
            set
            {
                _NumeCasatorie = value;
            }
        }


        private int _MoodleUserId;

        public int MoodleUserId
        {
            get
            {
                return _MoodleUserId;
            }
            set
            {
                _MoodleUserId = value;
            }
        }


        private string _MoodleIdNumber;

        public string MoodleIdNumber
        {
            get
            {
                return _MoodleIdNumber;
            }
            set
            {
                _MoodleIdNumber = value;
            }
        }


        private string _MoodleUsername;

        public string MoodleUsername
        {
            get
            {
                return _MoodleUsername;
            }
            set
            {
                _MoodleUsername = value;
            }
        }


        private int _UserID;

        public int UserID
        {
            get
            {
                return _UserID;
            }
            set
            {
                _UserID = value;
            }
        }


        private long _ID_Domeniu;

        public long ID_Domeniu
        {
            get
            {
                return _ID_Domeniu;
            }
            set
            {
                _ID_Domeniu = value;
            }
        }


        private long _ID_Specializare;

        public long ID_Specializare
        {
            get
            {
                return _ID_Specializare;
            }
            set
            {
                _ID_Specializare = value;
            }
        }


        private long _ID_AnStudiu;

        public long ID_AnStudiu
        {
            get
            {
                return _ID_AnStudiu;
            }
            set
            {
                _ID_AnStudiu = value;
            }
        }


        private string _DenumireDomeniu;

        public string DenumireDomeniu
        {
            get
            {
                return _DenumireDomeniu;
            }
            set
            {
                _DenumireDomeniu = value;
            }
        }


        private string _DenumireSpecializare;

        public string DenumireSpecializare
        {
            get
            {
                return _DenumireSpecializare;
            }
            set
            {
                _DenumireSpecializare = value;
            }
        }


        private string _DenumireAnStudiu;

        public string DenumireAnStudiu
        {
            get
            {
                return _DenumireAnStudiu;
            }
            set
            {
                _DenumireAnStudiu = value;
            }
        }


        private long _ID_FC;

        public long ID_FC
        {
            get
            {
                return _ID_FC;
            }
            set
            {
                _ID_FC = value;
            }
        }


        private long _ID_FCForma;

        public long ID_FCForma
        {
            get
            {
                return _ID_FCForma;
            }
            set
            {
                _ID_FCForma = value;
            }
        }


        private long _ID_AnUniv;

        public long ID_AnUniv
        {
            get
            {
                return _ID_AnUniv;
            }
            set
            {
                _ID_AnUniv = value;
            }
        }


        private long _ID_Facultate;

        public long ID_Facultate
        {
            get
            {
                return _ID_Facultate;
            }
            set
            {
                _ID_Facultate = value;
            }
        }


        private long _ID_Grupe;

        public long ID_Grupe
        {
            get
            {
                return _ID_Grupe;
            }
            set
            {
                _ID_Grupe = value;
            }
        }


        private string _DenumireGrupa;

        public string DenumireGrupa
        {
            get
            {
                return _DenumireGrupa;
            }
            set
            {
                _DenumireGrupa = value;
            }
        }

        public string Facultate_Domeniu_Specializare_Student
        {
            get
            {
                return _ID_Facultate.ToString() + "_" + _ID_Domeniu.ToString() + "_" + _ID_Specializare.ToString() + "_" + _iD_Student.ToString();
            }
            set
            {

            }
        }

        private long _ID_Bursa;

        public long ID_Bursa
        {
            get
            {
                return _ID_Bursa;
            }
            set
            {
                _ID_Bursa = value;
            }
        }


        private string _DenumireBanca;

        public string DenumireBanca
        {
            get
            {
                return _DenumireBanca;
            }
            set
            {
                _DenumireBanca = value;
            }
        }


        private string _DenumireTipBursa;

        public string DenumireTipBursa
        {
            get
            {
                return _DenumireTipBursa;
            }
            set
            {
                _DenumireTipBursa = value;
            }
        }

        private string _DenumireCetatenie;

        public string DenumireCetatenie
        {
            get
            {
                return _DenumireCetatenie;
            }
            set
            {
                _DenumireCetatenie = value;
            }
        }


        private decimal _ValoareFinalaBursaStudent;
        public decimal ValoareFinalaBursaStudent
        {
            get
            {
                return _ValoareFinalaBursaStudent;
            }
            set
            {
                _ValoareFinalaBursaStudent = value;
            }
        }

        private decimal _ValoareTipBursa;
        /// <summary>
        /// Valoarea intreaga a bursei pentru studentii care **au probleme medicale/de sanatate**
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public decimal ValoareTipBursa
        {
            get
            {
                return _ValoareTipBursa;
            }
            set
            {
                _ValoareTipBursa = value;
            }
        }

        private decimal _ValoareTipBursaDiminuata;
        /// <summary>
        /// Valoare diminuata pe vacante pt. studentii care NU au probleme medicale/de sanatate
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public decimal ValoareTipBursaDiminuata
        {
            get
            {
                return _ValoareTipBursaDiminuata;
            }
            set
            {
                _ValoareTipBursaDiminuata = value;
            }
        }


        private decimal _ValoareBursaStudent;
        /// <summary>
        /// Valoare speciala bursa. Daca e setata, inlocuieste celelalte valori
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public decimal ValoareBursaStudent
        {
            get
            {
                return _ValoareBursaStudent;
            }
            set
            {
                _ValoareBursaStudent = value;
            }
        }


        private string _DenumireFacultate;

        public string DenumireFacultate
        {
            get
            {
                return _DenumireFacultate;
            }
            set
            {
                _DenumireFacultate = value;
            }
        }


        private string _TipTaxa;

        public string TipTaxa
        {
            get
            {
                return _TipTaxa;
            }
            set
            {
                _TipTaxa = value;
            }
        }


        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private string _parolainitiala;

        public string ParolaInitiala
        {
            get
            {
                return _parolainitiala;
            }
            set
            {
                _parolainitiala = value;
            }
        }


        private decimal _MedieAdmitere;

        public decimal MedieAdmitere
        {
            get
            {
                return _MedieAdmitere;
            }
            set
            {
                _MedieAdmitere = value;
            }
        }


        private long _ID_TipCiclu;

        public long ID_TipCiclu
        {
            get
            {
                return _ID_TipCiclu;
            }
            set
            {
                _ID_TipCiclu = value;
            }
        }


        private long _ID_TipFormaInv;

        public long ID_TipFormaInv
        {
            get
            {
                return _ID_TipFormaInv;
            }
            set
            {
                _ID_TipFormaInv = value;
            }
        }


        private string _DenumireDS;

        public string DenumireDS
        {
            get
            {
                return _DenumireDS;
            }
            set
            {
                _DenumireDS = value;
            }
        }


        private string _CodCuloareText;

        public string CodCuloareText
        {
            get
            {
                return _CodCuloareText;
            }
            set
            {
                _CodCuloareText = value;
            }
        }


        private string _CodCuloareBG;

        public string CodCuloareBG
        {
            get
            {
                return _CodCuloareBG;
            }
            set
            {
                _CodCuloareBG = value;
            }
        }

        private string _DenumireJudet;
        public string DenumireJudet
        {
            get
            {
                return _DenumireJudet;
            }
            set
            {
                _DenumireJudet = value;
            }
        }


        private string _DenumireLocalitate;
        public string DenumireLocalitate
        {
            get
            {
                return _DenumireLocalitate;
            }
            set
            {
                _DenumireLocalitate = value;
            }
        }

        private string _DenumireJudetNastere;
        public string DenumireJudetNastere
        {
            get
            {
                return _DenumireJudetNastere;
            }
            set
            {
                _DenumireJudetNastere = value;
            }
        }

        private string _DenumireLocalitateNastere;
        public string DenumireLocalitateNastere
        {
            get
            {
                return _DenumireLocalitateNastere;
            }
            set
            {
                _DenumireLocalitateNastere = value;
            }
        }

        private string _AltaAdresa;
        public string AltaAdresa
        {
            get
            {
                return _AltaAdresa;
            }
            set
            {
                _AltaAdresa = value;
            }
        }


        private bool _PersoanaCuDizabilitati;
        public bool PersoanaCuDizabilitati
        {
            get
            {
                return _PersoanaCuDizabilitati;
            }
            set
            {
                _PersoanaCuDizabilitati = value;
            }
        }


        private decimal _id_liceuAbsolvit;
        public decimal id_liceuAbsolvit
        {
            get
            {
                return _id_liceuAbsolvit;
            }
            set
            {
                _id_liceuAbsolvit = value;
            }
        }


        private string _id_localitateliceuAbsolvit;
        public string id_localitateliceuAbsolvit
        {
            get
            {
                return _id_localitateliceuAbsolvit;
            }
            set
            {
                _id_localitateliceuAbsolvit = value;
            }
        }

        private string _id_judetliceuAbsolvit;
        public string id_judetliceuAbsolvit
        {
            get
            {
                return _id_judetliceuAbsolvit;
            }
            set
            {
                _id_judetliceuAbsolvit = value;
            }
        }


        private int _AnAbsolvireLiceu;
        public int AnAbsolvireLiceu
        {
            get
            {
                return _AnAbsolvireLiceu;
            }
            set
            {
                _AnAbsolvireLiceu = value;
            }
        }


        private string _FormaInvLiceuAbsolvit;
        public string FormaInvLiceuAbsolvit
        {
            get
            {
                return _FormaInvLiceuAbsolvit;
            }
            set
            {
                _FormaInvLiceuAbsolvit = value;
            }
        }


        private long _id_tiptaranastere;
        public long id_tiptaranastere
        {
            get
            {
                return _id_tiptaranastere;
            }
            set
            {
                _id_tiptaranastere = value;
            }
        }


        private long _id_tiptaraliceu;
        public long id_tiptaraliceu
        {
            get
            {
                return _id_tiptaraliceu;
            }
            set
            {
                _id_tiptaraliceu = value;
            }
        }


        private string _ACT_IDENTITATE_SERIE;
        public string ACT_IDENTITATE_SERIE
        {
            get
            {
                return _ACT_IDENTITATE_SERIE;
            }
            set
            {
                _ACT_IDENTITATE_SERIE = value;
            }
        }


        private string _ACT_IDENTITATE_NUMAR;
        public string ACT_IDENTITATE_NUMAR
        {
            get
            {
                return _ACT_IDENTITATE_NUMAR;
            }
            set
            {
                _ACT_IDENTITATE_NUMAR = value;
            }
        }


        private string _ELIBERAT_DE;
        public string ELIBERAT_DE
        {
            get
            {
                return _ELIBERAT_DE;
            }
            set
            {
                _ELIBERAT_DE = value;
            }
        }


        private DateTime _ELIBERAT_DATA;
        public DateTime ELIBERAT_DATA
        {
            get
            {
                return _ELIBERAT_DATA;
            }
            set
            {
                _ELIBERAT_DATA = value;
            }
        }


        private DateTime _VALABILITATE_PANA_LA;
        public DateTime VALABILITATE_PANA_LA
        {
            get
            {
                return _VALABILITATE_PANA_LA;
            }
            set
            {
                _VALABILITATE_PANA_LA = value;
            }
        }


        private string _ETNIA;
        public string ETNIA
        {
            get
            {
                return _ETNIA;
            }
            set
            {
                _ETNIA = value;
            }
        }


        private long _STUDII_LICEU_ID_DOMENIUPROFIL;
        public long STUDII_LICEU_ID_DOMENIUPROFIL
        {
            get
            {
                return _STUDII_LICEU_ID_DOMENIUPROFIL;
            }
            set
            {
                _STUDII_LICEU_ID_DOMENIUPROFIL = value;
            }
        }


        private int _STUDII_LICEU_DURATA;
        public int STUDII_LICEU_DURATA
        {
            get
            {
                return _STUDII_LICEU_DURATA;
            }
            set
            {
                _STUDII_LICEU_DURATA = value;
            }
        }


        private long _STUDII_LICEU_ID_FORMA_INV;
        public long STUDII_LICEU_ID_FORMA_INV
        {
            get
            {
                return _STUDII_LICEU_ID_FORMA_INV;
            }
            set
            {
                _STUDII_LICEU_ID_FORMA_INV = value;
            }
        }


        private long _DATE_DIPLOMA_ID_TIP;
        public long DATE_DIPLOMA_ID_TIP
        {
            get
            {
                return _DATE_DIPLOMA_ID_TIP;
            }
            set
            {
                _DATE_DIPLOMA_ID_TIP = value;
            }
        }


        private string _DATE_DIPLOMA_SERIA;
        public string DATE_DIPLOMA_SERIA
        {
            get
            {
                return _DATE_DIPLOMA_SERIA;
            }
            set
            {
                _DATE_DIPLOMA_SERIA = value;
            }
        }


        private string _DATE_DIPLOMA_NUMAR;
        public string DATE_DIPLOMA_NUMAR
        {
            get
            {
                return _DATE_DIPLOMA_NUMAR;
            }
            set
            {
                _DATE_DIPLOMA_NUMAR = value;
            }
        }


        private int _DATE_DIPLOMA_ANUL;
        public int DATE_DIPLOMA_ANUL
        {
            get
            {
                return _DATE_DIPLOMA_ANUL;
            }
            set
            {
                _DATE_DIPLOMA_ANUL = value;
            }
        }


        private string _ALTE_OBSERVATII;
        public string ALTE_OBSERVATII
        {
            get
            {
                return _ALTE_OBSERVATII;
            }
            set
            {
                _ALTE_OBSERVATII = value;
            }
        }


        private long _DATE_DIPLOMA_ID_EMITENT;
        public long DATE_DIPLOMA_ID_EMITENT
        {
            get
            {
                return _DATE_DIPLOMA_ID_EMITENT;
            }
            set
            {
                _DATE_DIPLOMA_ID_EMITENT = value;
            }
        }


        private long _ID_STARE_SOCIALA_SPECIALA;
        public long ID_STARE_SOCIALA_SPECIALA
        {
            get
            {
                return _ID_STARE_SOCIALA_SPECIALA;
            }
            set
            {
                _ID_STARE_SOCIALA_SPECIALA = value;
            }
        }

        private bool _Repetent;
        public bool Repetent
        {
            get
            {
                return _Repetent;
            }
            set
            {
                _Repetent = value;
            }
        }

        private DateTime _DataActualizareContBanca;
        public DateTime DataActualizareContBanca
        {
            get
            {
                return _DataActualizareContBanca;
            }
            set
            {
                _DataActualizareContBanca = value;
            }
        }

        private long _ID_SITUATIE_MEDICALA_SPECIALA;
        public long ID_SITUATIE_MEDICALA_SPECIALA
        {
            get
            {
                return _ID_SITUATIE_MEDICALA_SPECIALA;
            }
            set
            {
                _ID_SITUATIE_MEDICALA_SPECIALA = value;
            }
        }

        private int _ID_N_Forma_Finantare_RMU;
        public int ID_N_Forma_Finantare_RMU
        {
            get
            {
                return _ID_N_Forma_Finantare_RMU;
            }
            set
            {
                _ID_N_Forma_Finantare_RMU = value;
            }
        }

        private int _ID_N_Forma_Finantare_Intern;
        public int ID_N_Forma_Finantare_Intern
        {
            get
            {
                return _ID_N_Forma_Finantare_Intern;
            }
            set
            {
                _ID_N_Forma_Finantare_Intern = value;
            }
        }

        private int _ID_N_SITUATIE_PROFESIONALA;
        public int ID_N_SITUATIE_PROFESIONALA
        {
            get
            {
                return _ID_N_SITUATIE_PROFESIONALA;
            }
            set
            {
                _ID_N_SITUATIE_PROFESIONALA = value;
            }
        }

        private int _ID_N_SITUATIE_SCOLARA;
        public int ID_N_SITUATIE_SCOLARA
        {
            get
            {
                return _ID_N_SITUATIE_SCOLARA;
            }
            set
            {
                _ID_N_SITUATIE_SCOLARA = value;
            }
        }


        private double _MediaAnCuFacultative;
        public double MediaAnCuFacultative
        {
            get
            {
                return _MediaAnCuFacultative;
            }
            set
            {
                _MediaAnCuFacultative = value;
            }
        }

        private double _MediaAnFaraFacultative;
        public double MediaAnFaraFacultative
        {
            get
            {
                return _MediaAnFaraFacultative;
            }
            set
            {
                _MediaAnFaraFacultative = value;
            }
        }

        private int _SumaCrediteMateriiPromovate_S1;
        public int SumaCrediteMateriiPromovate_S1
        {
            get
            {
                return _SumaCrediteMateriiPromovate_S1;
            }
            set
            {
                _SumaCrediteMateriiPromovate_S1 = value;
            }
        }

        private int _SumaPuncteValoriceMateriiPromovate_S1;
        public int SumaPuncteValoriceMateriiPromovate_S1
        {
            get
            {
                return _SumaPuncteValoriceMateriiPromovate_S1;
            }
            set
            {
                _SumaPuncteValoriceMateriiPromovate_S1 = value;
            }
        }

        private int _PunctajDacaIntegralist_S1;
        public int PunctajDacaIntegralist_S1
        {
            get
            {
                return _PunctajDacaIntegralist_S1;
            }
            set
            {
                _PunctajDacaIntegralist_S1 = value;
            }
        }

        private double _MedieDacaIntegralist_S1;
        public double MedieDacaIntegralist_S1
        {
            get
            {
                return _MedieDacaIntegralist_S1;
            }
            set
            {
                _MedieDacaIntegralist_S1 = value;
            }
        }


        private int _SumaCrediteMateriiPromovate_S2;
        public int SumaCrediteMateriiPromovate_S2
        {
            get
            {
                return _SumaCrediteMateriiPromovate_S2;
            }
            set
            {
                _SumaCrediteMateriiPromovate_S2 = value;
            }
        }

        private int _SumaPuncteValoriceMateriiPromovate_S2;
        public int SumaPuncteValoriceMateriiPromovate_S2
        {
            get
            {
                return _SumaPuncteValoriceMateriiPromovate_S2;
            }
            set
            {
                _SumaPuncteValoriceMateriiPromovate_S2 = value;
            }
        }

        private int _PunctajDacaIntegralist_S2;
        public int PunctajDacaIntegralist_S2
        {
            get
            {
                return _PunctajDacaIntegralist_S2;
            }
            set
            {
                _PunctajDacaIntegralist_S2 = value;
            }
        }

        private double _MedieDacaIntegralist_S2;
        public double MedieDacaIntegralist_S2
        {
            get
            {
                return _MedieDacaIntegralist_S2;
            }
            set
            {
                _MedieDacaIntegralist_S2 = value;
            }
        }


        private int _SumaCrediteMateriiPromovate_An;
        public int SumaCrediteMateriiPromovate_An
        {
            get
            {
                return _SumaCrediteMateriiPromovate_An;
            }
            set
            {
                _SumaCrediteMateriiPromovate_An = value;
            }
        }

        private int _SumaPuncteValoriceMateriiPromovate_An;
        public int SumaPuncteValoriceMateriiPromovate_An
        {
            get
            {
                return _SumaPuncteValoriceMateriiPromovate_An;
            }
            set
            {
                _SumaPuncteValoriceMateriiPromovate_An = value;
            }
        }

        private int _PunctajDacaIntegralist_An;
        public int PunctajDacaIntegralist_An
        {
            get
            {
                return _PunctajDacaIntegralist_An;
            }
            set
            {
                _PunctajDacaIntegralist_An = value;
            }
        }

        private double _MedieDacaIntegralist_An;
        public double MedieDacaIntegralist_An
        {
            get
            {
                return _MedieDacaIntegralist_An;
            }
            set
            {
                _MedieDacaIntegralist_An = value;
            }
        }

        private int _DATE_DIPLOMA_ID_LOCALITATE_EMITENT;
        public int DATE_DIPLOMA_ID_LOCALITATE_EMITENT
        {
            get
            {
                return _DATE_DIPLOMA_ID_LOCALITATE_EMITENT;
            }
            set
            {
                _DATE_DIPLOMA_ID_LOCALITATE_EMITENT = value;
            }
        }

        private int _DATE_DIPLOMA_ID_JUDET_EMITENT;
        public int DATE_DIPLOMA_ID_JUDET_EMITENT
        {
            get
            {
                return _DATE_DIPLOMA_ID_JUDET_EMITENT;
            }
            set
            {
                _DATE_DIPLOMA_ID_JUDET_EMITENT = value;
            }
        }

        private long _DATE_DIPLOMA_ID_TARA_EMITENT;
        public long DATE_DIPLOMA_ID_TARA_EMITENT
        {
            get
            {
                return _DATE_DIPLOMA_ID_TARA_EMITENT;
            }
            set
            {
                _DATE_DIPLOMA_ID_TARA_EMITENT = value;
            }
        }

        private string _SNPasaportStrain;
        public string SNPasaportStrain
        {
            get
            {
                return _SNPasaportStrain;
            }
            set
            {
                _SNPasaportStrain = value;
            }
        }

        private string _DenumireLiceuAbsolvitStrain;
        public string DenumireLiceuAbsolvitStrain
        {
            get
            {
                return _DenumireLiceuAbsolvitStrain;
            }
            set
            {
                _DenumireLiceuAbsolvitStrain = value;
            }
        }

        private string _SpecializareLiceuAbsolvitStrain;
        public string SpecializareLiceuAbsolvitStrain
        {
            get
            {
                return _SpecializareLiceuAbsolvitStrain;
            }
            set
            {
                _SpecializareLiceuAbsolvitStrain = value;
            }
        }

        private string _DATE_DIPLOMA_LocalitateStrainatate;
        public string DATE_DIPLOMA_LocalitateStrainatate
        {
            get
            {
                return _DATE_DIPLOMA_LocalitateStrainatate;
            }
            set
            {
                _DATE_DIPLOMA_LocalitateStrainatate = value;
            }
        }

        private string _DATE_DIPLOMA_InstitutieStrainatate;
        public string DATE_DIPLOMA_InstitutieStrainatate
        {
            get
            {
                return _DATE_DIPLOMA_InstitutieStrainatate;
            }
            set
            {
                _DATE_DIPLOMA_InstitutieStrainatate = value;
            }
        }

        private int _AnSesiuneBac;
        public int AnSesiuneBac
        {
            get
            {
                return _AnSesiuneBac;
            }
            set
            {
                _AnSesiuneBac = value;
            }
        }

        private string _LocalitateLiceuAbsolvitStrain;
        public string LocalitateLiceuAbsolvitStrain
        {
            get
            {
                return _LocalitateLiceuAbsolvitStrain;
            }
            set
            {
                _LocalitateLiceuAbsolvitStrain = value;
            }
        }

        private int _STUDII_LICEU_ID_N_Specializare;
        public int STUDII_LICEU_ID_N_Specializare
        {
            get
            {
                return _STUDII_LICEU_ID_N_Specializare;
            }
            set
            {
                _STUDII_LICEU_ID_N_Specializare = value;
            }
        }

        private bool _AreCNP;
        public bool AreCNP
        {
            get
            {
                return _AreCNP;
            }
            set
            {
                _AreCNP = value;
            }
        }

        private bool _StudentStrain;
        public bool StudentStrain
        {
            get
            {
                return _StudentStrain;
            }
            set
            {
                _StudentStrain = value;
            }
        }

        private string _Adresa_Numar;
        public string Adresa_Numar
        {
            get
            {
                return _Adresa_Numar;
            }
            set
            {
                _Adresa_Numar = value;
            }
        }

        private string _Localitate_nastere_strainatate;
        public string Localitate_nastere_strainatate
        {
            get
            {
                return _Localitate_nastere_strainatate;
            }
            set
            {
                _Localitate_nastere_strainatate = value;
            }
        }

        private string _Localitate_domiciliu_strainatate;
        public string Localitate_domiciliu_strainatate
        {
            get
            {
                return _Localitate_domiciliu_strainatate;

            }
            set
            {
                _Localitate_domiciliu_strainatate = value;
            }
        }

        private string _DenumireTaraNastere;
        public string DenumireTaraNastere
        {
            get
            {
                return _DenumireTaraNastere;
            }
            set
            {
                _DenumireTaraNastere = value;
            }
        }

        private string _Text_LiceuInsitutie;
        public string Text_LiceuInsitutie
        {
            get
            {
                return _Text_LiceuInsitutie;
            }
            set
            {
                _Text_LiceuInsitutie = value;
            }
        }

        private string _Text_LiceuFiliera;
        public string Text_LiceuFiliera
        {
            get
            {
                return _Text_LiceuFiliera;
            }
            set
            {
                _Text_LiceuFiliera = value;
            }
        }

        private string _Text_LiceuProfil;
        public string Text_LiceuProfil
        {
            get
            {
                return _Text_LiceuProfil;
            }
            set
            {
                _Text_LiceuProfil = value;
            }
        }

        private string _Text_LiceuSpecializare;
        public string Text_LiceuSpecializare
        {
            get
            {
                return _Text_LiceuSpecializare;
            }
            set
            {
                _Text_LiceuSpecializare = value;
            }
        }

        private string _Text_LiceuFormaInv;
        public string Text_LiceuFormaInv
        {
            get
            {
                return _Text_LiceuFormaInv;
            }
            set
            {
                _Text_LiceuFormaInv = value;
            }
        }

        private string _Text_LiceuInstitutieEmitenta;
        public string Text_LiceuInstitutieEmitenta
        {
            get
            {
                return _Text_LiceuInstitutieEmitenta;
            }
            set
            {
                _Text_LiceuInstitutieEmitenta = value;
            }
        }

        private string _EmailAlternativ;
        public string EmailAlternativ
        {
            get
            {
                return _EmailAlternativ;
            }
            set
            {
                _EmailAlternativ = value;
            }
        }

        private string _DenumireSituatieMedicalaSpeciala;
        public string DenumireSituatieMedicalaSpeciala
        {
            get
            {
                return _DenumireSituatieMedicalaSpeciala;
            }
            set
            {
                _DenumireSituatieMedicalaSpeciala = value;
            }
        }

        private string _DenumireStareSocialaSpeciala;
        public string DenumireStareSocialaSpeciala
        {
            get
            {
                return _DenumireStareSocialaSpeciala;
            }
            set
            {
                _DenumireStareSocialaSpeciala = value;
            }
        }


        private string _DenumireCicluInv;
        public string DenumireCicluInv
        {
            get
            {
                return _DenumireCicluInv;
            }
            set
            {
                _DenumireCicluInv = value;
            }
        }

        private bool _BursaPlatitaLuna;
        public bool BursaPlatitaLuna
        {
            get
            {
                return _BursaPlatitaLuna;
            }
            set
            {
                _BursaPlatitaLuna = value;
            }
        }

        private long _Id_StudentSuperior;
        public long Id_StudentSuperior
        {
            get
            {
                return _Id_StudentSuperior;
            }
            set
            {
                _Id_StudentSuperior = value;
            }
        }

        private decimal _BugetBursaDisponibil;
        public decimal BugetBursaDisponibil
        {
            get
            {
                return _BugetBursaDisponibil;
            }
            set
            {
                _BugetBursaDisponibil = value;
            }
        }

        private decimal _BugetBursaRamas;
        public decimal BugetBursaRamas
        {
            get
            {
                return _BugetBursaRamas;
            }
            set
            {
                _BugetBursaRamas = value;
            }
        }

        private bool _ArePlanIndividual;
        public bool ArePlanIndividual
        {
            get
            {
                return _ArePlanIndividual;
            }
            set
            {
                _ArePlanIndividual = value;
            }
        }

        private string _DenumireScurtaSpecializare;
        public string DenumireScurtaSpecializare
        {
            get
            {
                return _DenumireScurtaSpecializare;
            }
            set
            {
                _DenumireScurtaSpecializare = value;
            }
        }

        private string _DenumireAnUniv;
        public string DenumireAnUniv
        {
            get
            {
                return _DenumireAnUniv;
            }
            set
            {
                _DenumireAnUniv = value;
            }
        }

        private bool _CandidatOlimpic;
        public bool CandidatOlimpic
        {
            get
            {
                return _CandidatOlimpic;
            }
            set
            {
                _CandidatOlimpic = value;
            }
        }

        private string _NumeCaleFisierExtraCont;
        public string NumeCaleFisierExtraCont
        {
            get
            {
                return _NumeCaleFisierExtraCont;
            }
            set
            {
                _NumeCaleFisierExtraCont = value;
            }
        }


        private string _DenumireSesiuneAdmitere;
        public string DenumireSesiuneAdmitere
        {
            get
            {
                return _DenumireSesiuneAdmitere;
            }
            set
            {
                _DenumireSesiuneAdmitere = value;
            }
        }

    }

    public partial class StudentSetari
    {

        private string _SetariStudent;

        [JsonIgnore]
        public string SetariStudent
        {
            get
            {
                return _SetariStudent;
            }
            set
            {
                _SetariStudent = value;
            }
        }

        private List<long> _ListaPlanSemInlocuitComplet;
        public List<long> ListaPlanSemInlocuitComplet
        {
            get
            {
                return _ListaPlanSemInlocuitComplet;
            }
            set
            {
                _ListaPlanSemInlocuitComplet = value;
            }
        }

        private List<FisierStudentInfo> _ListaTipFisier;
        public List<FisierStudentInfo> ListaTipFisier
        {
            get
            {
                return _ListaTipFisier;
            }
            set
            {
                _ListaTipFisier = value;
            }
        }

    }

    public partial class FisierStudentInfo
    {
        private string _NumeFisier;
        public string NumeFisier
        {
            get
            {
                return _NumeFisier;
            }
            set
            {
                _NumeFisier = value;
            }
        }

        private bool _ValidatSecretariat;
        public bool ValidatSecretariat
        {
            get
            {
                return _ValidatSecretariat;
            }
            set
            {
                _ValidatSecretariat = value;
            }
        }

        private TipFisier _TipFisier;
        public TipFisier TipFisier
        {
            get
            {
                return _TipFisier;
            }
            set
            {
                _TipFisier = value;
            }
        }


    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TipFisier
    {
        FisierDocumentIdentitate,
        FisierFotografieProfil
    }

}