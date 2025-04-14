using System;
using System.Web.Http;
using DotNetNuke.Security;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    public class AnUniversitarLunaBursaController : DnnApiController
    {
        private readonly IAnUniversitarLunaBursaRepo _repo = new AnUniversitarLunaBursaRepo();

        public AnUniversitarLunaBursaController() { }

        public AnUniversitarLunaBursaController(IAnUniversitarLunaBursaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult AnUniversitarLunaBursaListaByAnUniv(long idAnUniv)
        {
            try
            {
                var result = _repo.AnUniversitarLunaBursaListaByAnUniv(idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult AnUniversitarLunaBursaGetByAnUniversitarNumarLuna(long idAnUniv, int numarLuna)
        {
            try
            {
                var result = _repo.AnUniversitarLunaBursaGetByAnUniversitarNumarLuna(idAnUniv, numarLuna);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult AnUniversitarLunaBursaGetByAnUnivOrdineLuna(long idAnUniv, int ordineLuna)
        {
            try
            {
                var result = _repo.AnUniversitarLunaBursaGetByAnUnivOrdineLuna(idAnUniv, ordineLuna);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        public IHttpActionResult AnUniversitarLunaBursaUpdate([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            try
            {
                if (lunaBursaInfo == null)
                    return BadRequest("Obiectul AnUniversitarLunaBursaInfo nu poate fi null");

                _repo.AnUniversitarLunaBursaUpdate(lunaBursaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        public IHttpActionResult AnUniversitarLunaBursaUpdateInchisaByAnUnivNumarLuna([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            try
            {
                if (lunaBursaInfo == null)
                    return BadRequest("Obiectul AnUniversitarLunaBursaInfo nu poate fi null");

                _repo.AnUniversitarLunaBursaUpdateInchisaByAnUnivNumarLuna(lunaBursaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
        public IHttpActionResult AnUniversitarLunaBursaUpdateInchisaByAnUniv([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            try
            {
                if (lunaBursaInfo == null)
                    return BadRequest("Obiectul AnUniversitarLunaBursaInfo nu poate fi null");

                _repo.AnUniversitarLunaBursaUpdateInchisaByAnUniv(lunaBursaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}