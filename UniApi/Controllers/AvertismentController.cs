using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    

    public class AvertismentController : DnnApiController
    {
        private readonly IAvertismentRepo _repo = new AvertismentRepo();

        public AvertismentController()
        {
        }

        public AvertismentController(IAvertismentRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult AvertismentAdd([FromBody] AvertismentInfo avertisment)
        {
            try
            {
                int id = _repo.AvertismentAdd(avertisment);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AvertismentUpdate([FromBody] AvertismentInfo avertisment)
        {
            try
            {
                _repo.AvertismentUpdate(avertisment);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AvertismentDelete(long idAvertisment)
        {
            try
            {
                _repo.AvertismentDelete(idAvertisment);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AvertismentGet(long idAvertisment)
        {
            try
            {
                var avertisment = _repo.AvertismentGet(idAvertisment);
                if (avertisment == null)
                    return NotFound();

                return Ok(avertisment);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AvertismentList()
        {
            try
            {
                var list = _repo.AvertismentList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByCazare(long idCazare)
        {
            try
            {
                var list = _repo.AvertismentListByCazare(idCazare);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByTipAvertisment(long idTipAvertisment)
        {
            try
            {
                var list = _repo.AvertismentListByTipAvertisment(idTipAvertisment);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
