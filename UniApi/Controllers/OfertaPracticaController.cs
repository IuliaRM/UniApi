using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class OfertaPracticaController : DnnApiController
    {
        private readonly OfertaPracticaRepo _repo = new OfertaPracticaRepo();

        [HttpGet]
        public IHttpActionResult OfertaPracticaGet(long ID_OfertaPractica)
        {
            var oferta = _repo.OfertaPracticaGet(ID_OfertaPractica);
            return Ok(oferta);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaListGet()
        {
            var oferte = _repo.OfertaPracticaListGet();
            return Ok(oferte);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaListByUserIDPortalGet(int ID_UserPortal)
        {
            var oferte = _repo.OfertaPracticaListByUserIDPortalGet(ID_UserPortal);
            return Ok(oferte);
        }

        [HttpPost]
        public IHttpActionResult OfertaPracticaAdd([FromBody] OfertaPractica objOfertaPractica)
        {
            _repo.OfertaPracticaAdd(objOfertaPractica);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult OfertaPracticaUpdate([FromBody] OfertaPractica objOfertaPractica)
        {
            _repo.OfertaPracticaUpdate(objOfertaPractica);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult OfertaPracticaDelete(long ID_OfertaPractica)
        {
            _repo.OfertaPracticaDelete(ID_OfertaPractica);
            return Ok();
        }
    }
}
