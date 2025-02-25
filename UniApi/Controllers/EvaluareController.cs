using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class EvaluareController
    {
        private readonly EvaluareRepo _repo;

        public EvaluareController()
        {
            _repo = new EvaluareRepo();
        }

        public List<MaterieStudentInfo> GetMaterieListByUsernameAndIdAnUniv(string username, long ID_AnUniv, int NrSemestruEvaluare)
        {
            return _repo.GetMaterieListByUsernameAndIdAnUniv(username, ID_AnUniv, NrSemestruEvaluare);
        }

        public MaterieStudentDetaliiInfo GetMaterieStudentDetalii(long ID_CodEvaluare)
        {
            return _repo.GetMaterieStudentDetalii(ID_CodEvaluare);
        }

        public long InsertChestionarEvaluat(long ID_Chestionar, long ID_CodEvaluare)
        {
            return _repo.InsertChestionarEvaluat(ID_Chestionar, ID_CodEvaluare);
        }

        public void InsertEvaluare(CriteriuEvaluareRaspunsInfo ceri)
        {
            _repo.InsertEvaluare(ceri);
        }

        public List<CriteriuEvaluareInfo> GetCriteriiEvaluareWithVarianteRaspuns(long id_codevaluare)
        {
            return _repo.GetCriteriiEvaluareWithVarianteRaspuns(id_codevaluare);
        }

        public CriteriuEvaluareVarianteRaspunsInfo GetCriteriuEvaluareVarianteRaspunsById(long id_CriteriuEvaluareVarianteRaspuns)
        {
            return _repo.GetCriteriuEvaluareVarianteRaspunsById(id_CriteriuEvaluareVarianteRaspuns);
        }

        public List<ProfesorMaterieInfo> GetCodEvaluareListBySpecializareSemestru(long idSpecializare, int nrSemestru)
        {
            return _repo.GetCodEvaluareListBySpecializareSemestru(idSpecializare, nrSemestru);
        }

        public bool TestAdaugareChestionar(long codEvaluare)
        {
            return _repo.TestAdaugareChestionar(codEvaluare);
        }

        public string GetRoleByUserId(int userId)
        {
            return _repo.GetRoleByUserId(userId);
        }

        public string GetRoleByUsername(string username)
        {
            return _repo.GetRoleByUsername(username);
        }

        public List<string> GetCodEvaluareListByUsernameRole(string username, string role, long ID_AnUniv)
        {
            return _repo.GetCodEvaluareListByUsernameRole(username, role, ID_AnUniv);
        }

        public List<string> GetSpecializariListByUsernameRole(string username, string role, long idAnUniv)
        {
            return _repo.GetSpecializariListByUsernameRole(username, role, idAnUniv);
        }
    }
}
