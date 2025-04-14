using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class EvaluareController : DnnApiController
    {
        private readonly IEvaluareRepo _repo = new EvaluareRepo();

        public EvaluareController()
        {

        }

        public EvaluareController(IEvaluareRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult EvaluareGetIdsByUserIDAndRole(int userId, string role, long idAnUniv)
        {
            try
            {
                var result = _repo.EvaluareGetIdsByUserIDAndRole(userId, role, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareGetRoleByUserId(int userId)
        {
            try
            {
                var result = _repo.EvaluareGetRoleByUserId(userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareGetRoleByUsername(string username)
        {
            try
            {
                var result = _repo.EvaluareGetRoleByUsername(username);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareListByIDDetaliuPlanSemestru(long idDetaliuPlanSemestru)
        {
            try
            {
                var result = _repo.EvaluareListByIDDetaliuPlanSemestru(idDetaliuPlanSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
