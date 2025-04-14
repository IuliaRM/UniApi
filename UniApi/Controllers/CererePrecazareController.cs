using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CererePrecazareController : DnnApiController
    {
        private readonly ICererePrecazareRepo _repo = new CererePrecazareRepo();

        public CererePrecazareController()
        {

        }

        public CererePrecazareController(ICererePrecazareRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult CererePrecazareAdd([FromBody] CererePrecazareInfo info)
        {
            try
            {
                var id = _repo.CererePrecazareAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CererePrecazareUpdate([FromBody] CererePrecazareInfo info)
        {
            try
            {
                _repo.CererePrecazareUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult CererePrecazareDelete(long idCererePrecazare)
        {
            try
            {
                _repo.CererePrecazareDelete(idCererePrecazare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareGet(long idCererePrecazare)
        {
            try
            {
                var cerere = _repo.CererePrecazareGet(idCererePrecazare);
                return cerere != null ? (IHttpActionResult)Ok(cerere) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareList()
        {
            try
            {
                var list = _repo.CererePrecazareList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByStudent(long idStudent)
        {
            try
            {
                var list = _repo.CererePrecazareListByStudent(idStudent);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByStudentComplet(long idStudent, long idAnUniv)
        {
            try
            {
                var list = _repo.CererePrecazareListByStudentComplet(idStudent, idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByCamera(long idCamera)
        {
            try
            {
                var list = _repo.CererePrecazareListByCamera(idCamera);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByStudentUsername(string username)
        {
            try
            {
                var list = _repo.CererePrecazareListByStudentUsername(username);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListStudentCompletByFacultate(long idFacultate)
        {
            try
            {
                var list = _repo.CererePrecazareListStudentCompletByFacultate(idFacultate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListStudentCompletByFCFSAnUniv(long idFacultate, long idCamin, long idAnUniv)
        {
            try
            {
                var list = _repo.CererePrecazareListStudentCompletByFCFSAnUniv(idFacultate, idCamin, idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareGetByStudentIdAnUniversitar(long idStudent, long idAnUniv)
        {
            try
            {
                var cerere = _repo.CererePrecazareGetByStudentIdAnUniversitar(idStudent, idAnUniv);
                return cerere != null ? (IHttpActionResult)Ok(cerere) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
