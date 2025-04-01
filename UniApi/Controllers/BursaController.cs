using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

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
            var repo = new BursaRepo(); // Ensure repository is instantiated correctly
            var bursa = repo.BursaGet(idBursa); // Fetch the scholarship data

            if (bursa != null)
            {
                return Ok(bursa);
            }
            else
            {
                return NotFound();
            }
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
            var repo = new BursaRepo(); // Instantiate repository
            int id = repo.BursaAddOrUpdate(bursa); // Call repository method

            if (id > 0)
            {
                return Ok(id); // Return the new ID if successful
            }
            else
            {
                return BadRequest("Eroare la adăugarea sau actualizarea bursei."); // Handle failure
            }
        }

        // Șterge o bursă
        [HttpDelete]
        public IHttpActionResult BursaDelete(long idBursa)
        {
            var repo = new BursaRepo(); // Instantiate repository
            var bursa = repo.BursaGet(idBursa); // Fetch the scholarship entry

            if (bursa == null)
            {
                return NotFound();
            }

            repo.BursaDelete(idBursa); // Delete by ID
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
