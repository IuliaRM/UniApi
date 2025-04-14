using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PropunereCandidatController : DnnApiController
    {
        private readonly IPropunereCandidatRepo _repo = new PropunereCandidatRepo();

        public PropunereCandidatController()
        {
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatGet(long idPropunereCandidat)
        {
            var result = _repo.PropunereCandidatGet(idPropunereCandidat);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByStudentGet(long idStudent, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByStudent(idStudent, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByAnUniversitarGet(long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByAnUniversitar(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByFacultateGet(long idFacultate, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByFacultate(idFacultate, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByJudeteGet(long idJudet, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByJudete(idJudet, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByLocalitatiGet(long idOras, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByLocalitati(idOras, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByN_JudetGet(long idJudet, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByN_Judet(idJudet, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByN_OrasGet(long idOras, long idAnUniv)
        {
            var result = _repo.PropunereCandidatListByN_Oras(idOras, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByStudentGet(long idStudent) // Redundant, dar îl includ conform cerinței
        {
            var result = _repo.PropunereCandidatListByStudent(idStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PropunereCandidatAdd([FromBody] PropunereCandidatInfo propunereCandidat)
        {
            if (propunereCandidat == null)
            {
                return BadRequest("Obiectul propunereCandidat nu poate fi null.");
            }
            var id = _repo.PropunereCandidatAdd(propunereCandidat);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PropunereCandidatUpdate([FromBody] PropunereCandidatInfo propunereCandidat)
        {
            if (propunereCandidat == null)
            {
                return BadRequest("Obiectul propunereCandidat nu poate fi null.");
            }
            _repo.PropunereCandidatUpdate(propunereCandidat);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PropunereCandidatDelete(long idPropunereCandidat)
        {
            _repo.PropunereCandidatDelete(idPropunereCandidat);
            return Ok();
        }
    }
}