using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class LocalitatiController
    {
        private readonly LocalitatiRepo _repo;

        public LocalitatiController()
        {
            _repo = new LocalitatiRepo();
        }

        public LocalitatiInfo LocalitatiGet(string iD_Localitate)
        {
            return _repo.LocalitatiGet(iD_Localitate);
        }

        public LocalitatiInfo LocalitatiGetByID_N_Localitate(int iD_N_Localitate)
        {
            return _repo.LocalitatiGetByID_N_Localitate(iD_N_Localitate);
        }

        public List<LocalitatiInfo> LocalitatiList()
        {
            return _repo.LocalitatiList();
        }

        public int LocalitatiAdd(LocalitatiInfo objLocalitati)
        {
            return _repo.LocalitatiAdd(objLocalitati);
        }

        public void LocalitatiUpdate(LocalitatiInfo objLocalitati)
        {
            _repo.LocalitatiUpdate(objLocalitati);
        }

        public void LocalitatiDelete(LocalitatiInfo objLocalitati)
        {
            _repo.LocalitatiDelete(objLocalitati);
        }

        public LocalitatiInfo LocalitatiGetBydenumireIdJudet(string denumireLocalitate, string idjudet)
        {
            return _repo.LocalitatiGetBydenumireIdJudet(denumireLocalitate, idjudet);
        }

        public List<LocalitatiInfo> LocalitatiListByJudet(string idjudet)
        {
            return _repo.LocalitatiListByJudet(idjudet);
        }

        public List<LocalitatiInfo> LocalitatiListByCaractereDenumireIdJudet(string CaractereDenumireLocalitate, string idjudet)
        {
            return _repo.LocalitatiListByCaractereDenumireIdJudet(CaractereDenumireLocalitate, idjudet);
        }
    }
}
