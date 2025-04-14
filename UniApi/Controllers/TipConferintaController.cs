using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TipConferintaController : DnnApiController
    {
        private readonly ITipConferintaRepo _repo = new TipConferintaRepo();

        public TipConferintaController()
        {

        }

        [HttpGet]
        public IHttpActionResult TipConferintaGet(long idTipConferinta)
        {
            var result = _repo.TipConferintaGet(idTipConferinta);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipConferintaListGet()
        {
            var result = _repo.TipConferintaList();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipConferintaAdd([FromBody] TipConferintaInfo tipConferinta)
        {
            if (tipConferinta == null || string.IsNullOrEmpty(tipConferinta.DenumireTipConferinta))
            {
                return BadRequest("Denumirea tipului de conferință nu poate fi null sau goală.");
            }
            var id = _repo.TipConferintaAdd(tipConferinta);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipConferintaUpdate([FromBody] TipConferintaInfo tipConferinta)
        {
            if (tipConferinta == null || tipConferinta.ID_TipConferinta <= 0 || string.IsNullOrEmpty(tipConferinta.DenumireTipConferinta))
            {
                return BadRequest("ID-ul tipului de conferință trebuie să fie valid și denumirea nu poate fi null sau goală.");
            }
            _repo.TipConferintaUpdate(tipConferinta);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipConferintaDelete(long idTipConferinta)
        {
            if (idTipConferinta <= 0)
            {
                return BadRequest("ID-ul tipului de conferință trebuie să fie valid.");
            }
            _repo.TipConferintaDelete(idTipConferinta);
            return Ok();
        }
    }
}