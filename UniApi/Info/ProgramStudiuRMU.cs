using System;
namespace UniApi.Info
{
	public partial class ProgramStudiuRMUInfo
	{
		int _iD_ELEMENT;
		long _iD_AnUniv;
		int _iD_DOMENIUSTUDIU;
		string _denumireDomeniuStudiuRMU;
		int _iD_PROGRAM;
		string _denumireProgramRMU;
		int _iD_FACULTATE;
		string _denumireFacultateRMU;
		int _dURATA;
		int _pUNCTE_CREDIT;
		int _iD_LOCALITATE;
		string _denumireLocalitateRMU;
		int _iD_TIP_ACREDITARE;
		string _denumireTipAcreditareRMU;
		int _iD_LIMBAPREDARE;
		string _denumireLimbaPredareRMU;
		int _iD_FORMA_INVATAMANT;
		string _denumireFormaInvRMU;
		int _iD_CICLU_STUDII;
		string _denumireCicluInvRMU;

		public ProgramStudiuRMUInfo()
		{
		}


		public int ID_ELEMENT
		{
			get { return _iD_ELEMENT; }
			set { _iD_ELEMENT = value; }
		}

		public long ID_AnUniv
		{
			get { return _iD_AnUniv; }
			set { _iD_AnUniv = value; }
		}

		public int ID_DOMENIUSTUDIU
		{
			get { return _iD_DOMENIUSTUDIU; }
			set { _iD_DOMENIUSTUDIU = value; }
		}

		public string DenumireDomeniuStudiuRMU
		{
			get { return _denumireDomeniuStudiuRMU; }
			set { _denumireDomeniuStudiuRMU = value; }
		}

		public int ID_PROGRAM
		{
			get { return _iD_PROGRAM; }
			set { _iD_PROGRAM = value; }
		}

		public string DenumireProgramRMU
		{
			get { return _denumireProgramRMU; }
			set { _denumireProgramRMU = value; }
		}

		public int ID_FACULTATE
		{
			get { return _iD_FACULTATE; }
			set { _iD_FACULTATE = value; }
		}

		public string DenumireFacultateRMU
		{
			get { return _denumireFacultateRMU; }
			set { _denumireFacultateRMU = value; }
		}

		public int DURATA
		{
			get { return _dURATA; }
			set { _dURATA = value; }
		}

		public int PUNCTE_CREDIT
		{
			get { return _pUNCTE_CREDIT; }
			set { _pUNCTE_CREDIT = value; }
		}

		public int ID_LOCALITATE
		{
			get { return _iD_LOCALITATE; }
			set { _iD_LOCALITATE = value; }
		}

		public string DenumireLocalitateRMU
		{
			get { return _denumireLocalitateRMU; }
			set { _denumireLocalitateRMU = value; }
		}

		public int ID_TIP_ACREDITARE
		{
			get { return _iD_TIP_ACREDITARE; }
			set { _iD_TIP_ACREDITARE = value; }
		}

		public string DenumireTipAcreditareRMU
		{
			get { return _denumireTipAcreditareRMU; }
			set { _denumireTipAcreditareRMU = value; }
		}

		public int ID_LIMBAPREDARE
		{
			get { return _iD_LIMBAPREDARE; }
			set { _iD_LIMBAPREDARE = value; }
		}

		public string DenumireLimbaPredareRMU
		{
			get { return _denumireLimbaPredareRMU; }
			set { _denumireLimbaPredareRMU = value; }
		}

		public int ID_FORMA_INVATAMANT
		{
			get { return _iD_FORMA_INVATAMANT; }
			set { _iD_FORMA_INVATAMANT = value; }
		}

		public string DenumireFormaInvRMU
		{
			get { return _denumireFormaInvRMU; }
			set { _denumireFormaInvRMU = value; }
		}

		public int ID_CICLU_STUDII
		{
			get { return _iD_CICLU_STUDII; }
			set { _iD_CICLU_STUDII = value; }
		}

		public string DenumireCicluInvRMU
		{
			get { return _denumireCicluInvRMU; }
			set { _denumireCicluInvRMU = value; }
		}
	}
}
