using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class EvaluareProfesorController
    {
        private readonly EvaluareProfesorRepo _repo;

        public EvaluareProfesorController()
        {
            _repo = new EvaluareProfesorRepo();
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorList()
        {
            return _repo.GetEvaluareProfesorList();
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListNrChestionareCompletate(long ID_AnUniv, int NrSemestru)
        {
            return _repo.GetEvaluareProfesorListNrChestionareCompletate(ID_AnUniv, NrSemestru);
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListNrChestionareCompletate_Prof(long ID_AnUniv, int NrSemestru)
        {
            return _repo.GetEvaluareProfesorListNrChestionareCompletate_Prof(ID_AnUniv, NrSemestru);
        }

        public List<EvaluareProfesorInfo> GetEvaluareProfesorListProfiDeEvaluat(long ID_AnUniv, int NrSemestru)
        {
            return _repo.GetEvaluareProfesorListProfiDeEvaluat(ID_AnUniv, NrSemestru);
        }

        public long AddEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            return _repo.AddEvaluareProfesor(objEvaluareProfesor);
        }

        public void UpdateEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            _repo.UpdateEvaluareProfesor(objEvaluareProfesor);
        }

        public void DeleteEvaluareProfesor(EvaluareProfesorInfo objEvaluareProfesor)
        {
            _repo.DeleteEvaluareProfesor(objEvaluareProfesor);
        }

        public void DeleteEvaluareProfesorBySpecializareSemestru(long id_prof, long spec, int nrsem, long id_dps)
        {
            _repo.DeleteEvaluareProfesorBySpecializareSemestru(id_prof, spec, nrsem, id_dps);
        }

        public void GenerateCoduriEvaluare(long ID_AnUniv, int NrSemestru)
        {
            _repo.GenerateCoduriEvaluare(ID_AnUniv, NrSemestru);
        }
    }
}
