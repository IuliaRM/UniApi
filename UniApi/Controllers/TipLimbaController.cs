using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class TipLimbaController : DnnApiController
    {
        private readonly ITipLimbaRepo _repo = new TipLimbaRepo();

        public TipLimbaController() { }

        public TipLimbaController(ITipLimbaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult TipLimbaGet(long idTipLimba)
        {
            try
            {
                var result = _repo.TipLimbaGet(idTipLimba);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log error (e.g., using ILogger)
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult TipLimbaListGet()
        {
            try
            {
                var result = _repo.TipLimbaListGet();
                return Ok(result); // Returnează lista chiar dacă e goală
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult TipLimbaAdd([FromBody] TipLimbaInfo tipLimbaInfo)
        {
            try
            {
                if (tipLimbaInfo == null)
                    return BadRequest("Obiectul TipLimbaInfo nu poate fi null");

                var id = _repo.TipLimbaAdd(tipLimbaInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult TipLimbaUpdate([FromBody] TipLimbaInfo tipLimbaInfo)
        {
            try
            {
                if (tipLimbaInfo == null)
                    return BadRequest("Obiectul TipLimbaInfo nu poate fi null");

                _repo.TipLimbaUpdate(tipLimbaInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult TipLimbaDelete(long idTipLimba)
        {
            try
            {
                _repo.TipLimbaDelete(idTipLimba);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}