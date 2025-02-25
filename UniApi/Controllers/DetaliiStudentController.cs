using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi.Models;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class DetaliiStudentController
    {
        private readonly DetaliiStudentRepo _repo;

        public DetaliiStudentController()
        {
            _repo = new DetaliiStudentRepo();
        }

        public List<StudentDatePersonaleInfo> StudentListByIdAndAnUniv(List<long> listaID_Student, long idAnUniv)
        {
            return _repo.StudentListByIdAndAnUniv(listaID_Student, idAnUniv);
        }

        public bool UsernameExistent(string username)
        {
            return _repo.UsernameExistent(username);
        }

        public void StudentUserPassEmailAdd(long idStudent, string user, string pass, string email)
        {
            _repo.StudentUserPassEmailAdd(idStudent, user, pass, email);
        }

        public string StudentUsernameGetByCNP(string cnp)
        {
            return _repo.StudentUsernameGetByCNP(cnp);
        }

        public string StudentUsernameGetByNumePrenumeDataN(string nume, string prenume, DateTime data)
        {
            return _repo.StudentUsernameGetByNumePrenumeDataN(nume, prenume, data);
        }

        public string StudentParolaGetByUsername(string user)
        {
            return _repo.StudentParolaGetByUsername(user);
        }

        public void StudentParolaUpdateByUsername(string username)
        {
            _repo.StudentParolaUpdateByUsername(username);
        }
    }
}
