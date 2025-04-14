using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class ProfesorController : DnnApiController
    {
        private readonly IProfesorRepo _repo = new ProfesorRepo();

        public ProfesorController()
        {

        }

        [HttpGet]
        public IHttpActionResult ProfesorGet(long idProfesor)
        {
            var result = _repo.ProfesorGet(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByEmail(string emailProfesor)
        {
            var result = _repo.ProfesorGetByEmail(emailProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByCNP(string cnp)
        {
            var result = _repo.ProfesorGetByCNP(cnp);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByUsername(string username)
        {
            var result = _repo.ProfesorGetByUsername(username);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByUserID(int userId)
        {
            var result = _repo.ProfesorGetByUserID(userId);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByUsernameAnUniv(string username, long idAnUniv)
        {
            var result = _repo.ProfesorGetByUsernameAnUniv(username, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetByUsernameSimplu(string username)
        {
            var result = _repo.ProfesorGetByUsernameSimplu(username);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetCVByUsername(string username)
        {
            var result = _repo.ProfesorGetCVByUsername(username);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorGetSimplu(long idProfesor)
        {
            var result = _repo.ProfesorGetSimplu(idProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListGet()
        {
            var result = _repo.ProfesorListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByAnUnivGet(long idAnUniv)
        {
            var result = _repo.ProfesorListByAnUnivGet(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByAnUnivExcludeGet(long idAnUniv)
        {
            var result = _repo.ProfesorListByAnUnivExcludeGet(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByCaractereGet(string caractere)
        {
            var result = _repo.ProfesorListByCaractereGet(caractere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByCaractereAnUnivGet(string caractere, long idAnUniv)
        {
            var result = _repo.ProfesorListByCaractereAnUnivGet(caractere, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByCatedraGet(long idCatedra)
        {
            var result = _repo.ProfesorListByCatedraGet(idCatedra);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            var result = _repo.ProfesorListByDetaliuPlanSemestruGet(idDetaliuPlanSemestru);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByFacultateGet(long idFacultate)
        {
            var result = _repo.ProfesorListByFacultateGet(idFacultate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByFacultateAnUnivGet(long idFacultate, long idAnUniv)
        {
            var result = _repo.ProfesorListByFacultateAnUnivGet(idFacultate, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByCodEvaluareGet(string codEvaluare)
        {
            var result = _repo.ProfesorListByCodEvaluareGet(codEvaluare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByDetaliuPlanSemestruProfesorGet(long idDetaliuPlanSemestruProfesor)
        {
            var result = _repo.ProfesorListByDetaliuPlanSemestruProfesorGet(idDetaliuPlanSemestruProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProfesorListByProgramareExamenGet(long idProgramareExamen)
        {
            var result = _repo.ProfesorListByProgramareExamenGet(idProgramareExamen);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Profesor_ListBySpecializareSemestruGet(long idSpecializare, long idSemestru, long idAnUniv)
        {
            var result = _repo.Profesor_ListBySpecializareSemestruGet(idSpecializare, idSemestru, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Profesor_ListBySpecializareSemestruEvaluareGet(long idSpecializare, long idSemestru, long idAnUniv)
        {
            var result = _repo.Profesor_ListBySpecializareSemestruEvaluareGet(idSpecializare, idSemestru, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ProfesorAdd([FromBody] ProfesorInfo profesorInfo)
        {
            if (profesorInfo == null)
            {
                return BadRequest("Obiectul profesorInfo nu poate fi null.");
            }
            var id = _repo.ProfesorAdd(profesorInfo);
            return Ok(id);
        }

        [HttpPost]
        public IHttpActionResult ProfesorAddOrUpdate([FromBody] ProfesorInfo profesorInfo)
        {
            if (profesorInfo == null)
            {
                return BadRequest("Obiectul profesorInfo nu poate fi null.");
            }
            _repo.ProfesorAddOrUpdate(profesorInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ProfesorUpdate([FromBody] ProfesorInfo profesorInfo)
        {
            if (profesorInfo == null)
            {
                return BadRequest("Obiectul profesorInfo nu poate fi null.");
            }
            _repo.ProfesorUpdate(profesorInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ProfesorUpdateCV(long idProfesor, [FromBody] byte[] cv)
        {
            if (cv == null)
            {
                return BadRequest("Fișierul CV nu poate fi null.");
            }
            _repo.ProfesorUpdateCV(idProfesor, cv);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ProfesorUpdateFisierSemnatura(long idProfesor, [FromBody] byte[] fisierSemnatura)
        {
            if (fisierSemnatura == null)
            {
                return BadRequest("Fișierul de semnătură nu poate fi null.");
            }
            _repo.ProfesorUpdateFisierSemnatura(idProfesor, fisierSemnatura);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProfesorDelete(long idProfesor)
        {
            _repo.ProfesorDelete(idProfesor);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ProfesorInlocuire(long idProfesor, long idProfesorInlocuitor, long idAnUniv)
        {
            _repo.ProfesorInlocuire(idProfesor, idProfesorInlocuitor, idAnUniv);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ProfesorResetareCodSecuritate(long idProfesor, string codSecuritate)
        {
            _repo.ProfesorResetareCodSecuritate(idProfesor, codSecuritate);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ProfesorUpdatePasswordByUsername(string username, string newPassword)
        {
            _repo.ProfesorUpdatePasswordByUsername(username, newPassword);
            return Ok();
        }
    }
}