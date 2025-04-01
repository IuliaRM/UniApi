using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ConferintaDomeniuFundamentalController : DnnApiController
    {
        private readonly ConferintaDomeniuFundamentalRepo _repo = new ConferintaDomeniuFundamentalRepo();

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalList()
        {
            var domeniiFundamentale = _repo.ConferintaDomeniuFundamentalList();
            return Ok(domeniiFundamentale);
        }
        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalGet(long idConferintaDomeniuFundamental)
        {
            var repo = new ConferintaDomeniuFundamentalRepo(); // Ensure repository is initialized
            var domeniuFundamental = repo.ConferintaDomeniuFundamentalGet(idConferintaDomeniuFundamental); // Fetch data

            if (domeniuFundamental != null)
            {
                return Ok(domeniuFundamental);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalListByConferinta(long idConferinta)
        {
            var domeniiFundamentale = _repo.ConferintaDomeniuFundamentalListByConferinta(idConferinta);
            return Ok(domeniiFundamentale);
        }

        [HttpGet]
        public IHttpActionResult ConferintaDomeniuFundamentalListByDomeniuFundamental(long idDomeniuFundamental)
        {
            var domeniiFundamentale = _repo.ConferintaDomeniuFundamentalListByDomeniuFundamental(idDomeniuFundamental);
            return Ok(domeniiFundamentale);
        }

        [HttpPost]
        public IHttpActionResult ConferintaDomeniuFundamentalAdd([FromBody] ConferintaDomeniuFundamentalInfo conferintaDomeniuFundamental)
        {
            long id = _repo.ConferintaDomeniuFundamentalAdd(conferintaDomeniuFundamental);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ConferintaDomeniuFundamentalUpdate([FromBody] ConferintaDomeniuFundamentalInfo conferintaDomeniuFundamental)
        {
            _repo.ConferintaDomeniuFundamentalUpdate(conferintaDomeniuFundamental);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ConferintaDomeniuFundamentalDelete(long idConferintaDomeniuFundamental)
        {
            var conferintaDomeniuFundamental = _repo.ConferintaDomeniuFundamentalGet(idConferintaDomeniuFundamental);
            if (conferintaDomeniuFundamental == null)
            {
                return NotFound();
            }
            _repo.ConferintaDomeniuFundamentalDelete(idConferintaDomeniuFundamental);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(long idConferinta, long idDomeniuFundamental)
        {
            _repo.ConferintaDomeniuFundamentalDeleteByConferintaDomeniu(idConferinta, idDomeniuFundamental);
            return Ok();
        }
    }
}
