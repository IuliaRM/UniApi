using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruController : DnnApiController
    {
        private readonly IDetaliuPlanSemestruRepo _repo = new DetaliuPlanSemestruRepo();

        public DetaliuPlanSemestruController()
        {

        }

        public DetaliuPlanSemestruController(IDetaliuPlanSemestruRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruGet(id));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPost]
        public IHttpActionResult AddOrUpdate([FromBody] DetaliuPlanSemestruInfo info)
        {
            try
            {
                var id = _repo.DetaliuPlanSemestruAddOrUpdate(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(long id)
        {
            try
            {
                var existing = _repo.DetaliuPlanSemestruGet(id);
                if (existing == null)
                    return NotFound();

                _repo.DetaliuPlanSemestruDelete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteByMaterieOrdine(long idMaterie, int ordine)
        {
            try
            {
                _repo.DetaliuPlanSemestruDeleteByMaterieOrdine(idMaterie, ordine);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult GetByUserIDProfesor(long userId)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruGetByUserIDProfesor(userId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult GetDinCentralizator(long idCentralizator)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruGetDinCentralizator(idCentralizator));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult ImportDinIntranet()
        {
            try
            {
                var result = _repo.DetaliuPlanSemestruImportDinIntranetPlanMaterie_Prestator();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByAnUnivCicluForma(long idAnUniv, long idCiclu, long idForma)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByAnUnivCicluForma(idAnUniv, idCiclu, idForma));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByMaterie(long idMaterie)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByMaterie(idMaterie));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByPlanSemestru(long idPlanSemestru)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByPlanSemestru(idPlanSemestru));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByPlanSemestruCriteriu2(long idPlanSemestru)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByPlanSemestruCriteriu2(idPlanSemestru));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByPlanSemestruStudent(long idStudent)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByPlanSemestruStudent(idStudent));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByPlanSemestruStudentNeNull(long idStudent)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByPlanSemestruStudentNeNull(idStudent));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByProfesorSemestru(long idProfesor, long idSemestru)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByProfesorSemestru(idProfesor, idSemestru));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByProfesorTitularAnUniv(long idProfesor, long idAnUniv)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByProfesorTitularAnUniv(idProfesor, idAnUniv));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListBySpecializare(long idSpecializare)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListBySpecializare(idSpecializare));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByStudent(long idStudent)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByStudent(idStudent));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByStudentAnIdAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByStudentAnIdAnUniv(idStudent, idAnUniv));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ListByStudentShowProfesori(long idStudent)
        {
            try
            {
                return Ok(_repo.DetaliuPlanSemestruListByStudentShowProfesori(idStudent));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
