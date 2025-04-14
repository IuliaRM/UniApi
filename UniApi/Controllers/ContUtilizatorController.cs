using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class ContUtilizatorController : DnnApiController
    {
        private readonly IContUtilizatorRepo _repo = new ContUtilizatorRepo();

        public ContUtilizatorController()
        {

        }
        public ContUtilizatorController(IContUtilizatorRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult ContUtilizatorGet(long idContUtilizator)
        {
            try
            {
                var utilizator = _repo.ContUtilizatorGet(idContUtilizator);
                return utilizator != null ? (IHttpActionResult)Ok(utilizator) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ContUtilizatorGetByCNP(string cnp)
        {
            try
            {
                var utilizator = _repo.ContUtilizatorGetByCNP(cnp);
                return utilizator != null ? (IHttpActionResult)Ok(utilizator) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ContUtilizatorList()
        {
            try
            {
                var list = _repo.ContUtilizatorList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult ContUtilizatorAdd([FromBody] ContUtilizatorInfo info)
        {
            try
            {
                var id = _repo.ContUtilizatorAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult ContUtilizatorUpdate([FromBody] ContUtilizatorInfo info)
        {
            try
            {
                _repo.ContUtilizatorUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult ContUtilizatorDelete(long idContUtilizator)
        {
            try
            {
                var existing = _repo.ContUtilizatorGet(idContUtilizator);
                if (existing == null)
                    return NotFound();

                _repo.ContUtilizatorDelete(idContUtilizator);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult ContUtilizatorDeleteByCNP(string cnp)
        {
            try
            {
                var existing = _repo.ContUtilizatorGetByCNP(cnp);
                if (existing == null)
                    return NotFound();

                _repo.ContUtilizatorDeleteByCNP(cnp);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
