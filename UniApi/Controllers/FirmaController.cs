using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class FirmaController
    {
        private readonly FirmaRepo _repo;

        public FirmaController()
        {
            _repo = new FirmaRepo();
        }

        public Firma GetFirma(long iD_Firma)
        {
            return _repo.GetFirma(iD_Firma);
        }

        public List<Firma> GetFirmaList()
        {
            return _repo.GetFirmaList();
        }

        public Firma GetFirmaByUserIdPortal(int iD_UserPortal)
        {
            return _repo.GetFirmaByUserIdPortal(iD_UserPortal);
        }

        public void AddFirma(Firma objFirma)
        {
            _repo.AddFirma(objFirma);
        }

        public void UpdateFirma(Firma objFirma)
        {
            _repo.UpdateFirma(objFirma);
        }
    }
}
