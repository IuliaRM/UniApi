using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class DepartamentProfesorController
    {
        private readonly DepartamentProfesorRepo _repo;

        public DepartamentProfesorController()
        {
            _repo = new DepartamentProfesorRepo();
        }

        public DepartamentProfesorInfo DepartamentProfesorGet(long idDepartamentProfesor)
        {
            return _repo.DepartamentProfesorGet(idDepartamentProfesor);
        }

        public DepartamentProfesorInfo DepartamentProfesorGetByProfesor(long idProfesor)
        {
            return _repo.DepartamentProfesorGetByProfesor(idProfesor);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<DepartamentProfesorInfo> DepartamentProfesorList()
        {
            return _repo.DepartamentProfesorList();
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<DepartamentProfesorInfo> DepartamentProfesorListByDepartament(long idDepartament)
        {
            return _repo.DepartamentProfesorListByDepartament(idDepartament);
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<DepartamentProfesorInfo> DepartamentProfesorListByProfesor(long idProfesor)
        {
            return _repo.DepartamentProfesorListByProfesor(idProfesor);
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int DepartamentProfesorAdd(DepartamentProfesorInfo objDepartamentProfesor)
        {
            return _repo.DepartamentProfesorAdd(objDepartamentProfesor);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void DepartamentProfesorUpdate(DepartamentProfesorInfo objDepartamentProfesor)
        {
            _repo.DepartamentProfesorUpdate(objDepartamentProfesor);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DepartamentProfesorDelete(long idDepartamentProfesor)
        {
            _repo.DepartamentProfesorDelete(idDepartamentProfesor);
        }
    }
}
