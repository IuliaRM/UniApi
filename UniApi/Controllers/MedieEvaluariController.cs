using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;

namespace UniApi.Controllers
{
    public class MedieEvaluariController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult MedieEvaluariGet(long idDetaliuPlanSemestru)
        {
            var repo = new MedieEvaluariRepo();
            var result = repo.MedieEvaluariGet(idDetaliuPlanSemestru);
            return Ok(result);
        }
    }
}