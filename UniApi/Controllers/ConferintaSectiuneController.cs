using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ConferintaSectiuneController : DnnApiController
    {
        private readonly ConferintaSectiuneRepo _repo = new ConferintaSectiuneRepo();

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneGet(long idConferintaSectiune)
        {
            var sectiune = _repo.ConferintaSectiuneGet(idConferintaSectiune);
            if (sectiune != null)
            {
                return Ok(sectiune);
            }
            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneList()
        {
            var sectiuni = _repo.ConferintaSectiuneList();
            return Ok(sectiuni);
        }

        [HttpGet]
        public IHttpActionResult ConferintaSectiuneListByConferinta(long idConferinta)
        {
            var sectiuni = _repo.ConferintaSectiuneListByConferinta(idConferinta);
            return Ok(sectiuni);
        }

        [HttpPost]
        public IHttpActionResult ConferintaSectiuneAdd([FromBody] ConferintaSectiuneInfo conferintaSectiune)
        {
            long id = _repo.ConferintaSectiuneAdd(conferintaSectiune);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ConferintaSectiuneUpdate([FromBody] ConferintaSectiuneInfo conferintaSectiune)
        {
            _repo.ConferintaSectiuneUpdate(conferintaSectiune);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ConferintaSectiuneDelete(long idConferintaSectiune)
        {
            var sectiune = _repo.ConferintaSectiuneGet(idConferintaSectiune);
            if (sectiune == null)
            {
                return NotFound();
            }
            _repo.ConferintaSectiuneDelete(idConferintaSectiune);
            return Ok();
        }
    }
}
