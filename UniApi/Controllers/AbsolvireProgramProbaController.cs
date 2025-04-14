using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
  

    public class AbsolvireProgramProbaController : DnnApiController
    {
        private readonly IAbsolvireProgramProbaRepo _repo =new AbsolvireProgramProbaRepo ();

        public AbsolvireProgramProbaController()
        {

        }


        public AbsolvireProgramProbaController(IAbsolvireProgramProbaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaGet(long idAbsolvireProgramProba)
        {
            try
            {
                var result = _repo.AbsolvireProgramProbaGet(idAbsolvireProgramProba);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaList()
        {
            try
            {
                var result = _repo.AbsolvireProgramProbaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaListByPachetAbsolvire(long idPachetAbsolvire)
        {
            try
            {
                var result = _repo.AbsolvireProgramProbaListByPachetAbsolvire(idPachetAbsolvire);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireProgramProbaListByPacheteAbsolvireSesiuneAbsolvire(long idPachetAbsolvire, long idSesiune)
        {
            try
            {
                var result = _repo.AbsolvireProgramProbaListByPacheteAbsolvireSesiuneAbsolvire(idPachetAbsolvire, idSesiune);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireProgramProbaAdd([FromBody] AbsolvireProgramProbaInfo probaInfo)
        {
            try
            {
                if (probaInfo == null)
                    return BadRequest("Obiectul AbsolvireProgramProbaInfo nu poate fi null");

                var id = _repo.AbsolvireProgramProbaAdd(probaInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AbsolvireProgramProbaUpdate([FromBody] AbsolvireProgramProbaInfo probaInfo)
        {
            try
            {
                if (probaInfo == null)
                    return BadRequest("Obiectul AbsolvireProgramProbaInfo nu poate fi null");

                _repo.AbsolvireProgramProbaUpdate(probaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireProgramProbaDelete(long idAbsolvireProgramProba)
        {
            try
            {
                _repo.AbsolvireProgramProbaDelete(idAbsolvireProgramProba);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
