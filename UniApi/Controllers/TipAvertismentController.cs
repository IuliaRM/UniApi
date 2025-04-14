using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TipAvertismentController : DnnApiController
    {
        private readonly ITipAvertismentRepo _repo = new TipAvertismentRepo();

        public TipAvertismentController()
        {

        }

            [HttpGet]
        public IHttpActionResult TipAvertismentGet(long idTipAvertisment)
        {
            var result = _repo.TipAvertismentGet(idTipAvertisment);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipAvertismentListGet()
        {
            var result = _repo.TipAvertismentList();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipAvertismentAdd([FromBody] TipAvertismentInfo tipAvertisment)
        {
            if (tipAvertisment == null)
            {
                return BadRequest("Obiectul tipAvertisment nu poate fi null.");
            }
            var id = _repo.TipAvertismentAdd(tipAvertisment);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipAvertismentUpdate([FromBody] TipAvertismentInfo tipAvertisment)
        {
            if (tipAvertisment == null)
            {
                return BadRequest("Obiectul tipAvertisment nu poate fi null.");
            }
            _repo.TipAvertismentUpdate(tipAvertisment);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipAvertismentDelete(long idTipAvertisment)
        {
            _repo.TipAvertismentDelete(idTipAvertisment);
            return Ok();
        }
    }
}