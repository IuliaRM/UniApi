using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class SesiuneExameneController : DnnApiController
    {
        private readonly ISesiuneExameneRepo _repo = new SesiuneExameneRepo();

        public SesiuneExameneController() { }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] SesiuneExameneInfo sesiuneExamene)
        {
            if (sesiuneExamene == null || sesiuneExamene.ID_TipSesiuneExamene <= 0 || string.IsNullOrEmpty(sesiuneExamene.DenumireSesiuneExamene))
            {
                return BadRequest("Obiectul SesiuneExameneInfo nu poate fi null și ID_Facultate, ID_AnUniv, ID_TipSesiuneExamene trebuie să fie pozitive, iar DenumireSesiuneExamene nu poate fi null sau gol.");
            }
            var id = _repo.SesiuneExameneAdd(sesiuneExamene);
            return Ok(new { ID = id });
        }

        [HttpDelete]
        [Route("deschidere-speciala-note/{id:long}")]
        public IHttpActionResult DeleteDeschidereSpecialaNote(long id)
        {
            if (id <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.SesiuneExameneDeschidereSpecialaNoteDelete(id);
            return Ok();
        }

        [HttpGet]
        [Route("deschidere-speciala-note/{id:long}")]
        public IHttpActionResult GetDeschidereSpecialaNote(long id)
        {
            var result = _repo.SesiuneExameneDeschidereSpecialaNoteGet(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("deschidere-speciala-note/by-programare-examen-profesor/{idProgramareExamenProfesor:long}")]
        public IHttpActionResult ListDeschidereSpecialaNoteByProgramareExamenProfesor(long idProgramareExamenProfesor)
        {
            var result = _repo.SesiuneExameneDeschidereSpecialaNoteListByProgramareExamenProfesor(idProgramareExamenProfesor);
            return Ok(result);
        }

        [HttpGet]
        [Route("deschidere-speciala-note/by-sesiune-profesor/{idSesiuneExamene:long}/{idProfesor:long}")]
        public IHttpActionResult ListDeschidereSpecialaNoteBySesiuneProfesor(long idSesiuneExamene, long idProfesor)
        {
            var result = _repo.SesiuneExameneDeschidereSpecialaNoteListBySesiuneProfesor(idSesiuneExamene, idProfesor);
            return Ok(result);
        }

        [HttpGet]
        [Route("deschidere-speciala-note/by-pt-aprobare/{ptAprobare:bool}")]
        public IHttpActionResult ListDeschidereSpecialaNoteByPtAprobare(bool ptAprobare)
        {
            var result = _repo.SesiuneExameneDeschidereSpecialaNoteListByPtAprobare(ptAprobare);
            return Ok(result);
        }

        [HttpGet]
        [Route("deschidere-speciala-note/by-pt-aprobare-cu-studenti/{ptAprobare:bool}")]
        public IHttpActionResult ListDeschidereSpecialaNoteByPtAprobareCuStudenti(bool ptAprobare)
        {
            var result = _repo.SesiuneExameneDeschidereSpecialaNoteListByPtAprobareCuStudenti(ptAprobare);
            return Ok(result);
        }

        [HttpPost]
        [Route("deschidere-speciala-note/merge")]
        public IHttpActionResult MergeDeschidereSpecialaNote([FromBody] SesiuneExameneInfo note)
        {
            if (note == null || note.ProfesoriiPotProgramaExamene == null)
            {
                return BadRequest("Obiectul SesiuneExameneInfo nu poate fi null și ProfesoriiPotProgramaExamene nu trebuie sa fie null");
            }
            _repo.SesiuneExameneDeschidereSpecialaNoteMerge(note);
            return Ok();
        }

        [HttpPut]
        [Route("deschidere-speciala-note/update-aprobare/{id:long}/{ptAprobare:bool}")]
        public IHttpActionResult UpdateDeschidereSpecialaNoteAprobare(long id, bool ptAprobare)
        {
            if (id <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.SesiuneExameneDeschidereSpecialaNoteUpdateAprobare(id, ptAprobare);
            return Ok();
        }

        [HttpPut]
        [Route("deschidere-speciala-note/update-note-salvate/{id:long}")]
        public IHttpActionResult UpdateDeschidereSpecialaNoteSalvate(long id, [FromBody] string noteSalvate)
        {
            if (id <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.SesiuneExameneDeschidereSpecialaNoteUpdateNoteSalvate(id, noteSalvate);
            return Ok();
        }

        [HttpGet]
        [Route("{idSesiuneExamene:long}")]
        public IHttpActionResult Get(long idSesiuneExamene)
        {
            var result = _repo.SesiuneExameneGet(idSesiuneExamene);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("by-facultate-tip-sesiune-an-univ/{idFacultate:long}/{tipSesiuneExamene:int}/{idAnUniv:long}")]
        public IHttpActionResult ListByFacultateTipSesiuneAnUniv(long idFacultate, int tipSesiuneExamene, long idAnUniv)
        {
            var result = _repo.SesiuneExameneListByFacultateTipSesiuneExameneAnUniv(idFacultate, tipSesiuneExamene, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        [Route("by-profesor-an-univ/{idProfesor:long}/{idAnUniv:long}")]
        public IHttpActionResult ListByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            var result = _repo.SesiuneExameneListByProfesorAnUniv(idProfesor, idAnUniv);
            return Ok(result);
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update([FromBody] SesiuneExameneInfo sesiuneExamene)
        {
            if (sesiuneExamene == null || sesiuneExamene.ID_SesiuneExamene <= 0 || string.IsNullOrEmpty(sesiuneExamene.DenumireSesiuneExamene))
            {
                return BadRequest("Obiectul SesiuneExameneInfo nu poate fi null și ID_SesiuneExamene, trebuie să fie pozitive");
            }
            _repo.SesiuneExameneUpdate(sesiuneExamene);
            return Ok();
        }
    }
}
