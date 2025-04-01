using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class NotaController : DnnApiController
    {
        private readonly NotaRepo _repo = new NotaRepo();

        [HttpGet]
        public IHttpActionResult NotaGet(long ID_Nota)
        {
            var nota = _repo.NotaGet(ID_Nota);
            return Ok(nota);
        }

        [HttpGet]
        public IHttpActionResult NotaListGet()
        {
            var note = _repo.NotaListGet();
            return Ok(note);
        }

        [HttpGet]
        public IHttpActionResult NotaListByDetaliuPlanSemestruGet(long ID_DetaliuPlanSemestru)
        {
            var note = _repo.NotaListByDetaliuPlanSemestruGet(ID_DetaliuPlanSemestru);
            return Ok(note);
        }

        [HttpGet]
        public IHttpActionResult NotaListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            var note = _repo.NotaListByStudentGet(ID_Student, ID_AnUniv);
            return Ok(note);
        }

        [HttpPost]
        public IHttpActionResult NotaAdd([FromBody] NotaInfo NotaInfo)
        {
            var id = _repo.NotaAdd(NotaInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult NotaUpdate([FromBody] NotaInfo NotaInfo)
        {
            _repo.NotaUpdate(NotaInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult NotaDelete(long ID_Nota)
        {
            _repo.NotaDelete(ID_Nota);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult NotaListByUserAnUniversitarGet(int UserId, long ID_AnUniversitar)
        {
            var note = _repo.NotaListByUserAnUniversitarGet(UserId, ID_AnUniversitar);
            return Ok(note);
        }

        [HttpGet]
        public IHttpActionResult NotaListByUsernameAnUniversitarGet(string Username, long ID_AnUniversitar)
        {
            var note = _repo.NotaListByUsernameAnUniversitarGet(Username, ID_AnUniversitar);
            return Ok(note);
        }

        [HttpGet]
        public IHttpActionResult NotaListByStudentGet(long ID_Student)
        {
            var note = _repo.NotaListByStudentGet(ID_Student);
            return Ok(note);
        }

        [HttpGet]
        public IHttpActionResult NotaByDetaliuPlanAndIdGet(long ID_DetaliuPlanSemestru, long ID_Nota)
        {
            var nota = _repo.NotaByDetaliuPlanAndIdGet(ID_DetaliuPlanSemestru, ID_Nota);
            return Ok(nota);
        }

        [HttpPost]
        public IHttpActionResult NotaEchivaleaza(long ID_DetaliuPlanSemestruRestanta, long ID_NotaCuCareSeEchivaleaza, long ID_Student, int ID_Utilizator)
        {
            _repo.NotaEchivaleaza(ID_DetaliuPlanSemestruRestanta, ID_NotaCuCareSeEchivaleaza, ID_Student, ID_Utilizator);
            return Ok();
        }
    }
}
