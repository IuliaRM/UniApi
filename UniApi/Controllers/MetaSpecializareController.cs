using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class MetaSpecializareController : DnnApiController
    {
        private readonly IMetaSpecializareRepo _repo = new MetaSpecializareRepo();

        public MetaSpecializareController()
        {

        }

        public MetaSpecializareController(IMetaSpecializareRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareGet(long idMetaSpecializare)
        {
            try
            {
                var result = _repo.MetaSpecializareGet(idMetaSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareList()
        {
            try
            {
                var result = _repo.MetaSpecializareList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareListByFacultate(long idFacultate)
        {
            try
            {
                var result = _repo.MetaSpecializareListByFacultate(idFacultate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareListBySpecializare(long idSpecializare)
        {
            try
            {
                var result = _repo.MetaSpecializareListBySpecializare(idSpecializare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                var result = _repo.MetaSpecializareListByCatedraAnUniv(idCatedra, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult MetaSpecializareAdd([FromBody] MetaSpecializareInfo info)
        {
            try
            {
                var id = _repo.MetaSpecializareAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult MetaSpecializareUpdate([FromBody] MetaSpecializareInfo info)
        {
            try
            {
                _repo.MetaSpecializareUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult MetaSpecializareDelete(long idMetaSpecializare)
        {
            try
            {
                _repo.MetaSpecializareDelete(idMetaSpecializare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
