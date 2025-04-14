using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class DiplomaSupplementAdeverintaAbsolvireController : DnnApiController
    {
        private readonly IDiplomaSupplementAdeverintaAbsolvireRepo _repo = new DiplomaSupplementAdeverintaAbsolvireRepo();

        public DiplomaSupplementAdeverintaAbsolvireController()
        {

        }

        public DiplomaSupplementAdeverintaAbsolvireController(IDiplomaSupplementAdeverintaAbsolvireRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult StudentGet(long idStudent, long idFacultate, long idTipCiclu)
        {
            try
            {
                var result = _repo.StudentGet(idStudent, idFacultate, idTipCiclu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ClasamentGet(long idStudent, long idFacultate, long idPlanInvatamant)
        {
            try
            {
                var result = _repo.ClasamentGet(idStudent, idFacultate, idPlanInvatamant);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MedieGeneralaGet(long idStudent, long idFacultate, long idPlanInvatamant)
        {
            try
            {
                var result = _repo.MedieGeneralaGet(idStudent, idFacultate, idPlanInvatamant);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MedieFinalaGet(long idStudent, long idTipCiclu)
        {
            try
            {
                var result = _repo.MedieFinalaGet(idStudent, idTipCiclu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult SesiuneAbsolvireGet(long idStudent, long idTipCiclu)
        {
            try
            {
                var result = _repo.SesiuneAbsolvireGet(idStudent, idTipCiclu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult SpecializareGet(long idPlanInvatamant, long idStudent)
        {
            try
            {
                var result = _repo.SpecializareGet(idPlanInvatamant, idStudent);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MediiAnualeSiCrediteGet(long idStudent, long idPlanInvatamant)
        {
            try
            {
                var result = _repo.MediiAnualeSiCrediteGet(idStudent, idPlanInvatamant);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
