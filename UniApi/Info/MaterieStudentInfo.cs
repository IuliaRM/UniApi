using System;
using System.Data;
using System.Collections.Generic;


namespace UniApi.Info
{
    public partial class MaterieStudentInfo
    {
        public long ID_DetaliuPlanSemestru
        { get; set; }

        public string DenumireAnStudiu
        { get; set; }

        //public int NumarSemestru
        //{ get; set; }
            
        public string DenumireMaterie
        { get; set; }

        //public string DenumireAnUniv
        //{ get; set; }

        public string ID_AnUniv
        { get; set; }
        
        public List<ProfesorMaterieInfo> Profesori
        { get; set; }
    }
}
