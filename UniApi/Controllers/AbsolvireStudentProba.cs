using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AbsolvireStudentProbaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaGet(long idStudentAbsolventProba)
        {
            var repo = new AbsolvireStudentProbaRepo();
            var result = repo.AbsolvireStudentProbaGet(idStudentAbsolventProba);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaListByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            var repo = new AbsolvireStudentProbaRepo();
            var result = repo.AbsolvireStudentProbaListByAbsolventProgramProba(idAbsolvireStudent, idAbsolvireProgramProba);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaList()
        {
            var repo = new AbsolvireStudentProbaRepo();
            var result = repo.AbsolvireStudentProbaList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaListByStudent(long idAbsolvireStudent)
        {
            var repo = new AbsolvireStudentProbaRepo();
            var result = repo.AbsolvireStudentProbaListByStudent(idAbsolvireStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentProbaAdd([FromBody] AbsolvireStudentProbaInfo probaInfo)
        {
            var repo = new AbsolvireStudentProbaRepo();
            var id = repo.AbsolvireStudentProbaAdd(probaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentProbaUpdate([FromBody] AbsolvireStudentProbaInfo probaInfo)
        {
            var repo = new AbsolvireStudentProbaRepo();
            repo.AbsolvireStudentProbaUpdate(probaInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentProbaDelete(long idStudentAbsolventProba)
        {
            var repo = new AbsolvireStudentProbaRepo();
            repo.AbsolvireStudentProbaDelete(idStudentAbsolventProba);
            return Ok();
        }
    }
}
