using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using UniApi;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipReducereController : DnnApiController
    {
        private readonly ITipReducereRepo _repo = new TipReducereRepo();

        public TipReducereController()
        {

        }
        [HttpGet]
        public IHttpActionResult TipReducereGet(long idTipReducere)
        {
            var result = _repo.TipReducereGet(idTipReducere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListGet()
        {
            var result = _repo.TipReducereList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListByTaxaGet(long idTaxa)
        {
            var result = _repo.TipReducereListByTaxa(idTaxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipReducereListByTaxaStudentGet(long idTaxaStudent)
        {
            var result = _repo.TipReducereListByTaxaStudent(idTaxaStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipReducereAdd([FromBody] TipReducereInfo tipReducereInfo)
        {
            if (tipReducereInfo == null || string.IsNullOrEmpty(tipReducereInfo.DenumireTipReducere))
            {
                return BadRequest("Obiectul tipReducereInfo nu poate fi null și DenumireTipReducere nu poate fi null sau gol.");
            }
            var id = _repo.TipReducereAdd(tipReducereInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipReducereUpdate([FromBody] TipReducereInfo tipReducereInfo)
        {
            if (tipReducereInfo == null || tipReducereInfo.ID_TipReducere <= 0 || string.IsNullOrEmpty(tipReducereInfo.DenumireTipReducere))
            {
                return BadRequest("Obiectul tipReducereInfo nu poate fi null, ID_TipReducere trebuie să fie valid și DenumireTipReducere nu poate fi null sau gol.");
            }
            _repo.TipReducereUpdate(tipReducereInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipReducereDelete([FromBody] TipReducereInfo tipReducereInfo)
        {
            if (tipReducereInfo == null || tipReducereInfo.ID_TipReducere <= 0)
            {
                return BadRequest("Obiectul tipReducereInfo nu poate fi null și ID_TipReducere trebuie să fie valid.");
            }
            _repo.TipReducereDelete(tipReducereInfo.ID_TipReducere);
            return Ok();
        }
    }
}