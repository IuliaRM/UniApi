using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    
    public class DetaliuPlanSemestruProfesorCuplajController : DnnApiController
    {
        private readonly IDetaliuPlanSemestruProfesorCuplajRepo _repo = new DetaliuPlanSemestruProfesorCuplajRepo();

        public DetaliuPlanSemestruProfesorCuplajController()
        {

        }

        public DetaliuPlanSemestruProfesorCuplajController(IDetaliuPlanSemestruProfesorCuplajRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajGet(long id)
        {
            try
            {
                var result = _repo.DetaliuPlanSemestruProfesorCuplajGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajList()
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorCuplajList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor(long idDetaliu)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorCuplajListByDetaliuPlanSemestruProfesor(idDetaliu);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajListByDetaliuCuplaj(long idCuplaj)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruProfesorCuplajListByDetaliuCuplaj(idCuplaj);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajAdd([FromBody] DetaliuPlanSemestruProfesorCuplajInfo info)
        {
            try
            {
                var id = _repo.DetaliuPlanSemestruProfesorCuplajAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajUpdate([FromBody] DetaliuPlanSemestruProfesorCuplajInfo info)
        {
            try
            {
                _repo.DetaliuPlanSemestruProfesorCuplajUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajDelete(long id)
        {
            try
            {
                var existing = _repo.DetaliuPlanSemestruProfesorCuplajGet(id);
                if (existing == null)
                    return NotFound();

                _repo.DetaliuPlanSemestruProfesorCuplajDelete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajDeleteByPostProfesor(long idCuplaj, long idPostProfesor)
        {
            try
            {
                _repo.DetaliuPlanSemestruProfesorCuplajDeleteByPostProfesor(idCuplaj, idPostProfesor);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
