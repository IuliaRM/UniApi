using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PropunereCandidatController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult PropunereCandidatGet(long idPropunereCandidat)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatGet(idPropunereCandidat);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByStudentGet(long idStudent, long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByStudentGet(idStudent, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByAnUniversitarGet(long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByAnUniversitarGet(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByFacultateGet(long idFacultate, long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByFacultateGet(idFacultate, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByJudetGet(long idJudet, long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByJudetGet(idJudet, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByOrasGet(long idOras, long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByOrasGet(idOras, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PropunereCandidatListByLiceuGet(long idLiceu, long idAnUniv)
        {
            var repo = new PropunereCandidatRepo();
            var result = repo.PropunereCandidatListByLiceuGet(idLiceu, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PropunereCandidatAdd([FromBody] PropunereCandidatInfo propunereCandidat)
        {
            var repo = new PropunereCandidatRepo();
            var id = repo.PropunereCandidatAdd(propunereCandidat);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PropunereCandidatUpdate([FromBody] PropunereCandidatInfo propunereCandidat)
        {
            var repo = new PropunereCandidatRepo();
            repo.PropunereCandidatUpdate(propunereCandidat);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PropunereCandidatDelete(long idPropunereCandidat)
        {
            var repo = new PropunereCandidatRepo();
            repo.PropunereCandidatDelete(idPropunereCandidat);
            return Ok();
        }
    }
}
