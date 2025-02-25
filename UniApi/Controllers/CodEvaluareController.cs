using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CodEvaluareController : DnnApiController
    {
        private readonly CodEvaluareRepo _repo = new CodEvaluareRepo();

        [HttpGet]
        public IHttpActionResult CodEvaluareList()
        {
            var coduri = _repo.CodEvaluareList();
            return Ok(coduri);
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareGet(long idCodEvaluare)
        {
            var codEvaluare = _repo.CodEvaluareGet(idCodEvaluare);
            return codEvaluare != null ? Ok(codEvaluare) : NotFound();
        }

        [HttpPost]
        public IHttpActionResult CodEvaluareAdd([FromBody] CodEvaluareInfo codEvaluare)
        {
            long id = _repo.CodEvaluareAdd(codEvaluare);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult CodEvaluareUpdate([FromBody] CodEvaluareInfo codEvaluare)
        {
            _repo.CodEvaluareUpdate(codEvaluare);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult CodEvaluareDelete(long idCodEvaluare)
        {
            var codEvaluare = _repo.CodEvaluareGet(idCodEvaluare);
            if (codEvaluare == null)
            {
                return NotFound();
            }
            _repo.CodEvaluareDelete(idCodEvaluare);
            return Ok();
        }
    }
}
