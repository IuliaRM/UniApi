using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CatedraController : DnnApiController
    {
        private readonly ICatedraRepo _repo = new CatedraRepo();

        public CatedraController()
        {

        }


        public CatedraController(ICatedraRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult CatedraAdd([FromBody] CatedraInfo catedra)
        {
            try
            {
                long id = _repo.CatedraAdd(catedra);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraGet(long idCatedra)
        {
            try
            {
                var result = _repo.CatedraGet(idCatedra);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraGetByUsernameSecretarAnUniv(string username, long idAnUniv)
        {
            try
            {
                var result = _repo.CatedraGetByUsernameSecretarAnUniv(username, idAnUniv);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraList()
        {
            try
            {
                var list = _repo.CatedraList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraListByAnUniv(long idAnUniv)
        {
            try
            {
                var list = _repo.CatedraListByAnUniv(idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraListByFacultate(long idFacultate)
        {
            try
            {
                var list = _repo.CatedraListByFacultate(idFacultate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraListByFacultateAnUniv(long idFacultate, long idAnUniv)
        {
            try
            {
                var list = _repo.CatedraListByFacultateAnUniv(idFacultate, idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CatedraUpdate([FromBody] CatedraInfo catedra)
        {
            try
            {
                _repo.CatedraUpdate(catedra);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult CatedraDelete(long idCatedra)
        {
            try
            {
                var catedra = _repo.CatedraGet(idCatedra);
                if (catedra == null)
                    return NotFound();

                _repo.CatedraDelete(idCatedra);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
