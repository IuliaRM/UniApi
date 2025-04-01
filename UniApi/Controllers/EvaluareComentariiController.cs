using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class EvaluareComentariiController : DnnApiController
    {
        private readonly EvaluareComentariiRepo _repo = new EvaluareComentariiRepo();

        [HttpGet]
        public IHttpActionResult ComentariiByDetaliuPlanSemestruGet(long ID_DetaliuPlanSemestru)
        {
            var comentarii = _repo.ComentariiByDetaliuPlanSemestruGet(ID_DetaliuPlanSemestru);
            return Ok(comentarii);
        }

        [HttpGet]
        public IHttpActionResult MedieAnStudiiGet(long ID_Student, long ID_PlanInvatamant)
        {
            var medieAnStudii = _repo.MedieAnStudiiGet(ID_Student, ID_PlanInvatamant);
            return Ok(medieAnStudii);
        }
    }
}
