using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class EvaluareProfesorController : DnnApiController
    {
        private readonly EvaluareProfesorRepo _repo = new EvaluareProfesorRepo();

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListGet()
        {
            var evaluari = _repo.EvaluareProfesorListGet();
            return Ok(evaluari);
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListNrChestionareCompletateGet(long ID_AnUniv, int NrSemestru)
        {
            var evaluari = _repo.EvaluareProfesorListNrChestionareCompletateGet(ID_AnUniv, NrSemestru);
            return Ok(evaluari);
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListNrChestionareCompletateProfGet(long ID_AnUniv, int NrSemestru)
        {
            var evaluari = _repo.EvaluareProfesorListNrChestionareCompletateProfGet(ID_AnUniv, NrSemestru);
            return Ok(evaluari);
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListProfiDeEvaluatGet(long ID_AnUniv, int NrSemestru)
        {
            var evaluari = _repo.EvaluareProfesorListProfiDeEvaluatGet(ID_AnUniv, NrSemestru);
            return Ok(evaluari);
        }

        [HttpPost]
        public IHttpActionResult EvaluareProfesorAdd([FromBody] EvaluareProfesorInfo objEvaluareProfesor)
        {
            var id = _repo.EvaluareProfesorAdd(objEvaluareProfesor);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult EvaluareProfesorUpdate([FromBody] EvaluareProfesorInfo objEvaluareProfesor)
        {
            _repo.EvaluareProfesorUpdate(objEvaluareProfesor);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult EvaluareProfesorDelete([FromBody] EvaluareProfesorInfo objEvaluareProfesor)
        {
            _repo.EvaluareProfesorDelete(objEvaluareProfesor);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult EvaluareProfesorDeleteBySpecializareSemestru(long ID_Prof, long ID_Specializare, int NrSemestru, long ID_Dps)
        {
            _repo.EvaluareProfesorDeleteBySpecializareSemestru(ID_Prof, ID_Specializare, NrSemestru, ID_Dps);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult CoduriEvaluareGenerate(long ID_AnUniv, int NrSemestru)
        {
            _repo.CoduriEvaluareGenerate(ID_AnUniv, NrSemestru);
            return Ok();
        }
    }
}
