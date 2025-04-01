using Newtonsoft.Json;
using System;

namespace UniApi.Info
{
    public partial class NotaInfo
    {
        public enum TipAcordareNota { Normal = 1, Echivalare = 2, Diferenta = 3, DisciplinaNuMaiExistaInAnulCurent = 4 }
        public NotaInfo()
        {
        }

        public NotaInfo(long iD_Nota, long iD_DetaliuPlanSemestru, long iD_Student, DateTime dataNota, int iD_TipNota, bool ultimaNotaActiva, DateTime dataModificare, int iD_Utilizator, long _UserID_Profesor)
        {
            ID_Nota = iD_Nota;
            ID_DetaliuPlanSemestru = iD_DetaliuPlanSemestru;
            ID_Student = iD_Student;
            DataNota = dataNota;
            ID_TipNota = iD_TipNota;
            UltimaNotaActiva = ultimaNotaActiva;
            DataModificare = dataModificare;
            ID_Utilizator = iD_Utilizator;
            UserID_Profesor = _UserID_Profesor;
        }

        /// <summary>
        /// In cazul in care nota exista deja se forteaza adaugarea aceleiasi note, a.i. sa fie luate in calcul pentru alocarea taxelore de restanta
        /// Exemplu: a luat 4 in sesiunea 1, iar in sesiunea 2 tot 4 -> ca sa se contorizeze corect nr. de sanse, acest ultim 4 trebuie adaugat in BD
        /// </summary>
        public bool ForteazaAdaugareNotaNoua { get; set; }

        public long ID_Nota { get; set; }

        public long ID_DetaliuPlanSemestru { get; set; }

        public long ID_Student { get; set; }

        public DateTime DataNota { get; set; }

        public int ID_TipNota { get; set; }

        public bool UltimaNotaActiva { get; set; }

        [JsonIgnore]
        public DateTime DataModificare { get; set; }

        public int ID_Utilizator { get; set; }

        public long ID_NotaOADPS { get; set; }

        public long ID_TipLimba { get; set; }

        /// <summary>
        /// Seteaza sau da denumirea materiei pentru care e _nota.
        /// </summary>
        /// <value>Denumirea materiei</value>
        public string Denumire { get; set; }

        /// <summary>
        /// Seteaza sau da valoarea notei ca string (1-10, admis/respins, absent, etc)
        /// </summary>
        /// <value>Nota</value>
        public string Nota { get; set; }

        /// <summary>
        /// Returneaza sau seteaza o valoare indicand daca <see cref="NotaInfo"/> este de promovare sau nu.
        /// </summary>
        /// <value><c>true</c> daca promovat; altfel, <c>false</c>.</value>
        public bool Promovat { get; set; }

        /// <summary>
        /// Returneaza sau seteaza denumire specializare.
        /// </summary>
        /// <value>denumirea specializare.</value>
        public string DenumireSpecializare { get; set; }

        public long UserID_Profesor { get; set; }

        public string NumeIntreg { get; set; }

        public long ID_Materie { get; set; }

        public string TipStudentNota { get; set; }

        public long ID_ProgramareExamenProfesor { get; set; }

        public string DenumireMaterieSem { get; set; }

        /// <summary>
        /// 1 - normal, 2=echivalare, 3=diferenta
        /// </summary>
        public int ID_TipAcordareNota { get; set; }

        public string DenumireCFSA { get; set; }

        public string DenumireCompleta { get; set; }
        public long ID_DetaliuPlanSemestruStudent { get; set; }

        public int TipVerificare { get; set; }

        public string NumeIntregAsistentExamen { get; set; }

        public bool NoteFinalizate { get; set; }

        public bool NoteSalvate { get; set; }

        public string Username { get; set; }

        public string NumeIntregStudent { get; set; }

        public string DenumireCFSA_NumeIntregStudent { get { return DenumireCFSA + " / " + NumeIntregStudent; } }

        public string ID_Nota_Student_DPS_DPSS
        {
            get
            {
                return string.Format("{0}/{1}/{2}/{3}", ID_Nota, ID_Student, ID_DetaliuPlanSemestru, ID_DetaliuPlanSemestruStudent);
            }
        }

        public DateTime DataStartIntroNotaCazSpecial { get; set; }
        public DateTime DataFinalIntroNotaCazSpecial { get; set; }
        public int UserID_Modificare { get; set; }
        public long ID_ProfesorCazSpecial { get; set; }

        public long ID_NotaCazSpecial { get; set; }

        public long ID_AsistentExamenCazSpecial { get; set; }

        public long ID_NotaNoua { get; set; }
        public long ID_TipNotaNoua { get; set; }
        public bool PromovatNou { get; set; }

        public string NotaNoua { get; set; }
        public bool NotaSalvata { get; set; }
        public bool NotaFinalizata { get; set; }

        /// <summary>
        /// anul materiei ! Daca difera de anul univ. curent, atunci nota e creditata !
        /// </summary>
        public long ID_AnUniv { get; set; }

        public bool TaxaPlatitaExamenCreditat { get; set; }

        [JsonIgnore]
        public bool TitularSemnat { get; set; }

        [JsonIgnore]
        public bool AsistentExamenSemnat { get; set; }

        [JsonIgnore]
        public byte[] FisierSemnatTitularBLOB { get; set; }

        [JsonIgnore]
        public byte[] FisierSemnatAsistentExamenBLOB { get; set; }

        [JsonIgnore]
        public byte[] FisierFinalBLOB { get; set; }

        [JsonIgnore]
        public DateTime FisierSemnatTitularData { get; set; }

        [JsonIgnore]
        public DateTime FisierSemnatAsistentExamenData { get; set; }

        [JsonIgnore]
        public DateTime FisierFinalData { get; set; }

        [JsonIgnore]
        public string JSONNoteTitular { get; set; }

        [JsonIgnore]
        public string JSONNoteAsistentExamen { get; set; }

        [JsonIgnore]
        public byte[] SemnaturaProfesorBLOB { get; set; }

        [JsonIgnore]
        public byte[] SemnaturaAsistentExamenBLOB { get; set; }

        [JsonIgnore]
        public DateTime SemnaturaProfesorData { get; set; }

        [JsonIgnore]
        public DateTime SemnaturaAsistentExamenData { get; set; }

        public long ID_Facultate { get; set; }

        public long ID_SesiuneExameneSpecializare { get; set; }
    }
}
