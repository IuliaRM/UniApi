using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{

    public class DetaliuPlanSemestruStudentController : DnnApiController
    {
        private readonly IDetaliuPlanSemestruStudentRepo _repo = new DetaliuPlanSemestruStudentRepo();

        public DetaliuPlanSemestruStudentController()
        {

        }

        public DetaliuPlanSemestruStudentController(IDetaliuPlanSemestruStudentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruStudentGet(long id)
        {
            try
            {
                var result = _repo.DetaliuPlanSemestruStudentGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruStudentListByStudent(long idStudent, long idAnUniv)
        {
            try
            {
                var list = _repo.DetaliuPlanSemestruStudentListByStudent(idStudent, idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult DetaliuPlanSemestruStudentAddOrUpdate([FromBody] DetaliuPlanSemestruStudentInfo info)
        {
            try
            {
                var id = _repo.DetaliuPlanSemestruStudentAddOrUpdate(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruStudentDelete(long id)
        {
            try
            {
                var existing = _repo.DetaliuPlanSemestruStudentGet(id);
                if (existing == null)
                    return NotFound();

                _repo.DetaliuPlanSemestruStudentDelete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
