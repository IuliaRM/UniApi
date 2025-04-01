using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruStudentController : DnnApiController
    {
        private readonly DetaliuPlanSemestruStudentRepo _repo = new DetaliuPlanSemestruStudentRepo();

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemetruGet(long ID_DetaliuPlanSemestru)
        {
            var detaliu = _repo.DetaliuPlanSemetruGet(ID_DetaliuPlanSemestru);
            return Ok(detaliu);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemetruListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            var lista = _repo.DetaliuPlanSemetruListByStudentGet(ID_Student, ID_AnUniv);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult RestanteListByStudentFacultateGet(long ID_Student, long ID_Facultate, long ID_TipCicluInv, long ID_TipFormaInv, long ID_Specializare)
        {
            var lista = _repo.RestanteListByStudentFacultateGet(ID_Student, ID_Facultate, ID_TipCicluInv, ID_TipFormaInv, ID_Specializare);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult RestanteListBySpecializareGet(long ID_AnUniv, long ID_Specializare, long ID_Grupa, long ID_AnStudiu, string FiltruTipIntrareIesire, bool ExcludeAnUnivCurent)
        {
            var lista = _repo.RestanteListBySpecializareGet(ID_AnUniv, ID_Specializare, ID_Grupa, ID_AnStudiu, FiltruTipIntrareIesire, ExcludeAnUnivCurent);
            return Ok(lista);
        }

        [HttpPost]
        public IHttpActionResult AddOrUpdatePost([FromBody] DetaliuPlanSemestruStudentInfo obj)
        {
            long id = _repo.AddOrUpdatePost(obj);
            return Ok(id);
        }
    }
}
