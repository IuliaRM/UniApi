using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PostProfesorController : DnnApiController
    {
        private readonly IPostProfesorRepo _repo = new PostProfesorRepo();

        public PostProfesorController()
        {

        }

        public PostProfesorController(IPostProfesorRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult PostProfesorGet(long idPostProfesor)
        {
            try
            {
                var result = _repo.PostProfesorGet(idPostProfesor);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListGet()
        {
            try
            {
                var result = _repo.PostProfesorListGet();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            try
            {
                var result = _repo.PostProfesorListByDetaliuPlanSemestruGet(idDetaliuPlanSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            try
            {
                var result = _repo.PostProfesorListByDetaliuPlanSemestruProfesorGet(idDetaliuPlanSemestruProfesor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByPostGet(long idPost)
        {
            try
            {
                var result = _repo.PostProfesorListByPostGet(idPost);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostProfesorListByProfesorGet(long idProfesor)
        {
            try
            {
                var result = _repo.PostProfesorListByProfesorGet(idProfesor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PostProfesorAdd([FromBody] PostProfesorInfo postProfesorInfo)
        {
            try
            {
                if (postProfesorInfo == null)
                    return BadRequest("Obiectul PostProfesorInfo nu poate fi null");

                var id = _repo.PostProfesorAdd(postProfesorInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult PostProfesorUpdate([FromBody] PostProfesorInfo postProfesorInfo)
        {
            try
            {
                if (postProfesorInfo == null)
                    return BadRequest("Obiectul PostProfesorInfo nu poate fi null");

                _repo.PostProfesorUpdate(postProfesorInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult PostProfesorDelete(long idPostProfesor)
        {
            try
            {
                _repo.PostProfesorDelete(idPostProfesor);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}