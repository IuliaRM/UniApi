using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class NotaController
    {
        private readonly NotaRepo _repo;

        public NotaController()
        {
            _repo = new NotaRepo();
        }

        public NotaInfo NotaGet(long idNota)
        {
            return _repo.NotaGet(idNota);
        }

        public List<NotaInfo> NotaGetList()
        {
            return _repo.NotaGetList();
        }

        public List<NotaInfo> NotaGetListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            return _repo.NotaGetListByDetaliuPlanSemestru(idDetaliuPlanSemestru);
        }

        public List<NotaInfo> NotaGetListByStudent(long idStudent, long idAnUniv)
        {
            return _repo.NotaGetListByStudent(idStudent, idAnUniv);
        }

        public long NotaAdd(NotaInfo notaInfo)
        {
            return _repo.NotaAdd(notaInfo);
        }

        public void NotaUpdate(NotaInfo notaInfo)
        {
            _repo.NotaUpdate(notaInfo);
        }

        public void NotaDelete(long idNota)
        {
            _repo.NotaDelete(idNota);
        }

        public List<NotaInfo> NotaGetListByUserAnuniversitar(int userId, long idAnUniversitar)
        {
            return _repo.NotaGetListByUserAnuniversitar(userId, idAnUniversitar);
        }

        public List<NotaInfo> NotaGetListByUsernameAnUniversitar(string username, long idAnUniversitar)
        {
            return _repo.NotaGetListByUsernameAnUniversitar(username, idAnUniversitar);
        }

        public List<NotaInfo> NotaGetListByStudent(long idStudent)
        {
            return _repo.NotaGetListByStudent(idStudent);
        }

        public NotaInfo NotaGetByDetaliuPlanAndId(long idDetaliuPlanSemestru, long idNota)
        {
            return _repo.NotaGetByDetaliuPlanAndId(idDetaliuPlanSemestru, idNota);
        }

        public void NotaEchivaleaza(long idDetaliuPlanSemestruRestanta, long idNotaCuCareSeEchivaleaza, long idStudent, int idUtilizator)
        {
            _repo.NotaEchivaleaza(idDetaliuPlanSemestruRestanta, idNotaCuCareSeEchivaleaza, idStudent, idUtilizator);
        }
    }
}
