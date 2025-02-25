using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AbsolvireProgramProbaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaGet(long idAbsolvireProgramProba)
        {
            var repo = new AbsolvireProgramProbaRepo();
            var result = repo.AbsolvireProgramProbaGet(idAbsolvireProgramProba);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaList()
        {
            var repo = new AbsolvireProgramProbaRepo();
            var result = repo.AbsolvireProgramProbaList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire)
        {
            var repo = new AbsolvireProgramProbaRepo();
            var result = repo.AbsolvireProgramProbaListByPachetAbsolvire(idPachetAbsolvire);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AbsolvireProgramProbaAdd([FromBody] AbsolvireProgramProbaInfo probaInfo)
        {
            var repo = new AbsolvireProgramProbaRepo();
            var id = repo.AbsolvireProgramProbaAdd(probaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AbsolvireProgramProbaUpdate([FromBody] AbsolvireProgramProbaInfo probaInfo)
        {
            var repo = new AbsolvireProgramProbaRepo();
            repo.AbsolvireProgramProbaUpdate(probaInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireProgramProbaDelete(long idAbsolvireProgramProba)
        {
            var repo = new AbsolvireProgramProbaRepo();
            repo.AbsolvireProgramProbaDelete(idAbsolvireProgramProba);
            return Ok();
        }
    }
}
