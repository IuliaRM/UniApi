using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class IntervalChitantaController
    {
        private readonly IntervalChitantaRepo _repo;

        public IntervalChitantaController()
        {
            _repo = new IntervalChitantaRepo();
        }

        public IntervalChitantaInfo GetIntervalChitanta(long iD_IntervalChitanta)
        {
            return _repo.GetIntervalChitanta(iD_IntervalChitanta);
        }

        public IntervalChitantaInfo GetIntervalChitantaByUtilizator(int ID_Utilizator)
        {
            return _repo.GetIntervalChitantaByUtilizator(ID_Utilizator);
        }

        public IntervalChitantaInfo GetUltimulNumarDeChitanta(int ID_Utilizator)
        {
            return _repo.GetUltimulNumarDeChitanta(ID_Utilizator);
        }

        public List<IntervalChitantaInfo> GetIntervalChitantaList()
        {
            return _repo.GetIntervalChitantaList();
        }

        public List<IntervalChitantaInfo> GetIntervalChitantaListByUtilizator(int ID_Utilizator)
        {
            return _repo.GetIntervalChitantaListByUtilizator(ID_Utilizator);
        }

        public long AddIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            return _repo.AddIntervalChitanta(objIntervalChitanta);
        }

        public void UpdateIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            _repo.UpdateIntervalChitanta(objIntervalChitanta);
        }

        public void DeleteIntervalChitanta(IntervalChitantaInfo objIntervalChitanta)
        {
            _repo.DeleteIntervalChitanta(objIntervalChitanta);
        }

        public long SeteazaUrmatorulNumarDeChitanta(int ID_Utilizator)
        {
            return _repo.SeteazaUrmatorulNumarDeChitanta(ID_Utilizator);
        }
    }
}
