using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class SalaInfo
    {

        public long ID_Sala { get; set; }
        public long ID_Corp { get; set; }
        public string Indicativ { get; set; }
        public string NrSala { get; set; }
        public string Alias { get; set; }
        public string Etaj { get; set; }
        public string DescriereDestinatie { get; set; }
        public float SuprafataM2 { get; set; }
        public int NrLocuri { get; set; }
        public long ID_TipDestinatieSala { get; set; }
        public string NumeDepartament { get; set; }
        public long ID_Facultate { get; set; }
        public string NrSalaSauAlias { get; set; } //Folosit pentru afisaj la GET->SalaListById_Corp
    }
}
