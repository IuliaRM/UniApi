using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
  

    public class AbsolvireStudentController : DnnApiController
    {
        private readonly IAbsolvireStudentRepo _repo = new AbsolvireStudentRepo ();

        public AbsolvireStudentController()
        {

        }

        public AbsolvireStudentController(IAbsolvireStudentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentGet(long idAbsolvireStudent)
        {
            try
            {
                var result = _repo.AbsolvireStudentGet(idAbsolvireStudent);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentGetByStudent(long idStudent)
        {
            try
            {
                var result = _repo.AbsolvireStudentGetByStudent(idStudent);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentList()
        {
            try
            {
                var result = _repo.AbsolvireStudentList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentAdd([FromBody] AbsolvireStudentInfo studentInfo)
        {
            try
            {
                if (studentInfo == null)
                    return BadRequest("Obiectul AbsolvireStudentInfo nu poate fi null");

                var id = _repo.AbsolvireStudentAdd(studentInfo);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentUpdate([FromBody] AbsolvireStudentInfo studentInfo)
        {
            try
            {
                if (studentInfo == null)
                    return BadRequest("Obiectul AbsolvireStudentInfo nu poate fi null");

                _repo.AbsolvireStudentUpdate(studentInfo);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentDelete(long idAbsolvireStudent)
        {
            try
            {
                _repo.AbsolvireStudentDelete(idAbsolvireStudent);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentDeleteByStudent(long idStudent)
        {
            try
            {
                _repo.AbsolvireStudentDeleteByStudent(idStudent);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentCalcuMedieGeneralaSpecializare(long idAnUniv, long idFacultate, long idSpecializare)
        {
            try
            {
                _repo.AbsolvireStudentCalcuMedieGeneralaSpecializare(idAnUniv, idFacultate, idSpecializare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentCalculMedieGeneralaStudent(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent)
        {
            try
            {
                var result = _repo.AbsolvireStudentCalculMedieGeneralaStudent(idAnUniv, idFacultate, idFC, idTipCiclu, idStudent);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentImportSerieNumarDiplomaByStudent(long idStudent)
        {
            try
            {
                _repo.AbsolvireStudentImportSerieNumarDiplomaByStudent(idStudent);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        [HttpPut]
        public IHttpActionResult AbsolvireStudentUpdateDetaliiLucrareFinalizareStructura(long idStudent, string titluLucrare, string structuraLucrare)
        {
            try
            {
                _repo.AbsolvireStudentUpdateDetaliiLucrareFinalizareStructura(idStudent, titluLucrare, structuraLucrare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentRegistruByStudent(long idStudent)
        {
            try
            {
                var result = _repo.AbsolvireStudentRegistruByStudent(idStudent);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
