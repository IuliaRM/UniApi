using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipGradDidacticController : DnnApiController
    {
        private readonly ITipGradDidacticRepo _repo = new TipGradDidacticRepo();

        public TipGradDidacticController()
        {

        }

        [HttpGet]
        public IHttpActionResult TipGradDidacticGet(long idTipGradDidactic)
        {
            var result = _repo.TipGradDidacticGet(idTipGradDidactic);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipGradDidacticListGet()
        {
            var result = _repo.TipGradDidacticList();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipGradDidacticAdd([FromBody] TipGradDidacticInfo tipGradDidacticInfo)
        {
            if (tipGradDidacticInfo == null || string.IsNullOrEmpty(tipGradDidacticInfo.DenumireGradDidactic))
            {
                return BadRequest("Obiectul tipGradDidacticInfo nu poate fi null și DenumireGradDidactic nu poate fi null sau gol.");
            }
            var id = _repo.TipGradDidacticAdd(tipGradDidacticInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipGradDidacticUpdate([FromBody] TipGradDidacticInfo tipGradDidacticInfo)
        {
            if (tipGradDidacticInfo == null || tipGradDidacticInfo.ID_TipGradDidactic <= 0 || string.IsNullOrEmpty(tipGradDidacticInfo.DenumireGradDidactic))
            {
                return BadRequest("Obiectul tipGradDidacticInfo nu poate fi null, ID_TipGradDidactic trebuie să fie valid și DenumireGradDidactic nu poate fi null sau gol.");
            }
            _repo.TipGradDidacticUpdate(tipGradDidacticInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipGradDidacticDelete(long idTipGradDidactic)
        {
            if (idTipGradDidactic <= 0)
            {
                return BadRequest("ID_TipGradDidactic trebuie să fie valid.");
            }
            _repo.TipGradDidacticDelete(idTipGradDidactic);
            return Ok();
        }
    }
}