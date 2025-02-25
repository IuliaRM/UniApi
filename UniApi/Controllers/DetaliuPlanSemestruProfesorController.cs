using System;
using System.Collections.Generic;
using UniApi.Models;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class DetaliuPlanSemestruProfesorController
    {
        private readonly DetaliuPlanSemestruProfesorRepo _repo;

        public DetaliuPlanSemestruProfesorController()
        {
            _repo = new DetaliuPlanSemestruProfesorRepo();
        }

        public DetaliuPlanSemestruProfesorInfo DetaliuPlanSemestruProfesorGet(long ID_DetaliuPlanSemestruProfesor)
        {
            return _repo.DetaliuPlanSemestruProfesorGet(ID_DetaliuPlanSemestruProfesor);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorList()
        {
            return _repo.DetaliuPlanSemestruProfesorList();
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesor(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            return _repo.DetaliuPlanSemestruProfesorListByProfesor(ID_Profesor, ID_AnUniv, ID_Scenariu);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByTipOrePredate(long ID_TipOrePredate)
        {
            return _repo.DetaliuPlanSemestruProfesorListByTipOrePredate(ID_TipOrePredate);
        }

        public int DetaliuPlanSemestruProfesorAdd(DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            return _repo.DetaliuPlanSemestruProfesorAdd(objDetaliuPlanSemestruProfesor);
        }

        public void DetaliuPlanSemestruProfesorUpdate(DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            _repo.DetaliuPlanSemestruProfesorUpdate(objDetaliuPlanSemestruProfesor);
        }

        public void DetaliuPlanSemestruProfesorDelete(long ID_DetaliuPlanSemestruProfesor)
        {
            _repo.DetaliuPlanSemestruProfesorDelete(ID_DetaliuPlanSemestruProfesor);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorComplet(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            return _repo.DetaliuPlanSemestruProfesorListByProfesorComplet(ID_Profesor, ID_AnUniv, ID_Scenariu);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long ID_DetaliuPlanSemestru)
        {
            return _repo.DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(ID_DetaliuPlanSemestru);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            return _repo.DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(ID_Domeniu, ID_Specializare, nrSem);
        }

        public List<DetaliuPlanSemestruProfesorInfo> DetaliuPlanSemestruProfesorListByProfesorSpecializare(long ID_Profesor, long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            return _repo.DetaliuPlanSemestruProfesorListByProfesorSpecializare(ID_Profesor, ID_Domeniu, ID_Specializare, nrSem);
        }
    }
}
