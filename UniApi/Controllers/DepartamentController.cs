using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class DepartamentController
    {
        private readonly DepartamentRepo _repo;

        public DepartamentController()
        {
            _repo = new DepartamentRepo();
        }

        public DepartamentInfo DepartamentGet(long idDepartament)
        {
            return _repo.DepartamentGet(idDepartament);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<DepartamentInfo> DepartamentList()
        {
            return _repo.DepartamentList();
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public int DepartamentAdd(DepartamentInfo objDepartament)
        {
            return _repo.DepartamentAdd(objDepartament);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void DepartamentUpdate(DepartamentInfo objDepartament)
        {
            _repo.DepartamentUpdate(objDepartament);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DepartamentDelete(long idDepartament)
        {
            _repo.DepartamentDelete(idDepartament);
        }
    }
}
