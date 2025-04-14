using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruProfesorController : DnnApiController
    {
        private readonly IDetaliuPlanSemestruProfesorRepo _repo = new DetaliuPlanSemestruProfesorRepo();

        public DetaliuPlanSemestruProfesorController()
        {

        }

        public DetaliuPlanSemestruProfesorController(IDetaliuPlanSemestruProfesorRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
       
        public IHttpActionResult DetaliuPlanSemestruProfesorGet(long id)
        {
            try
            {
                var result = _repo.DetaliuPlanSemestruProfesorGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorList()
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesor(long idProfesor, long idAnUniv, long idScenariu)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListByProfesor(idProfesor, idAnUniv, idScenariu);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByTipOrePredate(long idTipOrePredate)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListByTipOrePredate(idTipOrePredate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesorComplet(long idProfesor, long idAnUniv, long idScenariu)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListByProfesorComplet(idProfesor, idAnUniv, idScenariu);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(idDetaliuPlanSemestru);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long idDomeniu, long idSpecializare, int nrSemestru)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(idDomeniu, idSpecializare, nrSemestru);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesorSpecializare(long idProfesor, long idDomeniu, long idSpecializare, int nrSemestru)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorListByProfesorSpecializare(idProfesor, idDomeniu, idSpecializare, nrSemestru);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult DetaliuPlanSemestruProfesorAdd([FromBody] DetaliuPlanSemestruProfesorInfo info)
        {
            try
            {
                var id = _repo.DetaliuPlanSemestruProfesorAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult DetaliuPlanSemestruProfesorUpdate([FromBody] DetaliuPlanSemestruProfesorInfo info)
        {
            try
            {
                _repo.DetaliuPlanSemestruProfesorUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruProfesorDelete(long id)
        {
            try
            {
                var existing = _repo.DetaliuPlanSemestruProfesorGet(id);
                if (existing == null)
                    return NotFound();

                _repo.DetaliuPlanSemestruProfesorDelete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
