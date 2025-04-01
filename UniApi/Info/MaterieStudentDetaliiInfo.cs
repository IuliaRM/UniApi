using System;
using System.Data;
using System.Configuration;
using System.Web;


namespace UniApi.Info
{
    public partial class MaterieStudentDetaliiInfo
    {

        public MaterieStudentDetaliiInfo()
        {
        }

        public string DenumireAnUniv
        { get; set; }

        public string DenumireFacultate
        { get; set; }

        public string DenumireCicluInv
        { get; set; }

        public string DenumireFormaInv
        { get; set; }

        //public string DenumireDomeniu
        //{ get; set; }

        public string DenumireAnStudiu
        { get; set; }

        public string DenumireSpecializare
        { get; set; }

        public int NumarSemestru
        { get; set; }

        public string DenumireMaterie
        { get; set; }

        public ProfesorMaterieInfo Profesor
        { get; set; }
    }
}
