using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{

    [AllowAnonymous]
    public class AnUniversitarController : DnnApiController
    {
        private readonly IAnUniversitarRepo _repo= new AnUniversitarRepo();

        public  AnUniversitarController()
        {
            
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarGet(long idAnUniv)
        {
            try
            {
                var result = _repo.AnUniversitarGet(idAnUniv);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AnUniversitarAdd([FromBody] AnUniversitarInfo anUniversitarInfo)
        {
            try
            {
                if (anUniversitarInfo == null)
                    return BadRequest("Obiectul AnUniversitarInfo nu poate fi null");

                var id = _repo.AnUniversitarAdd(anUniversitarInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AnUniversitarDelete(long idAnUniv)
        {
            try
            {
                _repo.AnUniversitarDelete(idAnUniv);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarListByUsername(string username)
        {
            try
            {
                var result = _repo.AnUniversitarListByUsername(username);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
