using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi.Models;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class ContUtilizatorController
    {
        private readonly ContUtilizatorRepo _repo;

        public ContUtilizatorController()
        {
            _repo = new ContUtilizatorRepo();
        }

        public ContUtilizatorInfo ContUtilizatorGet(long idContUtilizator)
        {
            return _repo.ContUtilizatorGet(idContUtilizator);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public List<ContUtilizatorInfo> ContUtilizatorList()
        {
            return _repo.ContUtilizatorList();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ContUtilizatorInfo ContUtilizatorGetByCNP(string cnp)
        {
            return _repo.ContUtilizatorGetByCNP(cnp);
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public long ContUtilizatorAdd(ContUtilizatorInfo objContUtilizator)
        {
            return _repo.ContUtilizatorAdd(objContUtilizator);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void ContUtilizatorUpdate(ContUtilizatorInfo objContUtilizator)
        {
            _repo.ContUtilizatorUpdate(objContUtilizator);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void ContUtilizatorDelete(long idContUtilizator)
        {
            _repo.ContUtilizatorDelete(idContUtilizator);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void ContUtilizatorDeleteByCNP(string cnp)
        {
            _repo.ContUtilizatorDeleteByCNP(cnp);
        }
    }
}
