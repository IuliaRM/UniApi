using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class ConferintaController : DnnApiController
    {
        private readonly IConferintaRepo _repo = new ConferintaRepo();

        public ConferintaController()
        {

        }

            public ConferintaController(IConferintaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult ConferintaGet(long idConferinta)
        {
            try
            {
                var conferinta = _repo.ConferintaGet(idConferinta);
                return conferinta != null ? (IHttpActionResult)Ok(conferinta) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaList()
        {
            try
            {
                var list = _repo.ConferintaList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaListByAnCalendaristic(int anCalendaristic)
        {
            try
            {
                var list = _repo.ConferintaListByAnCalendaristic(anCalendaristic);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaListByFacultate(long idFacultate)
        {
            try
            {
                var list = _repo.ConferintaListByFacultate(idFacultate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaListByTipConferinta(long idTipConferinta)
        {
            try
            {
                var list = _repo.ConferintaListByTipConferinta(idTipConferinta);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult ConferintaUpdate([FromBody] ConferintaInfo conferinta)
        {
            try
            {
                _repo.ConferintaUpdate(conferinta);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
