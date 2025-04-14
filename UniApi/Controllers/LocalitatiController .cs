using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{
    public class LocalitatiController : DnnApiController
    {
        private readonly ILocalitatiRepo _repo = new LocalitatiRepo();

        public LocalitatiController()
        {

        }

        public LocalitatiController(ILocalitatiRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult LocalitatiGet(string idLocalitate)
        {
            try
            {
                var result = _repo.LocalitatiGet(idLocalitate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocalitatiByID_N_LocalitateGet(int idNLocalitate)
        {
            try
            {
                var result = _repo.LocalitatiGetByID_N_Localitate(idNLocalitate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocalitatiByDenumireIdJudetGet(string denumireLocalitate, string idJudet)
        {
            try
            {
                var result = _repo.LocalitatiGetByDenumireIdJudet(denumireLocalitate, idJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocalitatiListByCaractereDenumireIdJudetGet(string caractere, string idJudet)
        {
            try
            {
                var result = _repo.LocalitatiListByCaractereDenumireIdJudet(caractere, idJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocalitatiListByJudetGet(string idJudet)
        {
            try
            {
                var result = _repo.LocalitatiListByJudet(idJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LocalitatiAdd([FromBody] LocalitatiInfo info)
        {
            try
            {
                var id = _repo.LocalitatiAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult LocalitatiUpdate([FromBody] LocalitatiInfo info)
        {
            try
            {
                _repo.LocalitatiUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult LocalitatiDelete([FromBody] LocalitatiInfo info)
        {
            try
            {
                _repo.LocalitatiDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}