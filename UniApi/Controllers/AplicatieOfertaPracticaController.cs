using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AplicatieOfertaPracticaController : DnnApiController
    {
        private readonly AplicatieOfertaPracticaController _controller = new AplicatieOfertaPracticaController();

        // Adaugă o aplicație pentru oferta de practică
        [HttpPost]
        public IHttpActionResult AplicatieOfertaPracticaAdd([FromBody] AplicatieOfertaPractica aplicatie)
        {
            _controller.AplicatieOfertaPracticaAdd(aplicatie);
            return Ok();
        }

        // Obține o aplicație pentru oferta de practică după ID
        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaGet(long idAplicatie)
        {
            var aplicatie = _controller.AplicatieOfertaPracticaGet(idAplicatie);
            return aplicatie != null ? Ok(aplicatie) : NotFound();
        }

        // Obține lista tuturor aplicațiilor pentru oferta de practică
        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaList()
        {
            var aplicatii = _controller.AplicatieOfertaPracticaList();
            return Ok(aplicatii);
        }

        // Obține lista aplicațiilor pentru o anumită ofertă de practică
        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaListByIDOfPracFac(long idOfertaPracticaFacultate)
        {
            var aplicatii = _controller.AplicatieOfertaPracticaListByIDOfPracFac(idOfertaPracticaFacultate);
            return Ok(aplicatii);
        }

        // Obține lista aplicațiilor unui anumit student
        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaListByStudent(long idStudent)
        {
            var aplicatii = _controller.AplicatieOfertaPracticaListByStudent(idStudent);
            return Ok(aplicatii);
        }

        // Actualizează o aplicație pentru oferta de practică
        [HttpPut]
        public IHttpActionResult AplicatieOfertaPracticaUpdate([FromBody] AplicatieOfertaPractica aplicatie)
        {
            _controller.AplicatieOfertaPracticaUpdate(aplicatie);
            return Ok();
        }

        // Șterge o aplicație pentru oferta de practică
        [HttpDelete]
        public IHttpActionResult AplicatieOfertaPracticaDelete(long idAplicatie)
        {
            var aplicatie = _controller.AplicatieOfertaPracticaGet(idAplicatie);
            if (aplicatie == null)
            {
                return NotFound();
            }

            _controller.AplicatieOfertaPracticaDelete(aplicatie);
            return Ok();
        }

        // Obține numărul total de aplicații pentru o anumită ofertă de practică
        [HttpGet]
        public IHttpActionResult AplicatieOfertaPracticaGetTotalCountByIDOfPracticaFac(long idOfertaPracticaFacultate)
        {
            int total = _controller.AplicatieOfertaPracticaGetTotalCountByIDOfPracticaFac(idOfertaPracticaFacultate);
            return Ok(total);
        }
    }
}
