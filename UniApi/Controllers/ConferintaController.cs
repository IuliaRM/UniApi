using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class ConferintaController : DnnApiController
    {
        private readonly ConferintaRepo _repo = new ConferintaRepo();

        [HttpGet]
        public IHttpActionResult ConferintaList()
        {
            var conferinte = _repo.ConferintaList();
            return Ok(conferinte);
        }

        [HttpGet]
        public IHttpActionResult ConferintaGet(long idConferinta)
        {
            var conferinta = _repo.ConferintaGet(idConferinta);
            return conferinta != null ? Ok(conferinta) : NotFound();
        }

        [HttpGet]
        public IHttpActionResult ConferintaListByAnCalendaristic(int anCalendaristic)
        {
            var conferinte = _repo.ConferintaListByAnCalendaristic(anCalendaristic);
            return Ok(conferinte);
        }

        [HttpGet]
        public IHttpActionResult ConferintaListByTipConferinta(long idTipConferinta)
        {
            var conferinte = _repo.ConferintaListByTipConferinta(idTipConferinta);
            return Ok(conferinte);
        }

        [HttpPost]
        public IHttpActionResult ConferintaAdd([FromBody] ConferintaInfo conferinta)
        {
            long id = _repo.ConferintaAdd(conferinta);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ConferintaUpdate([FromBody] ConferintaInfo conferinta)
        {
            _repo.ConferintaUpdate(conferinta);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ConferintaDelete(long idConferinta)
        {
            var conferinta = _repo.ConferintaGet(idConferinta);
            if (conferinta == null)
            {
                return NotFound();
            }
            _repo.ConferintaDelete(conferinta);
            return Ok();
        }
    }
}
