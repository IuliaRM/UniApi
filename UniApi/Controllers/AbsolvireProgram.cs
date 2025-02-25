using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers

{
    public class AbsolvireProgramController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AbsolvireProgramGet(long idAbsolvireProgram)
        {
            var repo = new AbsolvireProgramRepo();
            var result = repo.AbsolvireProgramGet(idAbsolvireProgram);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramListBySpecializare(long idSpecializare)
        {
            var repo = new AbsolvireProgramRepo();
            var result = repo.AbsolvireProgramListBySpecializare(idSpecializare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramList()
        {
            var repo = new AbsolvireProgramRepo();
            var result = repo.AbsolvireProgramList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramListByAnUniversitar(long idAnUniversitar)
        {
            var repo = new AbsolvireProgramRepo();
            var result = repo.AbsolvireProgramListByAnUniversitar(idAnUniversitar);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AbsolvireProgramAdd([FromBody] AbsolvireProgramInfo programInfo)
        {
            var repo = new AbsolvireProgramRepo();
            var id = repo.AbsolvireProgramAdd(programInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AbsolvireProgramUpdate([FromBody] AbsolvireProgramInfo programInfo)
        {
            var repo = new AbsolvireProgramRepo();
            repo.AbsolvireProgramUpdate(programInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireProgramDeleteBySpecializare(long idSpecializare)
        {
            var repo = new AbsolvireProgramRepo();
            repo.AbsolvireProgramDeleteBySpecializare(idSpecializare);
            return Ok();
        }
    }
}
