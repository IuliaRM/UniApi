using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class LichidareController
    {
        private readonly LichidareRepo _repo;

        public LichidareController()
        {
            _repo = new LichidareRepo();
        }

        public void LichidareSecretariatMerge(long ID_Lichidare, long ID_Absolvent, long ID_Student, long ID_AnUniv, long ID_Specializare, string usernameInitiere)
        {
            _repo.LichidareSecretariatMerge(ID_Lichidare, ID_Absolvent, ID_Student, ID_AnUniv, ID_Specializare, usernameInitiere);
        }

        public void LichidareInitiereAutomata()
        {
            _repo.LichidareInitiereAutomata();
        }

        public void LichidareSecretariatDeselecteaza(long ID_Lichidare, string username, string coloanaDebifata)
        {
            _repo.LichidareSecretariatDeselecteaza(ID_Lichidare, username, coloanaDebifata);
        }

        public LichidareInfo LichidareStudentGetByID_Lichidare(long ID_Lichidare)
        {
            return _repo.LichidareStudentGetByID_Lichidare(ID_Lichidare);
        }
    }
}
