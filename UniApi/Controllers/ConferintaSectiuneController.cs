using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class ConferintaSectiuneController : DnnApiController
    {
        private readonly IConferintaSectiuneRepo _repo = new ConferintaSectiuneRepo();

        public ConferintaSectiuneController()
        {

        }

        public ConferintaSectiuneController(IConferintaSectiuneRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneGet(long idConferintaSectiune)
        {
            try
            {
                var sectiune = _repo.ConferintaSectiuneGet(idConferintaSectiune);
                return sectiune != null ? (IHttpActionResult)Ok(sectiune) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneList()
        {
            try
            {
                var list = _repo.ConferintaSectiuneList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneListByConferinta(long idConferinta)
        {
            try
            {
                var list = _repo.ConferintaSectiuneListByConferinta(idConferinta);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult ConferintaSectiuneAdd([FromBody] ConferintaSectiuneInfo info)
        {
            try
            {
                var id = _repo.ConferintaSectiuneAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult ConferintaSectiuneUpdate([FromBody] ConferintaSectiuneInfo info)
        {
            try
            {
                _repo.ConferintaSectiuneUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult ConferintaSectiuneDelete(long idConferintaSectiune)
        {
            try
            {
                var existing = _repo.ConferintaSectiuneGet(idConferintaSectiune);
                if (existing == null)
                    return NotFound();

                _repo.ConferintaSectiuneDelete(idConferintaSectiune);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
