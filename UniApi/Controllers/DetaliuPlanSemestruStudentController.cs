using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruStudentController
    {
        private readonly DetaliuPlanSemestruStudentRepo _repo;

        public DetaliuPlanSemestruStudentController()
        {
            _repo = new DetaliuPlanSemestruStudentRepo();
        }

        public DetaliuPlanSemestruStudentInfo GetById(long iD_DetaliuPlanSemestru)
        {
            return _repo.GetById(iD_DetaliuPlanSemestru);
        }

        public List<DetaliuPlanSemestruStudentInfo> GetListByStudent(long ID_Student, long ID_AnUniv)
        {
            return _repo.GetListByStudent(ID_Student, ID_AnUniv);
        }

        public List<DetaliuPlanSemestruInfo> GetRestanteListByStudentFacultate(long id_student, long id_facultate, long id_tipCicluInv, long id_tipFormaInv, long id_specializare)
        {
            return _repo.GetRestanteListByStudentFacultate(id_student, id_facultate, id_tipCicluInv, id_tipFormaInv, id_specializare);
        }

        public List<DetaliuPlanSemestruStudentInfo> GetRestanteListBySpecializare(long ID_AnUniv, long ID_Specializare, long ID_Grupa, long ID_AnStudiu, string FiltruTipIntrareIesire, bool ExcludeAnUnivCurent)
        {
            return _repo.GetRestanteListBySpecializare(ID_AnUniv, ID_Specializare, ID_Grupa, ID_AnStudiu, FiltruTipIntrareIesire, ExcludeAnUnivCurent);
        }

        public long AddOrUpdate(DetaliuPlanSemestruStudentInfo obj)
        {
            return _repo.AddOrUpdate(obj);
        }
    }
}
