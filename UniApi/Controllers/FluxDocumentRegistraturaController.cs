using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class FluxDocumentRegistraturaController
    {
        private readonly FluxDocumentRegistraturaRepo _repo;

        public FluxDocumentRegistraturaController()
        {
            _repo = new FluxDocumentRegistraturaRepo();
        }

        public FluxDocumentRegistraturaInfo GetFluxDocumentRegistratura(long iD_FluxDocReg)
        {
            return _repo.GetFluxDocumentRegistratura(iD_FluxDocReg);
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaList()
        {
            return _repo.GetFluxDocumentRegistraturaList();
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaListByDocumentRegistratura(long iD_DocReg, int AnCalendaristic)
        {
            return _repo.GetFluxDocumentRegistraturaListByDocumentRegistratura(iD_DocReg, AnCalendaristic);
        }

        public long AddFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            return _repo.AddFluxDocumentRegistratura(objFluxDocumentRegistratura);
        }

        public void UpdateFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            _repo.UpdateFluxDocumentRegistratura(objFluxDocumentRegistratura);
        }

        public void DeleteFluxDocumentRegistratura(FluxDocumentRegistraturaInfo objFluxDocumentRegistratura)
        {
            _repo.DeleteFluxDocumentRegistratura(objFluxDocumentRegistratura);
        }

        public List<FluxDocumentRegistraturaInfo> GetFluxDocumentRegistraturaStatisticiByAn(int AnCalendaristic)
        {
            return _repo.GetFluxDocumentRegistraturaStatisticiByAn(AnCalendaristic);
        }
    }
}
