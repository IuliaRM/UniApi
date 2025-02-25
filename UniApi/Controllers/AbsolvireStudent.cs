using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AbsolvireStudentController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AbsolvireStudentGet(long idAbsolvireStudent)
        {
            var repo = new AbsolvireStudentRepo();
            var result = repo.AbsolvireStudentGet(idAbsolvireStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentListByStudent(long idStudent)
        {
            var repo = new AbsolvireStudentRepo();
            var result = repo.AbsolvireStudentListByStudent(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentList()
        {
            var repo = new AbsolvireStudentRepo();
            var result = repo.AbsolvireStudentList();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentAdd([FromBody] AbsolvireStudentInfo studentInfo)
        {
            var repo = new AbsolvireStudentRepo();
            var id = repo.AbsolvireStudentAdd(studentInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentUpdate([FromBody] AbsolvireStudentInfo studentInfo)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentUpdate(studentInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentDelete(long idAbsolvireStudent)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentDelete(idAbsolvireStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AbsolvireStudentDeleteByStudent(long idStudent)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentDeleteByStudent(idStudent);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentCalculateAverageBySpecialization(long idAnUniv, long idFacultate, long idSpecializare)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentCalculateAverageBySpecialization(idAnUniv, idFacultate, idSpecializare);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult AbsolvireStudentCalculateAverage(long idAnUniv, long idFacultate, long idFC, long idTipCiclu, long idStudent)
        {
            var repo = new AbsolvireStudentRepo();
            var result = repo.AbsolvireStudentCalculateAverage(idAnUniv, idFacultate, idFC, idTipCiclu, idStudent);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult AbsolvireStudentImportDiplomaSeriesAndNumber(long idStudent)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentImportDiplomaSeriesAndNumber(idStudent);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentUpdateRegistry(long idStudent, int anRegistru, string nrRegistru)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentUpdateRegistry(idStudent, anRegistru, nrRegistru);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult AbsolvireStudentUpdateThesisDetails(long idStudent, string titluLucrare, string csvUsernameConducatori, decimal notaMedie)
        {
            var repo = new AbsolvireStudentRepo();
            repo.AbsolvireStudentUpdateThesisDetails(idStudent, titluLucrare, csvUsernameConducatori, notaMedie);
            return Ok();
        }
    }
}
