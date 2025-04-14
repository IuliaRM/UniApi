using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipNotaController : DnnApiController
    {
        private readonly ITipNotaRepo _repo = new TipNotaRepo();

        public TipNotaController()
        {

        }
        [HttpGet]
        public IHttpActionResult TipNotaGet(int idTipNota)
        {
            var result = _repo.TipNotaGet(idTipNota);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipNotaListGet()
        {
            var result = _repo.TipNotaList();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipNotaAdd([FromBody] TipNotaInfo tipNota)
        {
            if (tipNota == null)
            {
                return BadRequest("Obiectul tipNota nu poate fi null.");
            }
            var id = _repo.TipNotaAdd(tipNota);
            if (id == -1) // Verificăm valoarea de eroare din repo
            {
                return InternalServerError();
            }
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TipNotaUpdate([FromBody] TipNotaInfo tipNota)
        {
            if (tipNota == null || tipNota.ID_TipNota <= 0)
            {
                return BadRequest("Obiectul tipNota nu poate fi null și ID_TipNota trebuie să fie valid.");
            }
            _repo.TipNotaUpdate(tipNota);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TipNotaDelete(int idTipNota)
        {
            if (idTipNota <= 0)
            {
                return BadRequest("ID_TipNota trebuie să fie valid.");
            }
            _repo.TipNotaDelete(idTipNota);
            return Ok();
        }
    }
}