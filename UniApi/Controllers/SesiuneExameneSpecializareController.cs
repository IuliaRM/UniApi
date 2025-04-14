using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class SesiuneExameneSpecializareController : DnnApiController
    {
        private readonly ISesiuneExameneSpecializareRepo _repo = new SesiuneExameneSpecializareRepo();

        public SesiuneExameneSpecializareController() { }

        [HttpGet]
        public IHttpActionResult Get(long idSesiuneExameneSpecializare)
        {
            var result = _repo.SesiuneExameneSpecializareGet(idSesiuneExameneSpecializare);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("list")]
        public IHttpActionResult List()
        {
            var result = _repo.SesiuneExameneSpecializareList();
            return Ok(result);
        }

        [HttpGet]
        [Route("by-profesor-an-univ/{idProfesor:long}/{idAnUniv:long}")]
        public IHttpActionResult ListByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            var result = _repo.SesiuneExameneSpecializareListByProfesorAnUniv(idProfesor, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            if (sesiuneInfo == null || sesiuneInfo.ID_SesiuneExamene <= 0 || sesiuneInfo.ID_Specializare <= 0 || sesiuneInfo.ID_AnStudiu <= 0 || sesiuneInfo.ID_TipSesiuneExamene <= 0 || string.IsNullOrEmpty(sesiuneInfo.DenumireSesiuneExameneSpecializare))
            {
                return BadRequest("Obiectul SesiuneExameneSpecializareInfo nu poate fi null și ID_SesiuneExamene, ID_Specializare, ID_AnStudiu, ID_TipSesiuneExamene trebuie să fie pozitive, iar DenumireSesiuneExameneSpecializare nu poate fi null sau gol.");
            }
            var id = _repo.SesiuneExameneSpecializareAdd(sesiuneInfo);
            return Ok(new { ID = id });
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update([FromBody] SesiuneExameneSpecializareInfo sesiuneInfo)
        {
            if (sesiuneInfo == null || sesiuneInfo.ID_SesiuneExameneSpecializare <= 0 || sesiuneInfo.ID_SesiuneExamene <= 0 || sesiuneInfo.ID_Specializare <= 0 || sesiuneInfo.ID_AnStudiu <= 0 || sesiuneInfo.ID_TipSesiuneExamene <= 0 || string.IsNullOrEmpty(sesiuneInfo.DenumireSesiuneExameneSpecializare))
            {
                return BadRequest("Obiectul SesiuneExameneSpecializareInfo nu poate fi null și ID_SesiuneExameneSpecializare, ID_SesiuneExamene, ID_Specializare, ID_AnStudiu, ID_TipSesiuneExamene trebuie să fie pozitive, iar DenumireSesiuneExameneSpecializare nu poate fi null sau gol.");
            }
            _repo.SesiuneExameneSpecializareUpdate(sesiuneInfo);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{idSesiuneExameneSpecializare:long}")]
        public IHttpActionResult Delete(long idSesiuneExameneSpecializare)
        {
            if (idSesiuneExameneSpecializare <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.SesiuneExameneSpecializareDelete(idSesiuneExameneSpecializare);
            return Ok();
        }

        [HttpPut]
        [Route("update-meta-curenta/{idSesiuneExameneSpecializare:long}/{numaiStudentiiDinMetaCurenta:bool}")]
        public IHttpActionResult UpdateNumaiStudentiiDinMetaCurenta(long idSesiuneExameneSpecializare, bool numaiStudentiiDinMetaCurenta)
        {
            if (idSesiuneExameneSpecializare <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.SesiuneExameneSpecializareUpdateNumaiStudentiiDinMetaCurenta(idSesiuneExameneSpecializare, numaiStudentiiDinMetaCurenta);
            return Ok();
        }
    }
}