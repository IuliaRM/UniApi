using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DiplomaSupplementAdeverintaAbsolvireController : DnnApiController
    {
        private readonly DiplomaSupplementAdeverintaAbsolvireRepo _repo = new DiplomaSupplementAdeverintaAbsolvireRepo();

        [HttpGet]
        public IHttpActionResult StudentGet(long ID_Student, long ID_Facultate, long ID_TipCiclu)
        {
            var student = _repo.StudentGet(ID_Student, ID_Facultate, ID_TipCiclu);
            return Ok(student);
        }

        [HttpGet]
        public IHttpActionResult ClasamentGet(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            var clasament = _repo.ClasamentGet(ID_Student, ID_Facultate, ID_PlanInvatamant);
            return Ok(clasament);
        }

        [HttpGet]
        public IHttpActionResult MedieGeneralaGet(long ID_Student, long ID_Facultate, long ID_PlanInvatamant)
        {
            var medie = _repo.MedieGeneralaGet(ID_Student, ID_Facultate, ID_PlanInvatamant);
            return Ok(medie);
        }

        [HttpGet]
        public IHttpActionResult MedieFinalaGet(long ID_Student, long ID_TipCiclu)
        {
            var medie = _repo.MedieFinalaGet(ID_Student, ID_TipCiclu);
            return Ok(medie);
        }

        [HttpGet]
        public IHttpActionResult SesiuneAbsolvireGet(long ID_Student, long ID_TipCiclu)
        {
            var sesiune = _repo.SesiuneAbsolvireGet(ID_Student, ID_TipCiclu);
            return Ok(sesiune);
        }

        [HttpGet]
        public IHttpActionResult SpecializareGet(long ID_PlanInvatamant, long ID_Student)
        {
            var specializare = _repo.SpecializareGet(ID_PlanInvatamant, ID_Student);
            return Ok(specializare);
        }

        [HttpGet]
        public IHttpActionResult MediiAnualeSiCrediteGet(long ID_Student, long ID_PlanInvatamant)
        {
            var medii = _repo.MediiAnualeSiCrediteGet(ID_Student, ID_PlanInvatamant);
            return Ok(medii);
        }
    }
}
