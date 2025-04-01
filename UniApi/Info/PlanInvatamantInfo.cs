using System.ComponentModel;

namespace UniApi.Info
{
    public partial class PlanInvatamantInfo
    {
        private long _iD_PlanInvatamant;
        private string _denumire;
        private string _observatii;
        private int _numarSemestre;
        private long _iD_Facultate;

        public PlanInvatamantInfo()
        {
        }

        public PlanInvatamantInfo(long iD_PlanInvatamant, string denumire, string observatii, int numarSemestre, long iD_Facultate)
        {
            ID_PlanInvatamant = iD_PlanInvatamant;
            Denumire = denumire;
            Observatii = observatii;
            NumarSemestre = numarSemestre;
            ID_Facultate = iD_Facultate;
        }

        [DataObjectField(true)]
        public long ID_PlanInvatamant
        {
            get
            {
                return _iD_PlanInvatamant;
            }
            set
            {
                _iD_PlanInvatamant = value;
            }
        }

        [DataObjectField(false)]
        public string Denumire
        {
            get
            {
                return _denumire;
            }
            set
            {
                _denumire = value;
            }
        }

        [DataObjectField(false)]
        public string Observatii
        {
            get
            {
                return _observatii;
            }
            set
            {
                _observatii = value;
            }
        }

        [DataObjectField(false)]
        public int NumarSemestre
        {
            get
            {
                return _numarSemestre;
            }
            set
            {
                _numarSemestre = value;
            }
        }

        [DataObjectField(false)]
        public long ID_Facultate
        {
            get
            {
                return _iD_Facultate;
            }
            set
            {
                _iD_Facultate = value;
            }
        }


        private string _DenumireCalificare;
        public string DenumireCalificare
        {
            get
            {
                return _DenumireCalificare;
            }
            set
            {
                _DenumireCalificare = value;
            }
        }


        private string _DenumireCalificareEngleza;
        public string DenumireCalificareEngleza
        {
            get
            {
                return _DenumireCalificareEngleza;
            }
            set
            {
                _DenumireCalificareEngleza = value;
            }
        }


        private string _LimbaStudiuExaminare;
        public string LimbaStudiuExaminare
        {
            get
            {
                return _LimbaStudiuExaminare;
            }
            set
            {
                _LimbaStudiuExaminare = value;
            }
        }


        private string _LimbaStudiuExaminareEngleza;
        public string LimbaStudiuExaminareEngleza
        {
            get
            {
                return _LimbaStudiuExaminareEngleza;
            }
            set
            {
                _LimbaStudiuExaminareEngleza = value;
            }
        }


        private string _NivelCalificare;
        public string NivelCalificare
        {
            get
            {
                return _NivelCalificare;
            }
            set
            {
                _NivelCalificare = value;
            }
        }


        private string _NivelCalificareEngleza;
        public string NivelCalificareEngleza
        {
            get
            {
                return _NivelCalificareEngleza;
            }
            set
            {
                _NivelCalificareEngleza = value;
            }
        }


        private string _DurataOficialaSiNrCredite;
        public string DurataOficialaSiNrCredite
        {
            get
            {
                return _DurataOficialaSiNrCredite;
            }
            set
            {
                _DurataOficialaSiNrCredite = value;
            }
        }


        private string _DurataOficialaSiNrCrediteEngleza;
        public string DurataOficialaSiNrCrediteEngleza
        {
            get
            {
                return _DurataOficialaSiNrCrediteEngleza;
            }
            set
            {
                _DurataOficialaSiNrCrediteEngleza = value;
            }
        }


        private string _ConditiiInscriere;
        public string ConditiiInscriere
        {
            get
            {
                return _ConditiiInscriere;
            }
            set
            {
                _ConditiiInscriere = value;
            }
        }


        private string _ConditiiInscriereEngleza;
        public string ConditiiInscriereEngleza
        {
            get
            {
                return _ConditiiInscriereEngleza;
            }
            set
            {
                _ConditiiInscriereEngleza = value;
            }
        }


        private string _NumeStatutInstAbsolvita;
        public string NumeStatutInstAbsolvita
        {
            get
            {
                return _NumeStatutInstAbsolvita;
            }
            set
            {
                _NumeStatutInstAbsolvita = value;
            }
        }


        private string _NumeStatutInstAbsolvitaEngleza;
        public string NumeStatutInstAbsolvitaEngleza
        {
            get
            {
                return _NumeStatutInstAbsolvitaEngleza;
            }
            set
            {
                _NumeStatutInstAbsolvitaEngleza = value;
            }
        }


        private string _StatutProfesional;
        public string StatutProfesional
        {
            get
            {
                return _StatutProfesional;
            }
            set
            {
                _StatutProfesional = value;
            }
        }


        private string _StatutProfesionalEngleza;
        public string StatutProfesionalEngleza
        {
            get
            {
                return _StatutProfesionalEngleza;
            }
            set
            {
                _StatutProfesionalEngleza = value;
            }
        }


        private string _CompetenteAsigurate;
        public string CompetenteAsigurate
        {
            get
            {
                return _CompetenteAsigurate;
            }
            set
            {
                _CompetenteAsigurate = value;
            }
        }


        private string _CompetenteAsigurateEngleza;
        public string CompetenteAsigurateEngleza
        {
            get
            {
                return _CompetenteAsigurateEngleza;
            }
            set
            {
                _CompetenteAsigurateEngleza = value;
            }
        }


        private string _DenumireOficialaCiclu;
        public string DenumireOficialaCiclu
        {
            get
            {
                return _DenumireOficialaCiclu;
            }
            set
            {
                _DenumireOficialaCiclu = value;
            }
        }


        private string _DenumireExamenAbsolvire;
        public string DenumireExamenAbsolvire
        {
            get
            {
                return _DenumireExamenAbsolvire;
            }
            set
            {
                _DenumireExamenAbsolvire = value;
            }
        }

        private string _DenumireExamenAbsolvireEngleza;
        public string DenumireExamenAbsolvireEngleza
        {
            get
            {
                return _DenumireExamenAbsolvireEngleza;
            }
            set
            {
                _DenumireExamenAbsolvireEngleza = value;
            }
        }


        private string _TipProgramDeStudiiSpecializare;
        public string TipProgramDeStudiiSpecializare
        {
            get
            {
                return _TipProgramDeStudiiSpecializare;
            }
            set
            {
                _TipProgramDeStudiiSpecializare = value;
            }
        }


        private string _DurataAniSiLegea;
        public string DurataAniSiLegea
        {
            get
            {
                return _DurataAniSiLegea;
            }
            set
            {
                _DurataAniSiLegea = value;
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


        private string _DenumireFacultateEngleza;
        public string DenumireFacultateEngleza
        {
            get
            {
                return _DenumireFacultateEngleza;
            }
            set
            {
                _DenumireFacultateEngleza = value;
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


        private string _NumeStatutInstDiploma;
        public string NumeStatutInstDiploma
        {
            get
            {
                return _NumeStatutInstDiploma;
            }
            set
            {
                _NumeStatutInstDiploma = value;
            }
        }


        private string _NumeStatutInstDiplomaEngleza;
        public string NumeStatutInstDiplomaEngleza
        {
            get
            {
                return _NumeStatutInstDiplomaEngleza;
            }
            set
            {
                _NumeStatutInstDiplomaEngleza = value;
            }
        }


        private string _FacultateOrgExamenFinalizareStudii;
        public string FacultateOrgExamenFinalizareStudii
        {
            get
            {
                return _FacultateOrgExamenFinalizareStudii;
            }
            set
            {
                _FacultateOrgExamenFinalizareStudii = value;
            }
        }


        private string _FacultateOrgExamenFinalizareStudiiEngleza;
        public string FacultateOrgExamenFinalizareStudiiEngleza
        {
            get
            {
                return _FacultateOrgExamenFinalizareStudiiEngleza;
            }
            set
            {
                _FacultateOrgExamenFinalizareStudiiEngleza = value;
            }
        }

        private string _PerioadaAni;
        public string PerioadaAni
        {
            get
            {
                return _PerioadaAni;
            }
            set
            {
                _PerioadaAni = value;
            }
        }

    }
}