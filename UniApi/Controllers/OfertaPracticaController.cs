using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Collections.Generic;

namespace UniApi.Controllers
{

    public class OfertaPracticaController : DnnApiController
    {
        private readonly IOfertaPracticaRepo _repo = new OfertaPracticaRepo();

        public OfertaPracticaController()
        {

        }

        public OfertaPracticaController(IOfertaPracticaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaGet(long idOfertaPractica)
        {
            try
            {
                var result = _repo.OfertaPracticaGet(idOfertaPractica);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaList()
        {
            try
            {
                var result = _repo.OfertaPracticaListGet();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaListByUserIDPortal(int idUserPortal)
        {
            try
            {
                var result = _repo.OfertaPracticaListByUserIDPortalGet(idUserPortal);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult OfertaPracticaAdd([FromBody] OfertaPractica info)
        {
            try
            {
                var id = _repo.OfertaPracticaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult OfertaPracticaUpdate([FromBody] OfertaPractica info)
        {
            try
            {
                _repo.OfertaPracticaUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult OfertaPracticaDelete(long idOfertaPractica)
        {
            try
            {
                _repo.OfertaPracticaDelete(idOfertaPractica);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
