using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruProfesorCuplajController
    {
        private readonly DetaliuPlanSemestruProfesorCuplajRepo _repo;

        public DetaliuPlanSemestruProfesorCuplajController()
        {
            _repo = new DetaliuPlanSemestruProfesorCuplajRepo();
        }

        public DetaliuPlanSemestruProfesorCuplajInfo GetById(long ID_DetaliuPlanSemestruProfesorCuplaj)
        {
            return _repo.GetById(ID_DetaliuPlanSemestruProfesorCuplaj);
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetAll()
        {
            return _repo.GetAll();
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetByDetaliuPlanSemestruProfesor(long ID_DetaliuPlanSemestruProfesor)
        {
            return _repo.GetByDetaliuPlanSemestruProfesor(ID_DetaliuPlanSemestruProfesor);
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetByDetaliuPlanSemestruProfesor(long ID_DetaliuPlanSemestruProfesor, long ID_Cuplaj)
        {
            return _repo.GetByDetaliuPlanSemestruProfesor(ID_DetaliuPlanSemestruProfesor, ID_Cuplaj);
        }

        public List<DetaliuPlanSemestruProfesorCuplajInfo> GetByDetaliuCuplaj(long ID_DetaliuCuplaj)
        {
            return _repo.GetByDetaliuCuplaj(ID_DetaliuCuplaj);
        }

        public int Add(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            return _repo.Add(objDetaliuPlanSemestruProfesorCuplaj);
        }

        public void Update(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            _repo.Update(objDetaliuPlanSemestruProfesorCuplaj);
        }

        public void Delete(DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            _repo.Delete(objDetaliuPlanSemestruProfesorCuplaj);
        }

        public void DeleteByPostProfesor(long ID_DetaliuPlanSemestruProfesorCuplaj, long ID_PostProfesor)
        {
            _repo.DeleteByPostProfesor(ID_DetaliuPlanSemestruProfesorCuplaj, ID_PostProfesor);
        }
    }
}
