using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AvertismentController : DnnApiController
    {
        private readonly AvertismentRepo _repo = new AvertismentRepo();

        [HttpGet]
        public IHttpActionResult AvertismentGet(long idAvertisment)
        {
            var avertisment = _repo.AvertismentGet(idAvertisment);
            return avertisment != null ? Ok(avertisment) : NotFound();
        }

        [HttpGet]
        public IHttpActionResult AvertismentList()
        {
            var avertismente = _repo.AvertismentList();
            return Ok(avertismente);
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByCazare(long idCazare)
        {
            var avertismente = _repo.AvertismentListByCazare(idCazare);
            return Ok(avertismente);
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByTipAvertisment(long idTipAvertisment)
        {
            var avertismente = _repo.AvertismentListByTipAvertisment(idTipAvertisment);
            return Ok(avertismente);
        }

        [HttpPost]
        public IHttpActionResult AvertismentAdd([FromBody] AvertismentInfo avertisment)
        {
            int id = _repo.AvertismentAdd(avertisment);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AvertismentUpdate([FromBody] AvertismentInfo avertisment)
        {
            _repo.AvertismentUpdate(avertisment);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AvertismentDelete(long idAvertisment)
        {
            var avertisment = _repo.AvertismentGet(idAvertisment);
            if (avertisment == null)
            {
                return NotFound();
            }

            _repo.AvertismentDelete(idAvertisment);
            return Ok();
        }
    }
}
