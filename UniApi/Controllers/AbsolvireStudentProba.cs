using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
   

    public class AbsolvireStudentProbaController : DnnApiController
    {
        private readonly IAbsolvireStudentProbaRepo _repo = new AbsolvireStudentProbaRepo();

        public AbsolvireStudentProbaController()
        {

        }

        public AbsolvireStudentProbaController(IAbsolvireStudentProbaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaGet(long idStudentAbsolventProba)
        {
            try
            {
                var result = _repo.AbsolvireStudentProbaGet(idStudentAbsolventProba);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaList()
        {
            try
            {
                var result = _repo.AbsolvireStudentProbaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaListByStudent(long idAbsolvireStudent)
        {
            try
            {
                var result = _repo.AbsolvireStudentProbaListByStudent(idAbsolvireStudent);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentProbaGetByAbsolventProgramProba(long idAbsolvireStudent, long idAbsolvireProgramProba)
        {
            try
            {
                var result = _repo.AbsolvireStudentProbaGetByAbsolventProgramProba(idAbsolvireStudent, idAbsolvireProgramProba);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentProbaAdd([FromBody] AbsolvireStudentProbaInfo probaInfo)
        {
            try
            {
                if (probaInfo == null)
                    return BadRequest("Obiectul AbsolvireStudentProbaInfo nu poate fi null");

                var id = _repo.AbsolvireStudentProbaAdd(probaInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentProbaUpdate([FromBody] AbsolvireStudentProbaInfo probaInfo)
        {
            try
            {
                if (probaInfo == null)
                    return BadRequest("Obiectul AbsolvireStudentProbaInfo nu poate fi null");

                _repo.AbsolvireStudentProbaUpdate(probaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentProbaDelete(long idStudentAbsolventProba)
        {
            try
            {
                _repo.AbsolvireStudentProbaDelete(idStudentAbsolventProba);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
