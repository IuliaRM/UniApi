using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
   public class CerereAdeverintaController : DnnApiController
    {
        private readonly ICerereAdeverintaRepo _repo = new CerereAdeverintaRepo();

        public CerereAdeverintaController()
        {

        }

        public CerereAdeverintaController(ICerereAdeverintaRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult CerereAdeverintaAdd([FromBody] CerereAdeverintaInfo info)
        {
            try
            {
                var id = _repo.CerereAdeverintaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult CerereAdeverintaAprobareByIdCerereAdeverinta(long idCerere)
        {
            try
            {
                _repo.CerereAdeverintaAprobareByIdCerereAdeverinta(idCerere);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult CerereAdeverintaAprobareByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                _repo.CerereAdeverintaAprobareByIdCerereIdAnUniv(idCerere, idAnUniv);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CerereAdeverintaDetaliiGetByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                var info = _repo.CerereAdeverintaDetaliiGetByIdCerereIdAnUniv(idCerere, idAnUniv);
                return Ok(info);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CerereAdeverintaDetaliiUpdate([FromBody] CerereAdeverintaInfo info)
        {
            try
            {
                _repo.CerereAdeverintaDetaliiUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CerereAdeverintaEchivalareGetByIdCerereIdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                var info = _repo.CerereAdeverintaEchivalareGetByIdCerereIdAnUniv(idCerere, idAnUniv);
                return Ok(info);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CerereAdeverintaEchivalareUpdate([FromBody] CerereAdeverintaInfo info)
        {
            try
            {
                _repo.CerereAdeverintaEchivalareUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CerereAdeverintaStergereUpdate(long idCerere)
        {
            try
            {
                _repo.CerereAdeverintaStergereUpdate(idCerere);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CerereAdeverintaSergeUpdate(long idCerere)
        {
            try
            {
                _repo.CerereAdeverintaSergeUpdate(idCerere);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult CerereAdeverintaTiparireByIdCerereAdevOdAnUniv(long idCerere, long idAnUniv)
        {
            try
            {
                _repo.CerereAdeverintaTiparireByIdCerereAdevOdAnUniv(idCerere, idAnUniv);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CerereAdeverintaTiparireByIdCerereAdevIdAnUnivUpdate(long idCerere, long idAnUniv)
        {
            try
            {
                _repo.CerereAdeverintaTiparireByIdCerereAdevIdAnUnivUpdate(idCerere, idAnUniv);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
