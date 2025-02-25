using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class DiplomaSupplementAdeverintaAbsolvireController
    {
        private readonly DiplomaSupplementAdeverintaAbsolvireRepo _repo;

        public DiplomaSupplementAdeverintaAbsolvireController()
        {
            _repo = new DiplomaSupplementAdeverintaAbsolvireRepo();
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo GetStudent(long ID_Student, long ID_Facultate, long ID_TipCiclu)
        {
            return _repo.GetStudent(ID_Student, ID_Facultate, ID_TipCiclu);
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo GetClasament(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            return _repo.GetClasament(ID_Student, ID_Facultate, ID_PlanInvatamant);
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieGenerala(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            return _repo.MedieGenerala(ID_Student, ID_Facultate, ID_PlanInvatamant);
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MedieFinala(long ID_Student, long ID_TipCiclu)
        {
            return _repo.MedieFinala(ID_Student, ID_TipCiclu);
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo SesiuneAbsolvire(long ID_Student, long ID_TipCiclu)
        {
            return _repo.SesiuneAbsolvire(ID_Student, ID_TipCiclu);
        }

        public PlanInvatamantInfo GetSpecializare(long ID_PlanInvatamant, long id_student)
        {
            return _repo.GetSpecializare(ID_PlanInvatamant, id_student);
        }

        public DiplomaSupplementAdeverintaAbsolvireInfo MediiInFiecareAnSiCredite(long ID_Student, long ID_PlanInvatamant)
        {
            return _repo.MediiInFiecareAnSiCredite(ID_Student, ID_PlanInvatamant);
        }
    }
}
