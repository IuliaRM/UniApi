using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ValoareBursaStudentController : DnnApiController
    {
        private readonly IValoareBursaStudentRepo _repo = new ValoareBursaStudentRepo();

        public ValoareBursaStudentController()
        {

        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentGet(long idValoareBursa)
        {
            var result = _repo.ValoareBursaStudentGet(idValoareBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentGetByBursaLuna(long idBursa, int numarLuna, long idAnUnivBursa)
        {
            var result = _repo.ValoareBursaStudentGetByBursaLuna(idBursa, numarLuna, idAnUnivBursa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentListGet()
        {
            var result = _repo.ValoareBursaStudentList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentListByAnUnivLunaBancaGet(long idAnUnivBursa, int numarLuna, long idTipBanca, bool bursaPlatitaLuna)
        {
            var result = _repo.ValoareBursaStudentListByAnUnivLunaBanca(idAnUnivBursa, numarLuna, idTipBanca, bursaPlatitaLuna);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ValoareBursaStudentAdd([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            if (valoareBursaStudent == null || valoareBursaStudent.ID_Bursa <= 0 || valoareBursaStudent.NumarLuna <= 0 || valoareBursaStudent.ID_AnUnivBursa <= 0)
            {
                return BadRequest("Obiectul valoareBursaStudent nu poate fi null și ID_Bursa, NumarLuna, ID_AnUnivBursa trebuie să fie valori pozitive.");
            }
            var id = _repo.ValoareBursaStudentAdd(valoareBursaStudent);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ValoareBursaStudentUpdate([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            if (valoareBursaStudent == null || valoareBursaStudent.ID_ValoareBursa <= 0 || valoareBursaStudent.ID_Bursa <= 0 || valoareBursaStudent.NumarLuna <= 0 || valoareBursaStudent.ID_AnUnivBursa <= 0)
            {
                return BadRequest("Obiectul valoareBursaStudent nu poate fi null și ID_ValoareBursa, ID_Bursa, NumarLuna, ID_AnUnivBursa trebuie să fie valori pozitive.");
            }
            _repo.ValoareBursaStudentUpdate(valoareBursaStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ValoareBursaStudentDelete(long idValoareBursa)
        {
            if (idValoareBursa <= 0)
            {
                return BadRequest("ID_ValoareBursa trebuie să fie o valoare pozitivă.");
            }
            _repo.ValoareBursaStudentDelete(idValoareBursa);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ValoareBursaStudentCalculBugetDisponibilGet(long idAnUnivBursa)
        {
            var result = _repo.ValoareBursaStudentCalculBugetDisponibil(idAnUnivBursa);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ValoareBursaStudentCopiazaPost(long idAnUnivBursaSursa, long idAnUnivBursaDestinatie, long userID)
        {
            _repo.ValoareBursaStudentCopiaza(idAnUnivBursaSursa, idAnUnivBursaDestinatie, userID);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ValoareBursaStudentPreluareLunaPost(long idAnUnivBursa, int numarLuna, long userID)
        {
            if (idAnUnivBursa <= 0 || numarLuna <= 0)
            {
                return BadRequest("ID_AnUnivBursa și NumarLuna trebuie să fie valori pozitive.");
            }
            _repo.ValoareBursaStudentPreluareLuna(idAnUnivBursa, numarLuna, userID);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ValoareBursaStudentUpdateBugetRamasPut([FromBody] ValoareBursaStudentInfo valoareBursaStudent)
        {
            if (valoareBursaStudent == null || valoareBursaStudent.ID_AnUnivBursa <= 0 || valoareBursaStudent.ID_Student <= 0)
            {
                return BadRequest("Obiectul valoareBursaStudent nu poate fi null și ID_AnUnivBursa, ID_Student trebuie să fie valori pozitive.");
            }
            _repo.ValoareBursaStudentUpdateBugetRamas(valoareBursaStudent.ID_AnUnivBursa, valoareBursaStudent.ID_Student, valoareBursaStudent.ValoareBursa, valoareBursaStudent.BursaPlatitaLuna, valoareBursaStudent.UserID);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ValoareBursaStudentUpdatePlatitPut(long idValoareBursa, bool bursaPlatitaLuna, long userID)
        {
            if (idValoareBursa <= 0)
            {
                return BadRequest("ID_ValoareBursa trebuie să fie o valoare pozitivă.");
            }
            _repo.ValoareBursaStudentUpdatePlatit(idValoareBursa, bursaPlatitaLuna, userID);
            return Ok();
        }
    }
}