using System;
using System.Collections.Generic;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ValoareTipBursaFacultateController
    {
        private readonly ValoareTipBursaFacultateRepo _repo;

        public ValoareTipBursaFacultateController()
        {
            _repo = new ValoareTipBursaFacultateRepo();
        }

        public long AddValoareTipBursaFacultate(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            return _repo.AddValoareTipBursaFacultate(valoareTipBursa);
        }

        public void UpdateValoareTipBursaFacultate(ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            _repo.UpdateValoareTipBursaFacultate(valoareTipBursa);
        }

        public void DeleteValoareTipBursaFacultate(long id)
        {
            _repo.DeleteValoareTipBursaFacultate(id);
        }

        public ValoareTipBursaFacultateInfo GetValoareTipBursaFacultate(long id)
        {
            return _repo.GetValoareTipBursaFacultate(id);
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateList()
        {
            return _repo.GetValoareTipBursaFacultateList();
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByTipBursa(long idTipBursa)
        {
            return _repo.GetValoareTipBursaFacultateByTipBursa(idTipBursa);
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByLuna(int numarLuna)
        {
            return _repo.GetValoareTipBursaFacultateByLuna(numarLuna);
        }

        public List<ValoareTipBursaFacultateInfo> GetValoareTipBursaFacultateByFacultate(long idFacultate)
        {
            return _repo.GetValoareTipBursaFacultateByFacultate(idFacultate);
        }
    }
}
