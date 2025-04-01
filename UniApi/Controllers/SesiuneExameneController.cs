using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;

namespace UniApi.Controllers
{
    public class SesiuneExameneController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult SesiuneExameneGet(long idSesiuneExamene)
        {
            var repo = new SesiuneExameneRepo();
            var result = repo.SesiuneExameneGet(idSesiuneExamene);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProgramareExamenListBySesiuneExameneGet(long idSesiuneExamene)
        {
            var repo = new SesiuneExameneRepo();
            var result = repo.ProgramareExamenListBySesiuneExameneGet(idSesiuneExamene);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProgramareExamenListBySesiuneExameneDTGet(long idSesiuneExamene)
        {
            var repo = new SesiuneExameneRepo();
            var result = repo.ProgramareExamenListBySesiuneExameneDTGet(idSesiuneExamene);
            return Ok(result);
        }
    }
}
