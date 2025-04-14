using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class ConferintaDomeniuFundamentalController : DnnApiController
    {
        private readonly IConferintaDomeniuFundamentalRepo _repo = new ConferintaDomeniuFundamentalRepo();

        public ConferintaDomeniuFundamentalController()
        {

        }
        public ConferintaDomeniuFundamentalController(IConferintaDomeniuFundamentalRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult ConferintaDomeniuFundamentalAdd([FromBody] ConferintaDomeniuFundamentalInfo info)
        {
            try
            {
                var id = _repo.ConferintaDomeniuFundamentalAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult ConferintaDomeniuFundamentalUpdate([FromBody] ConferintaDomeniuFundamentalInfo info)
        {
            try
            {
                _repo.ConferintaDomeniuFundamentalUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult ConferintaDomeniuFundamentalDelete(long id)
        {
            try
            {
                _repo.ConferintaDomeniuFundamentalDelete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalGet(long id)
        {
            try
            {
                var result = _repo.ConferintaDomeniuFundamentalGet(id);
                return result != null ? (IHttpActionResult)Ok(result) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalList()
        {
            try
            {
                var list = _repo.ConferintaDomeniuFundamentalList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalListByConferinta(long idConferinta)
        {
            try
            {
                var list = _repo.ConferintaDomeniuFundamentalListByConferinta(idConferinta);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalListByDomeniuFundamental(long idDomeniuFundamental)
        {
            try
            {
                var list = _repo.ConferintaDomeniuFundamentalListByDomeniuFundamental(idDomeniuFundamental);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(long idConferinta, long idDomeniuFundamental)
        {
            try
            {
                _repo.ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(idConferinta, idDomeniuFundamental);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
