using System;
using System.Collections.Generic;
using UniApi.Models;
using UniApi.Dal.Repos;
using UniAPI.DAL.Repo;

namespace UniApi
{
    public class DetaliuPlanSemestruController
    {
        private readonly DetaliuPlanSemestruRepo _repo;

        public DetaliuPlanSemestruController()
        {
            _repo = new DetaliuPlanSemestruRepo();
        }

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
            return _repo.CentralizatorStatFListByCatedra(
                ID_Catedra,
                ID_AnUniv,
                NumarSemestruDinAn,
                AfiseazaMateriiCatedraCoordonatoare,
                AfiseazaMateriiCatedraPrestatoareCurs,
                AfiseazaMateriiCatedraPrestatoareAplicatii,
                AfiseazaNumaiMateriiCuOreDisponibile,
                FiltruTipCicluInvatamant,
                FiltruTipFormaInvatamant,
                AfiseazaNumaiMateriiIndividualePerStudent,
                ID_Scenariu
            );
        }

        public List<DetaliuPlanSemestruInfo> CentralizatorStatFRecalculareOre(long ID_Catedra, long ID_AnUniv)
        {
            return _repo.CentralizatorStatFRecalculareOre(ID_Catedra, ID_AnUniv);
        }

        public int DetaliuPlanSemestruAdd(DetaliuPlanSemestruInfo objDetaliuPlanSemestru)
        {
            return _repo.DetaliuPlanSemestruAdd(objDetaliuPlanSemestru);
        }

        public void DetaliuPlanSemestruDelete(long ID_DetaliuPlanSemestru)
        {
            _repo.DetaliuPlanSemestruDelete(ID_DetaliuPlanSemestru);
        }

        public DetaliuPlanSemestruInfo DetaliuPlanSemestruGet(long iD_DetaliuPlanSemestru)
        {
            return _repo.DetaliuPlanSemestruGet(iD_DetaliuPlanSemestru);
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByPlanSemestru(long iD_PlanSemestru)
        {
            return _repo.DetaliuPlanSemestruListByPlanSemestru(iD_PlanSemestru);
        }

        public List<DetaliuPlanSemestruInfo> DetaliuPlanSemestruListByMaterie(long iD_Materie)
        {
            return _repo.DetaliuPlanSemestruListByMaterie(iD_Materie);
        }

        public void DetaliuPlanSemestruUpdateMaterieSursaInDestinatie(long ID_MaterieSursa, long ID_MaterieDestinatie)
        {
            _repo.DetaliuPlanSemestruUpdateMaterieSursaInDestinatie(ID_MaterieSursa, ID_MaterieDestinatie);
        }

       
}
