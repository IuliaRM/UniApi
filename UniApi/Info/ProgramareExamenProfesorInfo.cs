/*
' Module: Your Module
' Copyright (c) 2019 YourCompany
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/
using System;

namespace UniApi.Info
{
    public class ProgramareExamenProfesorInfo
    {
        public long ID_DetaliuPlanSemestru { get; set; }
        public long ID_DetaliuPlanSemestruStudent { get; set; }
        public long ID_PlanSemestru { get; set; }
        public long ID_Specializare { get; set; }

        public long ID_Materie { get; set; }


        public long ID_AnStud { get; set; }
        public long ID_TipCiclu { get; set; }
        public long ID_TipFormaInv { get; set; }

        public long ID_MetaSpecializare { get; set; }

        public string DenumireSpecializare { get; set; }
        /// <summary>
        /// Denumire materie....
        /// </summary>
        public string Denumire { get; set; }
        public long ID_Grupe { get; set; }
        public long ID_Grupa { get; set; }
        public string DenumireGrupa { get; set; }
        public long ID_ProgramareExamen { get; set; }
        public long ID_ProgramareExamenProfesor { get; set; }
        public string DenumireSesiuneExamene { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }
        public DateTime DataLimitaNote { get; set; }

        public string DenumireCicluInv { get; set; }
        public string DenumireFormaInv { get; set; }
        public int NumarSemestruDinAn { get; set; }

        public long ID_SesiuneExamene { get; set; }
        public long ID_SesiuneExameneSpecializare { get; set; }

        /// <summary>
        /// Data examenului
        /// </summary>
        public DateTime Data { get; set; }

        public string Sala { get; set; }

        public long ID_Sala { get; set; }

        public bool Online { get; set; }

        public DateTime DataLimitaNotePeDisciplina { get; set; }


        public DateTime DataInceputPeSpec { get; set; }
        public DateTime DataSfarsitPeSpec { get; set; }
        public DateTime DataLimitaNotePeSpec { get; set; }

        public long ID_Profesor { get; set; }
        public long ID_AnUniv { get; set; }
        public bool Activ { get; set; }
        public int ID_TipProfesorAsociere { get; set; }

        public string DenumireAnStudiu { get; set; }

        public long ID_Facultate { get; set; }

        public string NumeIntreg { get; set; }

        public string DenumireDeAfisat
        {
            get
            {
                return string.Format("{0}/{1}/{2}/{3}/{4}/{5}/{6}", DenumireAnUniv, DenumireCicluInv, DenumireFormaInv, DenumireSpecializare, DenumireAnStudiu, string.IsNullOrEmpty(DenumireGrupa) ? string.Empty : DenumireGrupa, Denumire);
            }
        }

        public string DenumireDeAfisatFaraGrupa
        {
            get
            {
                return string.Format("{0}/{1}/{2}/{3}/{4}", DenumireCicluInv, DenumireFormaInv, DenumireSpecializare, DenumireAnStudiu, Denumire);
            }
        }

        public string ID_DetaliuPlanSemestru_ID_Grupa
        {
            get
            {
                return string.Format("{0}_{1}_{2}", ID_DetaliuPlanSemestru, ID_Grupa, ID_ProgramareExamen);
            }
        }

        public string DenumireMaterieSem { get; set; }

        public bool NoteFinalizate { get; set; }

        public bool NoteSalvate { get; set; }

        public string Username { get; set; }

        public string DenumireAnUniv { get; set; }

        public long ID_Nota { get; set; }

        public string NumeIntregStudent { get; set; }

        public string DenumireCFSA { get; set; }

        public string DenumireCFSA_NumeIntregStudent { get { return DenumireCFSA + " / " + NumeIntregStudent; } }

        public long ID_Student { get; set; }

        public string ID_Nota_Student_DPS_DPSS
        {
            get
            {
                return string.Format("{0}/{1}/{2}/{3}", ID_Nota, ID_Student, ID_DetaliuPlanSemestru, ID_DetaliuPlanSemestruStudent);
            }
        }

        public DateTime DataStartIntroNotaCazSpecial { get; set; }
        public DateTime DataFinalIntroNotaCazSpecial { get; set; }
        public int ID_TipAcordareNota { get; set; }
        public int UserID_Modificare { get; set; }
        public long ID_ProfesorCazSpecial { get; set; }

        public long ID_NotaCazSpecial { get; set; }

        public long ID_AsistentExamenCazSpecial { get; set; }
        public string NumeIntregAsistentExament { get; set; }

        public bool Tiparit { get; set; }
        public DateTime TiparitData { get; set; }
        public string TiparitUsername { get; set; }

        public bool TitularSemnat { get; set; }
        public DateTime TitularSemnatData { get; set; }
        public bool AsistentExamenSemnat { get; set; }
        public DateTime AsistentExamenSemnatData { get; set; }

        public string AsistentExamenSemnatUsername { get; set; }

        public string TitularSemnatUsername { get; set; }

        public bool ELimbaStraina { get; set; }

        public int TipVerificare { get; set; }

        public bool ESport {
            get
            {
                return (TipVerificare == 100 && (Denumire.ToLower().Contains("sport") || (Denumire.ToLower().Contains("educa") && Denumire.ToLower().Contains("fizic"))));
            }
        }

        public int ID_TipExaminare { get; set; }
        public string ListaID_Student { get; set; }
        public string ListaStudenti { get; set; }

        public string DenumireSesiuneExameneSpecializare { get; set; }

        public string DenumireFacultate { get; set; }

        public string ID_DPS_DPSS { get; set; }

        public bool NotaSalvata { get; set; }
        public bool NotaFinalizata { get; set; }
    }
}
