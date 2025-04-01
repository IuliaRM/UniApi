using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public partial class CerereAdeverintaController
    {
        private readonly CerereAdeverintaRepo _repository = new CerereAdeverintaRepo();

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public long CerereAdeverintaAdd(CerereAdeverintaInfo cerereAdevInfo)
        {
            return _repository.CerereAdeverintaAdd(cerereAdevInfo);
        }

        public List<CerereAdeverintaInfo> CerereAdeverintaList(List<long> ID_Student, long ID_AnUniv)
        {
            return _repository.CerereAdeverintaList(ID_Student, ID_AnUniv);
        }

        public List<MotivCerereAdevInfo> MotivCerereAdevList()
        {
            return _repository.MotivCerereAdevList();
        }

        public List<TipCerereAdeverintaInfo> TipCerereAdeverintaList()
        {
            return _repository.TipCerereAdeverintaList();
        }

        // Other methods call corresponding methods from the repository
    }
}
