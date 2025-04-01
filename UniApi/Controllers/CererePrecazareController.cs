using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllerss
{
    public class CererePrecazareController : DnnApiController
    {
        private readonly CererePrecazareRepo _repo = new CererePrecazareRepo();

        [HttpGet]
        public IHttpActionResult CererePrecazareGet(long idCererePrecazare)
        {
            var cerere = _repo.CererePrecazareGet(idCererePrecazare);
            if (cerere == null)
            {
                return NotFound();
            }
            return Ok(cerere);
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareList()
        {
            var cereri = _repo.CererePrecazareList();
            return Ok(cereri);
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByStudent(long idStudent)
        {
            var cereri = _repo.CererePrecazareListByStudent(idStudent);
            return Ok(cereri);
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByStudentComplet(long idStudent, long idAnUniv)
        {
            var cereri = _repo.CererePrecazareListByStudentComplet(idStudent, idAnUniv);
            return Ok(cereri);
        }

        [HttpGet]
        public IHttpActionResult CererePrecazareListByCamera(long idCamera)
        {
            var cereri = _repo.CererePrecazareListByCamera(idCamera);
            return Ok(cereri);
        }

        [HttpPost]
        public IHttpActionResult CererePrecazareAdd([FromBody] CererePrecazareInfo cererePrecazare)
        {
            long id = _repo.CererePrecazareAdd(cererePrecazare);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult CererePrecazareUpdate([FromBody] CererePrecazareInfo cererePrecazare)
        {
            _repo.CererePrecazareUpdate(cererePrecazare);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult CererePrecazareDelete(long idCererePrecazare)
        {
            var cerere = _repo.CererePrecazareGet(idCererePrecazare);
            if (cerere == null)
            {
                return NotFound();
            }
            _repo.CererePrecazareDelete(idCererePrecazare);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ListaCamineByAnuUniversitarFacultate(long idAnUniversitar, long idFacultate)
        {
            var camine = _repo.ListaCamineByAnuUniversitarFacultate(idAnUniversitar, idFacultate);
            return Ok(camine);
        }

        [HttpGet]
        public IHttpActionResult ListaCamerePrecazareByAnUnivCaminFacultate(long idAnUniversitar, long idCamin, long idFacultate)
        {
            var camere = ListaCamerePrecazareByAnUnivCaminFacultate(idAnUniversitar, idCamin, idFacultate);
            return Ok(camere);
        }

        [HttpGet]
        public IHttpActionResult GetCameraInfoCererePrecedenta(long idStudent, long idAnUniversitar)
        {
            var cerere = GetCameraInfoCererePrecedenta(idStudent, idAnUniversitar);
            if (cerere == null)
            {
                return NotFound();
            }
            return Ok(cerere);
        }
    }
}
