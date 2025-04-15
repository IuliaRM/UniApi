using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class StudentController : DnnApiController
    {
        private readonly IStudentRepo _repo = new StudentRepo();

        public StudentController() { }

        [HttpPost]
        public IHttpActionResult Add([FromBody] StudentInfo student)
        {
            if (student == null)
            {
                return BadRequest("Obiectul StudentInfo nu poate fi null.");
            }
            var id = _repo.StudentAdd(student);
            return Ok(new { ID = id });
        }

        [HttpDelete]
        public IHttpActionResult Delete(long idStudent)
        {
            if (idStudent <= 0)
            {
                return BadRequest("ID-ul trebuie sã fie o valoare pozitivã.");
            }
            _repo.StudentDelete(idStudent);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteByIdCandidatFacultate(long idCandidatFacultate)
        {
            if (idCandidatFacultate <= 0)
            {
                return BadRequest("ID-ul trebuie sã fie o valoare pozitivã.");
            }
            _repo.StudentDeleteByIdCandidatFacultate(idCandidatFacultate);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult ExistaCuIdCandidatFacultateAdmitere(long idCandidatFacultate)
        {
            if (idCandidatFacultate <= 0)
            {
                return BadRequest("ID-ul trebuie sã fie o valoare pozitivã.");
            }
            var result = _repo.StudentExistaCuIdCandidatFacultateAdmitere(idCandidatFacultate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult Get(long idStudent)
        {
            var result = _repo.StudentGet(idStudent);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByAnUniv(long idAnUniv)
        {
            var result = _repo.StudentGetbyAnUniv(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByEmailAnUniv(string email, long idAnUniv)
        {
            var result = _repo.StudentGetByEmailAnUniv(email, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByFacultateCicluFormaDomeniuSpecializareNumeCNP(long idFacultate, long idCiclu, long idFormaInvatamant, long idDomeniu, long idSpecializare, string nume, string cnp)
        {
            var result = _repo.StudentGetByFacultateCicluFormaDomeniuSpecializareNumeCNP(idFacultate, idCiclu, idFormaInvatamant, idDomeniu, idSpecializare, nume, cnp);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByIdCandidatFacultate(long idCandidatFacultate)
        {
            var result = _repo.StudentGetByIdCandidatFacultate(idCandidatFacultate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTaxaStudent(bool taxaStudent)
        {
            var result = _repo.StudentGetByTaxaStudent(taxaStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTipActIdentitate(string tipActIdentitate)
        {
            var result = _repo.StudentGetByTipActIdentitate(tipActIdentitate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTipBanca(string tipBanca)
        {
            var result = _repo.StudentGetByTipBanca(tipBanca);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTipCetatenie(string tipCetatenie)
        {
            var result = _repo.StudentGetByTipCetatenie(tipCetatenie);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTipSituatieMilitara(string tipSituatieMilitara)
        {
            var result = _repo.StudentGetByTipSituatieMilitara(tipSituatieMilitara);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByTipStareCivila(string tipStareCivila)
        {
            var result = _repo.StudentGetByTipStareCivila(tipStareCivila);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByUserID(long userId)
        {
            var result = _repo.StudentGetByUserID(userId);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByUserIDAnUnivID(long userId, long idAnUniv)
        {
            var result = _repo.StudentGetByUserIDAnUnivID(userId, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByUsername(string username)
        {
            var result = _repo.StudentGetByUsername(username);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetByUsernameAnUniv(string username, long idAnUniv)
        {
            var result = _repo.StudentGetByUsernameAnUniv(username, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetInformatiiCompleteSecretarSef(long idStudent)
        {
            var result = _repo.StudentGetInformatiiCompleteSecretarSef(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetOrAddByIdStudentSuperior(long idStudentSuperior)
        {
            var result = _repo.StudentGetOrAddByIdStudentSuperior(idStudentSuperior);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult GetTipTaxaScolarizareStudentAnUnivCurent(long idStudent)
        {
            var result = _repo.StudentGetTipTaxaScolarizareStudentAnUnivCurent(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult List()
        {
            var result = _repo.StudentList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByAnUniv(long idAnUniv)
        {
            var result = _repo.StudentListByAnUniv(idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ListByAnUnivLaMaiMulteFacultati([FromBody] List<long> idFacultati, long idAnUniv)
        {
            var result = _repo.StudentListByAnUnivLaMaiMulteFacultati(idFacultati, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByAnUnivMaiMareDeAn(long idAnUniv)
        {
            var result = _repo.StudentListByAnUnivMaiMareDeAn(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByCaractere(string caractere)
        {
            var result = _repo.StudentListByCaractere(caractere);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByFCFSAnUniv(long idFacultate, long idCiclu, long idFormaInvatamant, long idSpecializare, long idAnUniv)
        {
            var result = _repo.StudentListByFCFSAnUniv(idFacultate, idCiclu, idFormaInvatamant, idSpecializare, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByGrupa(long idGrupa)
        {
            var result = _repo.StudentListByGrupa(idGrupa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByGrupaAsociatiPachetAbsolvire(long idGrupa)
        {
            var result = _repo.StudentListByGrupaAsociatiPachetAbsolvire(idGrupa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByGrupaNeasociatiPachetAbsolvire(long idGrupa)
        {
            var result = _repo.StudentListByGrupaNeasociatiPachetAbsolvire(idGrupa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByGrupaSpecializare(long idGrupa, long idSpecializare)
        {
            var result = _repo.StudentListByGrupaSpecializare(idGrupa, idSpecializare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByID_Student(long idStudent)
        {
            var result = _repo.StudentListByID_Student(idStudent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByMetaSpecializareAsociatiPachetAbsolvire(long idMetaSpecializare)
        {
            var result = _repo.StudentListByMetaSpecializareAsociatiPachetAbsolvire(idMetaSpecializare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByMetaSpecializareSesiuneAsociatiPachetAbsolvire(long idMetaSpecializare, long idSesiune)
        {
            var result = _repo.StudentListByMetaSpecializareSesiuneAsociatiPachetAbsolvire(idMetaSpecializare, idSesiune);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListBySpecializareAsociatiPachetAbsolvire(long idSpecializare)
        {
            var result = _repo.StudentListBySpecializareAsociatiPachetAbsolvire(idSpecializare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListBySpecializareSesiuneAsociatiPachetAbsolvire(long idSpecializare, long idSesiune)
        {
            var result = _repo.StudentListBySpecializareSesiuneAsociatiPachetAbsolvire(idSpecializare, idSesiune);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByTaxa(bool taxa)
        {
            var result = _repo.StudentListByTaxa(taxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListByUsernameAnUniv(string username, long idAnUniv)
        {
            var result = _repo.StudentListByUsernameAnUniv(username, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ListDenumiriByAnUniv(long idAnUniv)
        {
            var result = _repo.StudentListDenumiriByAnUniv(idAnUniv);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult Update([FromBody] StudentInfo student)
        {
            if (student == null)
            {
                return BadRequest("Obiectul StudentInfo nu poate fi null.");
            }
            _repo.StudentUpdate(student);
            return Ok();
        }

        /*   [HttpPut]
           public IHttpActionResult UpdateAtributDinamic([FromBody] StudentAtributDinamicInfo atributDinamic)
           {
               if (atributDinamic == null)
               {
                   return BadRequest("Obiectul StudentAtributDinamicInfo nu poate fi null.");
               }
               _repo.StudentUpdateAtributDinamic(atributDinamic);
               return Ok();
           }

          [HttpPut]
           public IHttpActionResult UpdateBancaSiContBanca([FromBody] StudentBancaInfo bancaInfo)
           {
               if (bancaInfo == null)
               {
                   return BadRequest("Obiectul StudentBancaInfo nu poate fi null.");
               }
               _repo.StudentUpdateBancaSiContBanca(bancaInfo);
               return Ok();
           } */

        [HttpPut]
        public IHttpActionResult UpdateInfoPentruBursa([FromBody] BursaInfo bursaInfo)
        {
            if (bursaInfo == null)
            {
                return BadRequest("Obiectul StudentInfoBursa nu poate fi null.");
            }
            _repo.StudentUpdateInfoPentruBursa(bursaInfo);
            return Ok();
        }

        /* [HttpPut]
         public IHttpActionResult UpdateInfoUser([FromBody] StudentInfoUser userInfo)
         {
             if (userInfo == null)
             {
                 return BadRequest("Obiectul StudentInfoUser nu poate fi null.");
             }
             _repo.StudentUpdateInfoUser(userInfo);
             return Ok();
         } */

        [HttpPut]
        public IHttpActionResult UpdatePasswordByUsername(string username, string password)
        {
            _repo.StudentUpdatePasswordByUsername(username, password);
            return Ok();
        }
    }
}