using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class IntervalPunctajBursaController
    {
        private readonly IntervalPunctajBursaRepo _repo;

        public IntervalPunctajBursaController()
        {
            _repo = new IntervalPunctajBursaRepo();
        }

        public List<IntervalPunctajBursaInfo> IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(long iD_TipBursa, long ID_AnUniv, long ID_AnUnivBursa, long NumarSemestruBursa, long NumarSemestruCalculPunctaj, long ID_FC, long ID_FCForma, long ID_Domeniu, long ID_AnStudiu, long ID_Specializare)
        {
            return _repo.IntervalPunctajBursaListByTipBursaAnUnivFCFDAS(iD_TipBursa, ID_AnUniv, ID_AnUnivBursa, NumarSemestruBursa, NumarSemestruCalculPunctaj, ID_FC, ID_FCForma, ID_Domeniu, ID_AnStudiu, ID_Specializare);
        }

        public void IntervalPunctajBursaDelete(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            _repo.IntervalPunctajBursaDelete(objIntervalPunctajBursa);
        }

        public IntervalPunctajBursaInfo IntervalPunctajBursaGet(long iD_IntervalPunctajBursa)
        {
            return _repo.IntervalPunctajBursaGet(iD_IntervalPunctajBursa);
        }

        public long IntervalPunctajBursaAddOrUpdate(IntervalPunctajBursaInfo objIntervalPunctajBursa)
        {
            return _repo.IntervalPunctajBursaAddOrUpdate(objIntervalPunctajBursa);
        }
    }
}
