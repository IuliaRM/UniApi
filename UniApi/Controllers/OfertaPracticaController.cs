using System.Collections.Generic;
using UniTBv.AGSIS.Dal.Repos;
using UniTBv.AGSIS.Models;

namespace UniTBv.AGSIS.Controllers
{
    public class OfertaPracticaController
    {
        private readonly OfertaPracticaRepo _repo;

        public OfertaPracticaController()
        {
            _repo = new OfertaPracticaRepo();
        }

        public OfertaPractica OfertaPracticaGet(long iD_OfertaPractica)
        {
            return _repo.OfertaPracticaGet(iD_OfertaPractica);
        }

        public List<OfertaPractica> OfertaPracticaGetList()
        {
            return _repo.OfertaPracticaGetList();
        }

        public List<OfertaPractica> OfertaPracticaGetListByUserIDPortal(int iD_UserPortal)
        {
            return _repo.OfertaPracticaGetListByUserIDPortal(iD_UserPortal);
        }

        public void OfertaPracticaAdd(OfertaPractica objOfertaPractica)
        {
            _repo.OfertaPracticaAdd(objOfertaPractica);
        }

        public void OfertaPracticaUpdate(OfertaPractica objOfertaPractica)
        {
            _repo.OfertaPracticaUpdate(objOfertaPractica);
        }

        public void OfertaPracticaDelete(long iD_OfertaPractica)
        {
            _repo.OfertaPracticaDelete(iD_OfertaPractica);
        }
    }
}
