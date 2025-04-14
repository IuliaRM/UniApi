using System;
using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class ProgramareExamenController : DnnApiController
    {
        [HttpPost]
        public IHttpActionResult ProgramareExamenMerge([FromBody] ProgramareExamenInfo programareExamenInfo)
        {
            var repo = new ProgramareExamenRepo();
            var result = repo.ProgramareExamenMerge(
                programareExamenInfo.ID_ProgramareExamen,
                programareExamenInfo.ID_DetaliuPlanSemestru,
                programareExamenInfo.ID_SesiuneExameneSpecializare,
                programareExamenInfo.ID_Grupa,
                programareExamenInfo.Data,
                programareExamenInfo.Sala,
                programareExamenInfo.ID_TipExaminare,
                programareExamenInfo.ID_ProfesorTitularCurs
            );
            return Ok(result);
        }

        /* [HttpPost]
        public IHttpActionResult ProgramareExamenStudentMerge([FromBody] ProgramareExamenStudentInfo exameneStudentInfo)
        {
            var repo = new ProgramareExamenRepo();
            repo.ProgramareExamenStudentMerge(
                exameneStudentInfo.ID_ProgramareExamen,
                exameneStudentInfo.ID_DetaliuPlanSemestru,
                exameneStudentInfo.ID_DetaliuPlanSemestruStudent,
                exameneStudentInfo.ID_SesiuneExameneSpecializare,
                exameneStudentInfo.ID_Student,
                exameneStudentInfo.ID_Grupa
            );
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ProgramareExameneTiparitUpdate([FromBody] ProgramareExamenUpdateInfo updateInfo)
        {
            var repo = new ProgramareExamenRepo();
            repo.ProgramareExameneTiparitUpdate(
                updateInfo.ID_ProgramareExamen,
                updateInfo.Tiparit,
                updateInfo.Data,
                updateInfo.Username
            );
            return Ok();
        } */

        [HttpGet]
        public IHttpActionResult ProgramareExamenGet(long ID_ProgramareExamen)
        {
            var repo = new ProgramareExamenRepo();
            var result = repo.ProgramareExamenGet(ID_ProgramareExamen);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SalaListCaractereGet(string Caractere)
        {
            var repo = new ProgramareExamenRepo();
            var result = repo.SalaListCaractereGet(Caractere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SalaGet(long ID_Sala)
        {
            var repo = new ProgramareExamenRepo();
            var result = repo.SalaGet(ID_Sala);
            return Ok(result);
        }
    }
}
