using System;
using System.Collections.Generic;
using System.ComponentModel;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi
{
    public class ConferintaSectiuneController
    {
        private readonly ConferintaSectiuneRepo _repo;

        public ConferintaSectiuneController()
        {
            _repo = new ConferintaSectiuneRepo();
        }

        public ConferintaSectiuneInfo ConferintaSectiuneGet(long idConferintaSectiune)
        {
            return _repo.ConferintaSectiuneGet(idConferintaSectiune);
        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ConferintaSectiuneInfo> ConferintaSectiuneList()
        {
            return _repo.ConferintaSectiuneList();
        }

        [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
        public List<ConferintaSectiuneInfo> ConferintaSectiuneListByConferinta(long idConferinta)
        {
            return _repo.ConferintaSectiuneListByConferinta(idConferinta);
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public long ConferintaSectiuneAdd(ConferintaSectiuneInfo objConferintaSectiune)
        {
            return _repo.ConferintaSectiuneAdd(objConferintaSectiune);
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void ConferintaSectiuneUpdate(ConferintaSectiuneInfo objConferintaSectiune)
        {
            _repo.ConferintaSectiuneUpdate(objConferintaSectiune);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void ConferintaSectiuneDelete(long idConferintaSectiune)
        {
            _repo.ConferintaSectiuneDelete(idConferintaSectiune);
        }
    }
}
