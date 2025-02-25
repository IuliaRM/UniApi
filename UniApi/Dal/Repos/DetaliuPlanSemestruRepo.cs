using System;
using System.Collections.Generic;
using UniApi.Models;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;

namespace UniApi.Dal.Repos
{
    public class DetaliuPlanSemestruRepo
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

        public List<DetaliuPlanSemestruInfo> CentralizatorStatFListByCatedra(
            long ID_Catedra,
            long ID_AnUniv,
            long NumarSemestruDinAn,
            bool AfiseazaMateriiCatedraCoordonatoare,
            bool AfiseazaMateriiCatedraPrestatoareCurs,
            bool AfiseazaMateriiCatedraPrestatoareAplicatii,
            bool AfiseazaNumaiMateriiCuOreDisponibile,
            string FiltruTipCicluInvatamant,
            string FiltruTipFormaInvatamant,
            bool AfiseazaNumaiMateriiIndividualePerStudent,
            long ID_Scenariu)
        {
            // Call to database with SqlHelper (similar to your existing code)
            return CBO.FillCollection<DetaliuPlanSemestruInfo>(
                SqlHelper.ExecuteReader(_connectionString, "Centralizator_StatF_ListByCatedra",
                    new object[] { ID_Catedra, ID_AnUniv, NumarSemestruDinAn, AfiseazaMateriiCatedraCoordonatoare,
                                   AfiseazaMateriiCatedraPrestatoareCurs, AfiseazaMateriiCatedraPrestatoareAplicatii,
                                   AfiseazaNumaiMateriiCuOreDisponibile, FiltruTipCicluInvatamant, FiltruTipFormaInvatamant,
                                   AfiseazaNumaiMateriiIndividualePerStudent, ID_Scenariu }));
        }

        // Implement other methods following the same structure
    }
}
