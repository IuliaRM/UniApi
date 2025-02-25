using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Models;

namespace UniApi.Controllers
{
    public class EvaluareComentariiController
    {
        private readonly EvaluareComentariiRepo _repo;

        public EvaluareComentariiController()
        {
            _repo = new EvaluareComentariiRepo();
        }

        public List<EvaluareComentariiInfo> GetComentariiByDetaliuPlanSemestru(long iD_DetaliuPlanSemestru)
        {
            return _repo.GetComentariiByDetaliuPlanSemestru(iD_DetaliuPlanSemestru);
        }

        // If you want to implement the update functionality as well:
        /*
        public void UpdateTipCriteriuEvaluare(TipCriteriuEvaluareInfo objTipCriteriuEvaluare)
        {
            _repo.UpdateTipCriteriuEvaluare(objTipCriteriuEvaluare);
        }
        */
    }
}
