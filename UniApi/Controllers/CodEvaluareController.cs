using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

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
            var repo = new CodEvaluareRepo(); // Ensure repository is initialized
            var codEvaluare = repo.CodEvaluareGet(idCodEvaluare); // Fetch data

            if (codEvaluare != null)
            {
                return Ok(codEvaluare);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IHttpActionResult CodEvaluareAdd([FromBody] CodEvaluareInfo codEvaluare)
        {
            var repo = new CodEvaluareRepo(); // Ensure correct repository is used
            long id = repo.CodEvaluareAdd(codEvaluare);

            if (id > 0)
            {
                return Ok(id);
            }
            else
            {
                return BadRequest("Eroare la adãugarea codului de evaluare.");
            }
        }

        [HttpPut]
        public IHttpActionResult CodEvaluareUpdate([FromBody] CodEvaluareInfo codEvaluare)
        {
            var repo = new CodEvaluareRepo(); // Ensure correct repository is used
            repo.CodEvaluareUpdate(codEvaluare);

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
