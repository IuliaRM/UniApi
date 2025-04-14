using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
   

    public class AnunturiController : DnnApiController
    {
        private readonly IAnunturiRepo _repo = new AnunturiRepo();
        public AnunturiController()
        {

        }

        public AnunturiController(IAnunturiRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult AnunturiAdd([FromBody] AnunturiInfo anunturiInfo)
        {
            try
            {
                _repo.AnunturiAdd(anunturiInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AnunturiUpdate([FromBody] AnunturiInfo anunturiInfo)
        {
            try
            {
                _repo.AnunturiUpdate(anunturiInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AnunturiDelete(long idAnunt)
        {
            try
            {
                _repo.AnunturiDelete(idAnunt);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AnunturiGet(long idAnunt)
        {
            try
            {
                var result = _repo.AnunturiGet(idAnunt);
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
        public IHttpActionResult AnunturiGetByIdStudentAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                var result = _repo.AnunturiGetByIdStudentAnUniv(idStudent, idAnUniv);
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
        public IHttpActionResult AnunturiList()
        {
            try
            {
                var result = _repo.AnunturiList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AnunturiListByIdStudnetAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                var result = _repo.AnunturiListByIdStudnetAnUniv(idStudent, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AnunturiListByStudentAnUniv(long idStudent, long idAnUniv)
        {
            try
            {
                var result = _repo.AnunturiListByStudentAnUniv(idStudent, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AnunturiListByUsernameStudentAnUniv(string username, long idAnUniv)
        {
            try
            {
                var result = _repo.AnunturiListByUsernameStudentAnUniv(username, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
