using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class DepartamentProfesorController : DnnApiController
    {
        private readonly IDepartamentProfesorRepo _repo = new DepartamentProfesorRepo();

        public DepartamentProfesorController()
        {

        }


        public DepartamentProfesorController(IDepartamentProfesorRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorGet(long idDepartamentProfesor)
        {
            try
            {
                var result = _repo.DepartamentProfesorGet(idDepartamentProfesor);
                return result != null ? (IHttpActionResult)Ok(result) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorGetByProfesor(long idProfesor)
        {
            try
            {
                var result = _repo.DepartamentProfesorGetByProfesor(idProfesor);
                return result != null ? (IHttpActionResult)Ok(result) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorList()
        {
            try
            {
                var list = _repo.DepartamentProfesorList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorListByDepartament(long idDepartament)
        {
            try
            {
                var list = _repo.DepartamentProfesorListByDepartament(idDepartament);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DepartamentProfesorListByProfesor(long idProfesor)
        {
            try
            {
                var list = _repo.DepartamentProfesorListByProfesor(idProfesor);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult DepartamentProfesorAdd([FromBody] DepartamentProfesorInfo info)
        {
            try
            {
                var id = _repo.DepartamentProfesorAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult DepartamentProfesorUpdate([FromBody] DepartamentProfesorInfo info)
        {
            try
            {
                _repo.DepartamentProfesorUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DepartamentProfesorDelete(long idDepartamentProfesor)
        {
            try
            {
                var existing = _repo.DepartamentProfesorGet(idDepartamentProfesor);
                if (existing == null)
                    return NotFound();

                _repo.DepartamentProfesorDelete(idDepartamentProfesor);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
