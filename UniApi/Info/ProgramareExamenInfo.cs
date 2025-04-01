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
using Newtonsoft.Json;
using System;


namespace UniApi.Info
{
    public class ProgramareExamenInfo
    {

        public long ID_ProgramareExamen { get; set; }


        public long ID_DetaliuPlanSemestru { get; set; }


        public long ID_SesiuneExamene { get; set; }


        public long ID_Grupa { get; set; }


        public DateTime Data { get; set; }


        public string Sala { get; set; }


        public int ID_TipExaminare { get; set; }

        public long ID_AnUniv { get; set; }
        public long ID_SesiuneExameneSpecializare { get; set; }
        public long ID_Specializare { get; set; }
        public long ID_AnStud { get; set; }
        public long ID_ProfesorTitularCurs { get; set; }

        public bool Tiparit { get; set; }
        public DateTime TiparitData { get; set; }
        public string TiparitUsername { get; set; }

        public DateTime TitularSemnatData { get; set; }
        public DateTime AsistentExamenSemnatData { get; set; }


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
        public long ID_AsistentExamenSN { get; set; }

        [JsonIgnore]
        public string NumeFisierCompletTitular { get; set; }

        [JsonIgnore]
        public string NumeFisierCompletAsistentExamen { get; set; }

        [JsonIgnore]
        public string NumeFisierFinal { get; set; }

        [JsonIgnore]
        public long ID_AnUnivSesiuneExamene { get; set; }

        [JsonIgnore]
        public bool NoteSalvate { get; set; }

        [JsonIgnore]
        public bool NoteFinalizate { get; set; }

    }
}

