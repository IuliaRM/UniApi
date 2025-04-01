using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace UniApi.Info
{
	public partial class DetaliuPlanSemestruInfo
	{
		// Fields
		private string _CodificareDisciplina;
		private decimal _CoefDeCost;
		private decimal _CoefDeEch;
		private decimal _CoefOreConvApp;
		private decimal _CoefOreConvCurs;
		private string _denumire;
		private string _DenumireAnStudiu;
		private string _DenumireAnUniv;
		private string _DenumireCicluInv;
		private string _DenumireDomeniu;
		private string _DenumireFormaInv;
		private string _DenumireMaterie;
		private string _DenumirePlanInvatamant;
		private string _DenumireScurta;
		private string _DenumireSpecializare;
		private long _iD_AnStud;
		private long _iD_AnUniv;
		private long _ID_CatedraCoordonatoare;
		private long _ID_CatedraPrestatoareAplicatii;
		private long _ID_CatedraPrestatoareCurs;
		private long _ID_Cuplaj;
		private long _iD_DetaliuPlanSemestru;
		private long _iD_Domeniu;
		private long _ID_Facultate;
		private long _ID_FC;
		private long _ID_FCForma;
		private long _iD_Materie;
		private long _ID_PlanInvatamant;
		private long _iD_PlanSemestru;
		private long _iD_Specializare;
		private long _iD_Student;
		private long _ID_TipCiclu;
		private long _ID_TipFormaInv;
		private long _ID_TipLimba;
		private int _Id_TipNota;
		private string _LimbaDePredare;
		private decimal _NrCredite;
		private decimal _nrFormatiiCurs;
		private decimal _nrFormatiiLaborator;
		private decimal _nrFormatiiProiect;
		private decimal _nrFormatiiSeminar;
		private decimal _nrOreCurs;
		private decimal _nrOreLaborator;
		private decimal _nrOreProiect;
		private decimal _nrOreRamaseCurs;
		private decimal _nrOreRamaseLaborator;
		private decimal _nrOreRamaseProiect;
		private decimal _nrOreRamaseSeminar;
		private decimal _nrOreSeminar;
		private int _numarPachet;
		private long _numarSemestru;
		private long _numarSemestruDinAn;
		private string _Observatii;
		private int _ordine;
		private int _OrdineDetaliuPlanSemestru;
		private int _TipDisciplina;
		private int _tipDisciplinaCriteriul1;
		private int _tipDisciplinaCriteriul2;
		private int _tipVerificare;

		// Methods
		public DetaliuPlanSemestruInfo()
		{
			this._Id_TipNota = -1;
			this._ID_TipLimba = -1L;
		}

		public DetaliuPlanSemestruInfo(long iD_DetaliuPlanSemestru, long iD_PlanSemestru, long iD_Materie, int numarPachet, int tipDisciplinaCriteriul1, int tipDisciplinaCriteriul2, decimal nrOreCurs, decimal nrOreSeminar, decimal nrOreLaborator, decimal nrOreProiect, int tipVerificare, int ordine, decimal nrFormatiiCurs, decimal nrFormatiiSeminar, decimal nrFormatiiLaborator, decimal nrFormatiiProiect, decimal CoefOreConvCurs, decimal CoefOreConvApp, decimal CoefDeEch)
		{
			this._Id_TipNota = -1;
			this._ID_TipLimba = -1L;
			this.ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
			this.ID_PlanSemestru = iD_PlanSemestru;
			this.ID_Materie = iD_Materie;
			this.NumarPachet = numarPachet;
			this.TipDisciplinaCriteriul1 = tipDisciplinaCriteriul1;
			this.TipDisciplinaCriteriul2 = tipDisciplinaCriteriul2;
			this.NrOreCurs = nrOreCurs;
			this.NrOreSeminar = nrOreSeminar;
			this.NrOreLaborator = nrOreLaborator;
			this.NrOreProiect = nrOreProiect;
			this.TipVerificare = tipVerificare;
			this.Ordine = ordine;
			this.NrFormatiiCurs = nrFormatiiCurs;
			this.NrFormatiiSeminar = nrFormatiiSeminar;
			this.NrFormatiiLaborator = nrFormatiiLaborator;
			this.NrFormatiiProiect = nrFormatiiProiect;
			this.CoefOreConvCurs = CoefOreConvCurs;
			this.CoefOreConvApp = CoefOreConvApp;
			this.CoefDeEch = CoefDeEch;
		}

		// Properties
		public string CodificareDisciplina
		{
			get
			{
				return this._CodificareDisciplina;
			}
			set
			{
				this._CodificareDisciplina = value;
			}
		}

		[DataObjectField(false)]
		public decimal CoefDeCost
		{
			get
			{
				return this._CoefDeCost;
			}
			set
			{
				this._CoefDeCost = value;
			}
		}

		[DataObjectField(false)]
		public decimal CoefDeEch
		{
			get
			{
				return this._CoefDeEch;
			}
			set
			{
				this._CoefDeEch = value;
			}
		}

		[DataObjectField(false)]
		public decimal CoefOreConvApp
		{
			get
			{
				return this._CoefOreConvApp;
			}
			set
			{
				this._CoefOreConvApp = value;
			}
		}

		[DataObjectField(false)]
		public decimal CoefOreConvCurs
		{
			get
			{
				return this._CoefOreConvCurs;
			}
			set
			{
				this._CoefOreConvCurs = value;
			}
		}

		[DataObjectField(false)]
		public string Denumire
		{
			get
			{
				return this._denumire;
			}
			set
			{
				this._denumire = value;
			}
		}

		public string DenumireAnStudiu
		{
			get
			{
				return this._DenumireAnStudiu;
			}
			set
			{
				this._DenumireAnStudiu = value;
			}
		}

		public string DenumireAnUniv
		{
			get
			{
				return this._DenumireAnUniv;
			}
			set
			{
				this._DenumireAnUniv = value;
			}
		}

		public string DenumireCicluInv
		{
			get
			{
				return this._DenumireCicluInv;
			}
			set
			{
				this._DenumireCicluInv = value;
			}
		}

		public string DenumireDomeniu
		{
			get
			{
				return this._DenumireDomeniu;
			}
			set
			{
				this._DenumireDomeniu = value;
			}
		}

		public string DenumireFormaInv
		{
			get
			{
				return this._DenumireFormaInv;
			}
			set
			{
				this._DenumireFormaInv = value;
			}
		}

		public string DenumireMaterie
		{
			get
			{
				return this._DenumireMaterie;
			}
			set
			{
				this._DenumireMaterie = value;
			}
		}

		public string DenumirePlanInvatamant
		{
			get
			{
				return this._DenumirePlanInvatamant;
			}
			set
			{
				this._DenumirePlanInvatamant = value;
			}
		}

		public string DenumireScurta
		{
			get
			{
				return this._DenumireScurta;
			}
			set
			{
				this._DenumireScurta = value;
			}
		}

		public string DenumireSpecializare
		{
			get
			{
				return this._DenumireSpecializare;
			}
			set
			{
				this._DenumireSpecializare = value;
			}
		}

		[DataObjectField(false)]
		public long ID_AnStud
		{
			get
			{
				return this._iD_AnStud;
			}
			set
			{
				this._iD_AnStud = value;
			}
		}

		[DataObjectField(false)]
		public long ID_AnStudiu
		{
			get
			{
				return this._iD_AnStud;
			}
			set
			{
				this._iD_AnStud = value;
			}
		}

		[DataObjectField(false)]
		public long ID_AnUniv
		{
			get
			{
				return this._iD_AnUniv;
			}
			set
			{
				this._iD_AnUniv = value;
			}
		}

		public long ID_CatedraCoordonatoare
		{
			get
			{
				return this._ID_CatedraCoordonatoare;
			}
			set
			{
				this._ID_CatedraCoordonatoare = value;
			}
		}

		public long ID_CatedraPrestatoareAplicatii
		{
			get
			{
				return this._ID_CatedraPrestatoareAplicatii;
			}
			set
			{
				this._ID_CatedraPrestatoareAplicatii = value;
			}
		}

		public long ID_CatedraPrestatoareCurs
		{
			get
			{
				return this._ID_CatedraPrestatoareCurs;
			}
			set
			{
				this._ID_CatedraPrestatoareCurs = value;
			}
		}

		[DataObjectField(false)]
		public long ID_Cuplaj
		{
			get
			{
				return this._ID_Cuplaj;
			}
			set
			{
				this._ID_Cuplaj = value;
			}
		}

		[DataObjectField(true)]
		public long ID_DetaliuPlanSemestru
		{
			get
			{
				return this._iD_DetaliuPlanSemestru;
			}
			set
			{
				this._iD_DetaliuPlanSemestru = value;
			}
		}

		[DataObjectField(false)]
		public long ID_Domeniu
		{
			get
			{
				return this._iD_Domeniu;
			}
			set
			{
				this._iD_Domeniu = value;
			}
		}

		public long ID_Facultate
		{
			get
			{
				return this._ID_Facultate;
			}
			set
			{
				this._ID_Facultate = value;
			}
		}

		public long ID_FC
		{
			get
			{
				return this._ID_FC;
			}
			set
			{
				this._ID_FC = value;
			}
		}

		public long ID_FCForma
		{
			get
			{
				return this._ID_FCForma;
			}
			set
			{
				this._ID_FCForma = value;
			}
		}

		[DataObjectField(false)]
		public long ID_Materie
		{
			get
			{
				return this._iD_Materie;
			}
			set
			{
				this._iD_Materie = value;
			}
		}

		public long ID_PlanInvatamant
		{
			get
			{
				return this._ID_PlanInvatamant;
			}
			set
			{
				this._ID_PlanInvatamant = value;
			}
		}

		[DataObjectField(false)]
		public long ID_PlanSemestru
		{
			get
			{
				return this._iD_PlanSemestru;
			}
			set
			{
				this._iD_PlanSemestru = value;
			}
		}

		[DataObjectField(false)]
		public long ID_Specializare
		{
			get
			{
				return this._iD_Specializare;
			}
			set
			{
				this._iD_Specializare = value;
			}
		}

		[DataObjectField(false)]
		public long ID_Student
		{
			get
			{
				return this._iD_Student;
			}
			set
			{
				this._iD_Student = value;
			}
		}

		public long ID_TipCiclu
		{
			get
			{
				return this._ID_TipCiclu;
			}
			set
			{
				this._ID_TipCiclu = value;
			}
		}

		public long ID_TipFormaInv
		{
			get
			{
				return this._ID_TipFormaInv;
			}
			set
			{
				this._ID_TipFormaInv = value;
			}
		}

		public long ID_TipLimba
		{
			get
			{
				return this._ID_TipLimba;
			}
			set
			{
				this._ID_TipLimba = value;
			}
		}

		public int ID_TipNota
		{
			get
			{
				return this._Id_TipNota;
			}
			set
			{
				this._Id_TipNota = value;
			}
		}

		[DataObjectField(false)]
		public string LimbaDePredare
		{
			get
			{
				return this._LimbaDePredare;
			}
			set
			{
				this._LimbaDePredare = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrCredite
		{
			get
			{
				return this._NrCredite;
			}
			set
			{
				this._NrCredite = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrFormatiiCurs
		{
			get
			{
				return this._nrFormatiiCurs;
			}
			set
			{
				this._nrFormatiiCurs = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrFormatiiLaborator
		{
			get
			{
				return this._nrFormatiiLaborator;
			}
			set
			{
				this._nrFormatiiLaborator = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrFormatiiProiect
		{
			get
			{
				return this._nrFormatiiProiect;
			}
			set
			{
				this._nrFormatiiProiect = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrFormatiiSeminar
		{
			get
			{
				return this._nrFormatiiSeminar;
			}
			set
			{
				this._nrFormatiiSeminar = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreCurs
		{
			get
			{
				return this._nrOreCurs;
			}
			set
			{
				this._nrOreCurs = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreLaborator
		{
			get
			{
				return this._nrOreLaborator;
			}
			set
			{
				this._nrOreLaborator = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreProiect
		{
			get
			{
				return this._nrOreProiect;
			}
			set
			{
				this._nrOreProiect = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreRamaseCurs
		{
			get
			{
				return this._nrOreRamaseCurs;
			}
			set
			{
				this._nrOreRamaseCurs = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreRamaseLaborator
		{
			get
			{
				return this._nrOreRamaseLaborator;
			}
			set
			{
				this._nrOreRamaseLaborator = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreRamaseProiect
		{
			get
			{
				return this._nrOreRamaseProiect;
			}
			set
			{
				this._nrOreRamaseProiect = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreRamaseSeminar
		{
			get
			{
				return this._nrOreRamaseSeminar;
			}
			set
			{
				this._nrOreRamaseSeminar = value;
			}
		}

		[DataObjectField(false)]
		public decimal NrOreSeminar
		{
			get
			{
				return this._nrOreSeminar;
			}
			set
			{
				this._nrOreSeminar = value;
			}
		}

		[DataObjectField(false)]
		public int NumarPachet
		{
			get
			{
				return this._numarPachet;
			}
			set
			{
				this._numarPachet = value;
			}
		}

		[DataObjectField(false)]
		public long NumarSemestru
		{
			get
			{
				return this._numarSemestru;
			}
			set
			{
				this._numarSemestru = value;
			}
		}

		[DataObjectField(false)]
		public long NumarSemestruDinAn
		{
			get
			{
				return this._numarSemestruDinAn;
			}
			set
			{
				this._numarSemestruDinAn = value;
			}
		}

		public string Observatii
		{
			get
			{
				return this._Observatii;
			}
			set
			{
				this._Observatii = value;
			}
		}

		[DataObjectField(false)]
		public int Ordine
		{
			get
			{
				return this._ordine;
			}
			set
			{
				this._ordine = value;
			}
		}

		public int OrdineDetaliuPlanSemestru
		{
			get
			{
				return this._OrdineDetaliuPlanSemestru;
			}
			set
			{
				this._OrdineDetaliuPlanSemestru = value;
			}
		}

		[Obsolete("Foloseste TipDisciplinaCriteriu1 si TipDisciplinaCriteriu2")]
		public int TipDisciplina
		{
			get
			{
				return this._TipDisciplina;
			}
			set
			{
				this._TipDisciplina = value;
			}
		}

		[DataObjectField(false)]
		public int TipDisciplinaCriteriul1
		{
			get
			{
				return this._tipDisciplinaCriteriul1;
			}
			set
			{
				this._tipDisciplinaCriteriul1 = value;
			}
		}

		[DataObjectField(false)]
		public int TipDisciplinaCriteriul2
		{
			get
			{
				return this._tipDisciplinaCriteriul2;
			}
			set
			{
				this._tipDisciplinaCriteriul2 = value;
			}
		}

		[DataObjectField(false)]
		public int TipVerificare
		{
			get
			{
				return this._tipVerificare;
			}
			set
			{
				this._tipVerificare = value;
			}
		}

		public string DenumireCompletaDisciplina { get; set; }

		public long ID_FacultatePrestatoareCurs { get; set; }

		public long ID_FacultatePrestatoareAplicatii { get; set; }

		public long ID_DetaliuPlanSemestruInlocuit { get; set; }

        public long ID_ProfesorTitularCurs { get; set; }

        public string NumeIntreg { get; set; }
        public string DenumireCatedra { get; set; }

        public long ID_PlanMaterie_Prestator_Importat { get; set; }
		public long ID_PlanMaterie_Prestator_Importat_Stat { get; set; }
        public long ID_PlanMaterie_Prestator { get; set; }
        public int NrSemestruDinAn { get; set; }
        public int NrAnStudii { get; set; }
    }

}