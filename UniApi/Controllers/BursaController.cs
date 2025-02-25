using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class BursaController : DnnApiController
    {
        private readonly BursaController _controller = new BursaController();

        // Verifică dacă bursele sunt vizibile pentru o facultate
        [HttpGet]
        public IHttpActionResult BurseVizibileGetByFacultate(long idFacultate)
        {
            return Ok(_controller.BurseVizibileGetByFacultate(idFacultate));
        }

        // Adaugă sau actualizează vizibilitatea burselor pentru o facultate
        [HttpPost]
        public IHttpActionResult BurseVizibileAddOrUpdate(long idFacultate, string operatiune)
        {
            _controller.BurseVizibileAddOrUpdate(idFacultate, operatiune);
            return Ok();
        }

        // Obține detalii despre o bursă după ID
        [HttpGet]
        public IHttpActionResult BursaGet(long idBursa)
        {
            var bursa = _controller.BursaGet(idBursa);
            return bursa != null ? Ok(bursa) : NotFound();
        }

        // Obține lista tuturor burselor
        [HttpGet]
        public IHttpActionResult BursaList()
        {
            return Ok(_controller.BursaList());
        }

        // Obține lista burselor pentru un student
        [HttpGet]
        public IHttpActionResult BursaListByStudent(long idStudent)
        {
            return Ok(_controller.BursaListByStudent(idStudent));
        }

        // Adaugă sau actualizează o bursă
        [HttpPost]
        public IHttpActionResult BursaAddOrUpdate([FromBody] BursaInfo bursa)
        {
            int id = _controller.BursaAddOrUpdate(bursa);
            return Ok(id);
        }

        // Șterge o bursă
        [HttpDelete]
        public IHttpActionResult BursaDelete(long idBursa)
        {
            var bursa = _controller.BursaGet(idBursa);
            if (bursa == null)
            {
                return NotFound();
            }
            _controller.BursaDelete(bursa);
            return Ok();
        }

        // Șterge burse pentru un student pe un anumit semestru
        [HttpDelete]
        public IHttpActionResult BursaDeleteByStudentAnSemestru(long idStudent, long idAnUnivBursa, long numarSemestruBursa)
        {
            _controller.BursaDeleteByStudentAnSemestru(idStudent, idAnUnivBursa, numarSemestruBursa);
            return Ok();
        }
    }
}
