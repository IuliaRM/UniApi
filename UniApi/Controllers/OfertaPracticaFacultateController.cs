using System;
using System.Collections.Generic;
using UniTBv.AGSIS.Dal.Repos;
using UniTBv.AGSIS.Models;

namespace UniTBv.AGSIS.Controllers
{
    public class OfertaPracticaFacultateController
    {
        private readonly OfertaPracticaFacultateRepo _repo;

        public OfertaPracticaFacultateController()
        {
            _repo = new OfertaPracticaFacultateRepo();
        }

        public OfertaPracticaFacultate OfertaPracticaFacultateGet(long iD_OfertaPracticaFacultate)
        {
            return _repo.OfertaPracticaFacultateGet(iD_OfertaPracticaFacultate);
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetList()
        {
            return _repo.OfertaPracticaFacultateGetList();
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByFacAnStudSpecializDomFC(long iD_Facultate, long iD_AnStudiu, long iD_Specializare, long iD_Domeniu, long iD_FC, int status, DateTime dataValabilitate)
        {
            return _repo.OfertaPracticaFacultateGetListByFacAnStudSpecializDomFC(iD_Facultate, iD_AnStudiu, iD_Specializare, iD_Domeniu, iD_FC, status, dataValabilitate);
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByFacAnStudFC(long iD_Facultate, long iD_AnStudiu, long iD_FC, int status, DateTime dataValabilitate)
        {
            return _repo.OfertaPracticaFacultateGetListByFacAnStudFC(iD_Facultate, iD_AnStudiu, iD_FC, status, dataValabilitate);
        }

        public List<OfertaPracticaFacultate> OfertaPracticaFacultateGetListByIdOfertaPractica(long iD_OfertaPractica)
        {
            return _repo.OfertaPracticaFacultateGetListByIdOfertaPractica(iD_OfertaPractica);
        }

        public void OfertaPracticaFacultateAdd(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateAdd(objOfertaPracticaFacultate);
        }

        public void OfertaPracticaFacultateUpdate(OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateUpdate(objOfertaPracticaFacultate);
        }

        public void OfertaPracticaFacultateDelete(long iD_OfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateDelete(iD_OfertaPracticaFacultate);
        }
    }
}
