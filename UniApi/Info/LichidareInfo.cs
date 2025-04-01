using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniApi.Info
{
    public class LichidareInfo
    {
        public long ID_Lichidare { get; set; }

        public string UsernameInitiereAGSIS { get; set; }

        public DateTime DataInitiere { get; set; }

        public long ID_Absolvent { get; set; }

        public long ID_StudentLichidare { get; set; }
        public string NumeIntreg { get; set; }

        public long ID_SpecializareLichidare { get; set; }
        public long ID_Specializare { get; set; }
        public string DenumireSpecializare { get; set; }

        public long ID_AnStudiu { get; set; }
        public string DenumireAnStudiu { get; set; }

        public long ID_TipCiclu { get; set; }
        public string DenumireCicluInv { get; set; }

        public long ID_AnUnivInitiereLichidare { get; set; }
        public string DenumireAnUniv { get; set; }

        public bool LichidatBiblioteca { get; set; }

        public string ComentariiBiblioteca { get; set; }

        public DateTime DataBiblioteca { get; set; }

        public string DenumireScurtaProgramStudiu { get; set; }

        public string UsernameBiblioteca { get; set; }

        public bool LichidatCamine { get; set; }

        public string ComentariiCamine { get; set; }

        public DateTime DataCamine { get; set; }

        public string UsernameCamine { get; set; }


        public decimal TotalTaxe { get; set; }
        public decimal TotalTaxePlatite { get; set; }
        public decimal TotalTaxeCamine { get; set; }
        public decimal TotalTaxePlatiteCamine { get; set; }



        public bool LichidatDepartament { get; set; }

        public string ComentariiDepartament { get; set; }
        public string UsernameDepartament { get; set; }

        public DateTime DataDepartament { get; set; }

        public bool LichidatErasmus { get; set; }

        public string ComentariiErasmus { get; set; }
        public string UsernameErasmus { get; set; }

        public DateTime DataErasmus { get; set; }

        public DateTime DataLichidareFinala { get; set; }
        public bool LichidareFinala { get; set; }

        public string DenumireCamin { get; set; }
        public string NumarCamera { get; set; }
        public long ID_Camera { get; set; }
        public long ID_Cazare { get; set; }
        public DateTime DataPanaCand { get; set; }
        public DateTime DataDeCand { get; set; }

        public string DenumireFacultate { get; set; }
        public string Telefon { get; set; }
        public long ID_Grupe { get; set; }
        public string DenumireGrupa { get; set; }

        public string DenumireLocalitateRMU { get; set; }
        public string DenumireJudetRMU { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }

    }
}
