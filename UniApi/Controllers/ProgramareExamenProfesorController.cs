using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ProgramareExamenProfesorController : DnnApiController
    {
        private readonly ProgramareExamenProfesorRepo _repo;

        public ProgramareExamenProfesorController()
        {
            _repo = new ProgramareExamenProfesorRepo();
        }

        [HttpGet]
        public IHttpActionResult ProgramareExamenProfesorListByAnUnivProfesorActivaGet(long idAnUniv, long idProfesor, int activa, long idProgramareExamen)
        {
            var result = _repo.ProgramareExamenProfesorListByAnUnivProfesorActivaGet(idAnUniv, idProfesor, activa, idProgramareExamen);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult SportNeprofilStudentListByAnUniversitarSemProfesorGet(long idAnUniv, string usernameProfesor)
        {
            var result = _repo.SportNeprofilStudentListByAnUniversitarSemProfesorGet(idAnUniv, usernameProfesor);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ProgramareExamenProfesorListByProgramareExamenGet(long idProgramareExamen)
        {
            var result = _repo.ProgramareExamenProfesorListByProgramareExamenGet(idProgramareExamen);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ProgramareExamenProfesorMerge([FromBody] ProgramareExamenProfesorInfo programareExamenProfesorInfo)
        {
            _repo.ProgramareExamenProfesorMerge(
                programareExamenProfesorInfo.ID_ProgramareExamenProfesor,
                programareExamenProfesorInfo.ID_ProgramareExamen,
                programareExamenProfesorInfo.ID_Profesor,
                programareExamenProfesorInfo.ID_AnUniv,
                programareExamenProfesorInfo.Activ,
                programareExamenProfesorInfo.ID_TipProfesorAsociere
            );
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ProgramareExamenDelete(long idProgramareExamen)
        {
            _repo.ProgramareExamenDelete(idProgramareExamen);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ProgramareExamenNoteFinalizateUpdate(long idProgramareExamen, bool noteFinalizate)
        {
            _repo.ProgramareExamenNoteFinalizateUpdate(idProgramareExamen, noteFinalizate);
            return Ok();
        }

    }
}