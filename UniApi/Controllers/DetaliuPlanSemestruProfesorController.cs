using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruProfesorController : DnnApiController
    {
        private readonly DetaliuPlanSemestruProfesorRepo _repo = new DetaliuPlanSemestruProfesorRepo();

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorGet(long ID_DetaliuPlanSemestruProfesor)
        {
            var detaliu = _repo.DetaliuPlanSemestruProfesorGet(ID_DetaliuPlanSemestruProfesor);
            return Ok(detaliu);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorList()
        {
            var lista = _repo.DetaliuPlanSemestruProfesorList();
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesor(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListByProfesor(ID_Profesor, ID_AnUniv, ID_Scenariu);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByTipOrePredate(long ID_TipOrePredate)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListByTipOrePredate(ID_TipOrePredate);
            return Ok(lista);
        }

        [HttpPost]
        public IHttpActionResult DetaliuPlanSemestruProfesorAdd([FromBody] DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            int id = _repo.DetaliuPlanSemestruProfesorAdd(objDetaliuPlanSemestruProfesor);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult DetaliuPlanSemestruProfesorUpdate([FromBody] DetaliuPlanSemestruProfesorInfo objDetaliuPlanSemestruProfesor)
        {
            _repo.DetaliuPlanSemestruProfesorUpdate(objDetaliuPlanSemestruProfesor);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DetaliuPlanSemestruProfesorDelete(long ID_DetaliuPlanSemestruProfesor)
        {
            _repo.DetaliuPlanSemestruProfesorDelete(ID_DetaliuPlanSemestruProfesor);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesorComplet(long ID_Profesor, long ID_AnUniv, long ID_Scenariu)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListByProfesorComplet(ID_Profesor, ID_AnUniv, ID_Scenariu);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(long ID_DetaliuPlanSemestru)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListByDetaliuPlanSemestru(ID_DetaliuPlanSemestru);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListBySpecializareNrSemestruScenariuActiv(ID_Domeniu, ID_Specializare, nrSem);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorListByProfesorSpecializare(long ID_Profesor, long ID_Domeniu, long ID_Specializare, int nrSem)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorListByProfesorSpecializare(ID_Profesor, ID_Domeniu, ID_Specializare, nrSem);
            return Ok(lista);
        }
    }
}
