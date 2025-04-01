
namespace UniApi.Info
{
    public partial class StudentAnUniversitarInfo : StudentInfo
    {

        private long _iD_StudentAnUniv;
        private long _iD_Student;
        private long _iD_AnUniv;
        private long _iD_anStudiu;
        private int _promovat;
        private bool _exmatriculat;
        private int _status;
        private int _iD_Utilizator;
        private int _portalID;
        private bool _creditat;

        public StudentAnUniversitarInfo()
        {
        }


        public long ID_StudentAnUniv
        {
            get
            {
                return _iD_StudentAnUniv;
            }
            set
            {
                _iD_StudentAnUniv = value;
            }
        }

        // Public Property ID_Student() As Long
        // Get
        // Return _iD_Student
        // End Get
        // Set(ByVal Value As Long)
        // _iD_Student = Value
        // End Set
        // End Property

        // Public Property ID_AnUniv() As Long
        // Get
        // Return _iD_AnUniv
        // End Get
        // Set(ByVal Value As Long)
        // _iD_AnUniv = Value
        // End Set
        // End Property


        // Public Property ID_AnStudiu() As Long
        // Get
        // Return _iD_anStudiu
        // End Get
        // Set(ByVal Value As Long)
        // _iD_anStudiu = Value
        // End Set
        // End Property

        // Public Property Promovat() As Integer
        // Get
        // Return _promovat
        // End Get
        // Set(ByVal Value As Integer)
        // _promovat = Value
        // End Set
        // End Property

        // Public Property Exmatriculat() As Boolean
        // Get
        // Return _exmatriculat
        // End Get
        // Set(ByVal value As Boolean)
        // _exmatriculat = value
        // End Set
        // End Property

        // Public Property Status() As Integer
        // Get
        // Return _status
        // End Get
        // Set(ByVal Value As Integer)
        // _status = Value
        // End Set
        // End Property

        // Public Property ID_Utilizator() As Integer
        // Get
        // Return _iD_Utilizator
        // End Get
        // Set(ByVal Value As Integer)
        // _iD_Utilizator = Value
        // End Set
        // End Property

        // Public Property PortalID() As Integer
        // Get
        // Return _portalID
        // End Get
        // Set(ByVal Value As Integer)
        // _portalID = Value
        // End Set
        // End Property

        public bool Creditat
        {
            get
            {
                return _creditat;
            }
            set
            {
                _creditat = value;
            }
        }


        // Private _Repetent As Boolean

        // Public Property Repetent() As Boolean
        // Get
        // Return _Repetent
        // End Get
        // Set(ByVal value As Boolean)
        // _Repetent = value
        // End Set
        // End Property


        private string _DenumireTipPromovare;

        public string DenumireTipPromovare
        {
            get
            {
                return _DenumireTipPromovare;
            }
            set
            {
                _DenumireTipPromovare = value;
            }
        }


        private string _CandAreLoc;

        public string CandAreLoc
        {
            get
            {
                return _CandAreLoc;
            }
            set
            {
                _CandAreLoc = value;
            }
        }


        // Private _CodCuloareBG As String

        // Public Property CodCuloareBG() As String
        // Get
        // Return _CodCuloareBG
        // End Get
        // Set(ByVal value As String)
        // _CodCuloareBG = value
        // End Set
        // End Property


        // Private _CodCuloareText As String

        // Public Property CodCuloareText() As String
        // Get
        // Return _CodCuloareText
        // End Get
        // Set(ByVal value As String)
        // _CodCuloareText = value
        // End Set
        // End Property

        private int _NumarExameneCreditateAnUniv;

        public int NumarExameneCreditateAnUniv
        {
            get
            {
                return _NumarExameneCreditateAnUniv;
            }
            set
            {
                _NumarExameneCreditateAnUniv = value;
            }
        }


        private long _ID_TipStudent;

        public long ID_TipStudent
        {
            get
            {
                return _ID_TipStudent;
            }
            set
            {
                _ID_TipStudent = value;
            }
        }


        private string _DenumireTipStudent;

        public string DenumireTipStudent
        {
            get
            {
                return _DenumireTipStudent;
            }
            set
            {
                _DenumireTipStudent = value;
            }
        }

        // Private _ID_N_Forma_Finantare_RMU As Integer
        // Public Property ID_N_Forma_Finantare_RMU() As Integer
        // Get
        // Return _ID_N_Forma_Finantare_RMU
        // End Get
        // Set(ByVal value As Integer)
        // _ID_N_Forma_Finantare_RMU = value
        // End Set
        // End Property

        // Private _ID_N_Forma_Finantare_Intern As Integer
        // Public Property ID_N_Forma_Finantare_Intern() As Integer
        // Get
        // Return _ID_N_Forma_Finantare_Intern
        // End Get
        // Set(ByVal value As Integer)
        // _ID_N_Forma_Finantare_Intern = value
        // End Set
        // End Property

        // Private _ID_N_SITUATIE_PROFESIONALA As Integer
        // Public Property ID_N_SITUATIE_PROFESIONALA() As Integer
        // Get
        // Return _ID_N_SITUATIE_PROFESIONALA
        // End Get
        // Set(ByVal value As Integer)
        // _ID_N_SITUATIE_PROFESIONALA = value
        // End Set
        // End Property

        // Private _ID_N_SITUATIE_SCOLARA As Integer
        // Public Property ID_N_SITUATIE_SCOLARA() As Integer
        // Get
        // Return _ID_N_SITUATIE_SCOLARA
        // End Get
        // Set(ByVal value As Integer)
        // _ID_N_SITUATIE_SCOLARA = value
        // End Set
        // End Property


        // Private _MediaAnCuFacultative As Double
        // Public Property MediaAnCuFacultative() As Double
        // Get
        // Return _MediaAnCuFacultative
        // End Get
        // Set(ByVal value As Double)
        // _MediaAnCuFacultative = value
        // End Set
        // End Property

        // Private _MediaAnFaraFacultative As Double
        // Public Property MediaAnFaraFacultative() As Double
        // Get
        // Return _MediaAnFaraFacultative
        // End Get
        // Set(ByVal value As Double)
        // _MediaAnFaraFacultative = value
        // End Set
        // End Property

        // Private _SumaCrediteMateriiPromovate_S1 As Integer
        // Public Property SumaCrediteMateriiPromovate_S1() As Integer
        // Get
        // Return _SumaCrediteMateriiPromovate_S1
        // End Get
        // Set(ByVal value As Integer)
        // _SumaCrediteMateriiPromovate_S1 = value
        // End Set
        // End Property

        // Private _SumaPuncteValoriceMateriiPromovate_S1 As Integer
        // Public Property SumaPuncteValoriceMateriiPromovate_S1() As Integer
        // Get
        // Return _SumaPuncteValoriceMateriiPromovate_S1
        // End Get
        // Set(ByVal value As Integer)
        // _SumaPuncteValoriceMateriiPromovate_S1 = value
        // End Set
        // End Property

        // Private _PunctajDacaIntegralist_S1 As Integer
        // Public Property PunctajDacaIntegralist_S1() As Integer
        // Get
        // Return _PunctajDacaIntegralist_S1
        // End Get
        // Set(ByVal value As Integer)
        // _PunctajDacaIntegralist_S1 = value
        // End Set
        // End Property

        // Private _MedieDacaIntegralist_S1 As Double
        // Public Property MedieDacaIntegralist_S1() As Double
        // Get
        // Return _MedieDacaIntegralist_S1
        // End Get
        // Set(ByVal value As Double)
        // _MedieDacaIntegralist_S1 = value
        // End Set
        // End Property


        // Private _SumaCrediteMateriiPromovate_S2 As Integer
        // Public Property SumaCrediteMateriiPromovate_S2() As Integer
        // Get
        // Return _SumaCrediteMateriiPromovate_S2
        // End Get
        // Set(ByVal value As Integer)
        // _SumaCrediteMateriiPromovate_S2 = value
        // End Set
        // End Property

        // Private _SumaPuncteValoriceMateriiPromovate_S2 As Integer
        // Public Property SumaPuncteValoriceMateriiPromovate_S2() As Integer
        // Get
        // Return _SumaPuncteValoriceMateriiPromovate_S2
        // End Get
        // Set(ByVal value As Integer)
        // _SumaPuncteValoriceMateriiPromovate_S2 = value
        // End Set
        // End Property

        // Private _PunctajDacaIntegralist_S2 As Integer
        // Public Property PunctajDacaIntegralist_S2() As Integer
        // Get
        // Return _PunctajDacaIntegralist_S2
        // End Get
        // Set(ByVal value As Integer)
        // _PunctajDacaIntegralist_S2 = value
        // End Set
        // End Property

        // Private _MedieDacaIntegralist_S2 As Double
        // Public Property MedieDacaIntegralist_S2() As Double
        // Get
        // Return _MedieDacaIntegralist_S2
        // End Get
        // Set(ByVal value As Double)
        // _MedieDacaIntegralist_S2 = value
        // End Set
        // End Property


        // Private _SumaCrediteMateriiPromovate_An As Integer
        // Public Property SumaCrediteMateriiPromovate_An() As Integer
        // Get
        // Return _SumaCrediteMateriiPromovate_An
        // End Get
        // Set(ByVal value As Integer)
        // _SumaCrediteMateriiPromovate_An = value
        // End Set
        // End Property

        // Private _SumaPuncteValoriceMateriiPromovate_An As Integer
        // Public Property SumaPuncteValoriceMateriiPromovate_An() As Integer
        // Get
        // Return _SumaPuncteValoriceMateriiPromovate_An
        // End Get
        // Set(ByVal value As Integer)
        // _SumaPuncteValoriceMateriiPromovate_An = value
        // End Set
        // End Property

        // Private _PunctajDacaIntegralist_An As Integer
        // Public Property PunctajDacaIntegralist_An() As Integer
        // Get
        // Return _PunctajDacaIntegralist_An
        // End Get
        // Set(ByVal value As Integer)
        // _PunctajDacaIntegralist_An = value
        // End Set
        // End Property

        // Private _MedieDacaIntegralist_An As Double
        // Public Property MedieDacaIntegralist_An() As Double
        // Get
        // Return _MedieDacaIntegralist_An
        // End Get
        // Set(ByVal value As Double)
        // _MedieDacaIntegralist_An = value
        // End Set
        // End Property


        private int _ID_N_Cazare;
        public int ID_N_Cazare
        {
            get
            {
                return _ID_N_Cazare;
            }
            set
            {
                _ID_N_Cazare = value;
            }
        }


        private string _ID_N_BursaS1;
        public string ID_N_BursaS1
        {
            get
            {
                return _ID_N_BursaS1;
            }
            set
            {
                _ID_N_BursaS1 = value;
            }
        }


        private string _ID_N_BursaS2;
        public string ID_N_BursaS2
        {
            get
            {
                return _ID_N_BursaS2;
            }
            set
            {
                _ID_N_BursaS2 = value;
            }
        }



        private int _ID_N_SITUATIE_PROFESIONALA_FINAL;
        public int ID_N_SITUATIE_PROFESIONALA_FINAL
        {
            get
            {
                return _ID_N_SITUATIE_PROFESIONALA_FINAL;
            }
            set
            {
                _ID_N_SITUATIE_PROFESIONALA_FINAL = value;
            }
        }


        private int _ID_N_SITUATIE_SCOLARA_FINAL;
        public int ID_N_SITUATIE_SCOLARA_FINAL
        {
            get
            {
                return _ID_N_SITUATIE_SCOLARA_FINAL;
            }
            set
            {
                _ID_N_SITUATIE_SCOLARA_FINAL = value;
            }
        }

        private string _DenumireFormaFinantareRMU;
        public string DenumireFormaFinantareRMU
        {
            get
            {
                return _DenumireFormaFinantareRMU;
            }
            set
            {
                _DenumireFormaFinantareRMU = value;
            }
        }

        private string _DenumireFormaFinantareInterna;
        public string DenumireFormaFinantareInterna
        {
            get
            {
                return _DenumireFormaFinantareInterna;
            }
            set
            {
                _DenumireFormaFinantareInterna = value;
            }
        }

        private string _DenumireSituatieScolara;
        public string DenumireSituatieScolara
        {
            get
            {
                return _DenumireSituatieScolara;
            }
            set
            {
                _DenumireSituatieScolara = value;
            }
        }

        private string _DenumireSituatieScolaraFINAL;
        public string DenumireSituatieScolaraFINAL
        {
            get
            {
                return _DenumireSituatieScolaraFINAL;
            }
            set
            {
                _DenumireSituatieScolaraFINAL = value;
            }
        }

    }
}