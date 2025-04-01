using System.Collections.Generic;
using System.Web.Http;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruController : ApiController
    {
        private readonly DetaliuPlanSemestruRepo _repo;

        public DetaliuPlanSemestruController()
        {
            _repo = new DetaliuPlanSemestruRepo();
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            var detaliu = _repo.DetaliuPlanSemestruGet(idDetaliuPlanSemestru);
            if (detaliu != null)
            {
                return Ok(detaliu);
            }
            return NotFound();
        }


        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruListByPlanSemestru(long idPlanSemestru)
        {
            var detalii = _repo.DetaliuPlanSemestruListByPlanSemestru(idPlanSemestru);
            return Ok(detalii);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruListByMaterie(long idMaterie)
        {
            var detalii = _repo.DetaliuPlanSemestruListByMaterie(idMaterie);
            return Ok(detalii);
        }

        [HttpPost]
        public IHttpActionResult DetaliuPlanSemestruAdd([FromBody] DetaliuPlanSemestruInfo detaliuPlanSemestru)
        {
            int id = _repo.DetaliuPlanSemestruAdd(detaliuPlanSemestru);
            if (id > 0)
                return Ok(id);
            else
                return BadRequest("Eroare la adãugarea detaliului planului semestrial.");
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruDelete(long idDetaliuPlanSemestru)
        {
            _repo.DetaliuPlanSemestruDelete(idDetaliuPlanSemestru);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult DetaliuPlanSemestruUpdateMaterieSursaInDestinatie(long idMaterieSursa, long idMaterieDestinatie)
        {
            _repo.DetaliuPlanSemestruUpdateMaterieSursaInDestinatie(idMaterieSursa, idMaterieDestinatie);
            return Ok();
        }
    }
}
