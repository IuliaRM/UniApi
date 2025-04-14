using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class PostController : DnnApiController
    {
        private readonly IPostRepo _repo = new PostRepo();

        public PostController()
        {

        }

        [HttpGet]
        public IHttpActionResult PostGet(long idPost)
        {
            try
            {
                var result = _repo.PostGet(idPost);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PostAdd([FromBody] PostInfo postInfo)
        {
            try
            {
                if (postInfo == null)
                    return BadRequest("PostInfo cannot be null");

                var id = _repo.PostAdd(postInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult PostUpdate([FromBody] PostInfo postInfo)
        {
            try
            {
                if (postInfo == null)
                    return BadRequest("PostInfo cannot be null");

                _repo.PostUpdate(postInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpDelete]
        public IHttpActionResult PostDelete([FromBody] PostInfo postInfo)
        {
            try
            {
                if (postInfo == null)
                    return BadRequest("PostInfo cannot be null");

                _repo.PostDelete(postInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostList()
        {
            try
            {
                var result = _repo.PostList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostListByAnUniversitar(long idAnUniv, long idScenariu)
        {
            try
            {
                var result = _repo.PostListByAnUniversitar(idAnUniv, idScenariu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostListByCatedra(long idCatedra, long idAnUniv, long idScenariu)
        {
            try
            {
                var result = _repo.PostListByCatedra(idCatedra, idAnUniv, idScenariu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostListByCuplaj(long idCuplaj, long idAnUniv, long idScenariu)
        {
            try
            {
                var result = _repo.PostListByCuplaj(idCuplaj, idAnUniv, idScenariu);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostCalculProcentOreConventionaleByPostProfesor(long idPost)
        {
            try
            {
                var result = _repo.PostCalculProcentOreConventionaleByPostProfesor(idPost);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostCalculProcentOreConventionaleByProfesor(long idProfesor, long idAnUniv)
        {
            try
            {
                var result = _repo.PostCalculProcentOreConventionaleByProfesor(idProfesor, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PostCalculProcentOreConventionaleByProfesorSemestru(long idProfesor, long idAnUniv, int semestru)
        {
            try
            {
                var result = _repo.PostCalculProcentOreConventionaleByProfesorSemestru(idProfesor, idAnUniv, semestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}