using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class DetaliuPlanSemestruProfesorCuplajController : DnnApiController
    {
        private readonly DetaliuPlanSemestruProfesorCuplajRepo _repo = new DetaliuPlanSemestruProfesorCuplajRepo();

        [HttpGet]
        public IHttpActionResult AllGet()
        {
            var lista = _repo.AllGet();
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorByGet(long ID_DetaliuPlanSemestruProfesor)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorByGet(ID_DetaliuPlanSemestruProfesor);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuPlanSemestruProfesorCuplajByGet(long ID_DetaliuPlanSemestruProfesor, long ID_Cuplaj)
        {
            var lista = _repo.DetaliuPlanSemestruProfesorCuplajByGet(ID_DetaliuPlanSemestruProfesor, ID_Cuplaj);
            return Ok(lista);
        }

        [HttpGet]
        public IHttpActionResult DetaliuCuplajByGet(long ID_DetaliuCuplaj)
        {
            var lista = _repo.DetaliuCuplajByGet(ID_DetaliuCuplaj);
            return Ok(lista);
        }

        [HttpPost]
        public IHttpActionResult AddPost([FromBody] DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            int id = _repo.AddPost(objDetaliuPlanSemestruProfesorCuplaj);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult UpdatePut([FromBody] DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            _repo.UpdatePut(objDetaliuPlanSemestruProfesorCuplaj);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteDelete([FromBody] DetaliuPlanSemestruProfesorCuplajInfo objDetaliuPlanSemestruProfesorCuplaj)
        {
            _repo.DeleteDelete(objDetaliuPlanSemestruProfesorCuplaj);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteByPostProfesorDelete(long ID_DetaliuPlanSemestruProfesorCuplaj, long ID_PostProfesor)
        {
            _repo.DeleteByPostProfesorDelete(ID_DetaliuPlanSemestruProfesorCuplaj, ID_PostProfesor);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult IdGet(long ID_DetaliuPlanSemestruProfesorCuplaj)
        {
            var detaliu = _repo.IdGet(ID_DetaliuPlanSemestruProfesorCuplaj);
            return Ok(detaliu);
        }
    }
}
