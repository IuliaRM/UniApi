using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TrunchiController : DnnApiController
    {
        private readonly ITrunchiRepo _repo = new TrunchiRepo();

        public TrunchiController()
        {

        }
        [HttpGet]
        public IHttpActionResult TrunchiGet(long idTrunchi)
        {
            var result = _repo.TrunchiGet(idTrunchi);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TrunchiListGet()
        {
            var result = _repo.TrunchiList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TrunchiListDistinctMinGet()
        {
            var result = _repo.TrunchiListDistinctMin();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TrunchiAdd([FromBody] TrunchiInfo trunchiInfo)
        {
            if (trunchiInfo == null || string.IsNullOrEmpty(trunchiInfo.DenumireTrunchi))
            {
                return BadRequest("Obiectul trunchiInfo nu poate fi null și DenumireTrunchi nu poate fi null sau gol.");
            }
            var id = _repo.TrunchiAdd(trunchiInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TrunchiUpdate([FromBody] TrunchiInfo trunchiInfo)
        {
            if (trunchiInfo == null || trunchiInfo.ID_Trunchi <= 0 || string.IsNullOrEmpty(trunchiInfo.DenumireTrunchi))
            {
                return BadRequest("Obiectul trunchiInfo nu poate fi null, ID_Trunchi trebuie să fie valid și DenumireTrunchi nu poate fi null sau gol.");
            }
            _repo.TrunchiUpdate(trunchiInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TrunchiDelete(long idTrunchi)
        {
            if (idTrunchi <= 0)
            {
                return BadRequest("ID_Trunchi trebuie să fie valid.");
            }
            _repo.TrunchiDelete(idTrunchi);
            return Ok();
        }
    }
}