using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class JudeteController
    {
        private readonly JudeteRepo _repo;

        public JudeteController()
        {
            _repo = new JudeteRepo();
        }

        public JudeteInfo JudeteGet(string iD_Judet)
        {
            return _repo.JudeteGet(iD_Judet);
        }

        public JudeteInfo JudeteGetByID_N_Judet(int iD_N_Judet)
        {
            return _repo.JudeteGetByID_N_Judet(iD_N_Judet);
        }

        public List<JudeteInfo> JudeteList()
        {
            return _repo.JudeteList();
        }

        public List<JudeteInfo> JudeteListByCaractere(string Caractere, int TopN)
        {
            return _repo.JudeteListByCaractere(Caractere, TopN);
        }

        public int JudeteAdd(JudeteInfo objJudete)
        {
            return _repo.JudeteAdd(objJudete);
        }

        public void JudeteUpdate(JudeteInfo objJudete)
        {
            _repo.JudeteUpdate(objJudete);
        }

        public void JudeteDelete(JudeteInfo objJudete)
        {
            _repo.JudeteDelete(objJudete);
        }

        public JudeteInfo JudeteGetJudetByDenumire(string denumireJudet)
        {
            return _repo.JudeteGetJudetByDenumire(denumireJudet);
        }
    }
}
