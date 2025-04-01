using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class EvaluareController : DnnApiController
    {
        private readonly EvaluareRepo _repo = new EvaluareRepo();

        [HttpGet]
        public IHttpActionResult MaterieListByUsernameAndIdAnUnivGet(string username, long ID_AnUniv, int NrSemestruEvaluare)
        {
            var materii = _repo.MaterieListByUsernameAndIdAnUnivGet(username, ID_AnUniv, NrSemestruEvaluare);
            return Ok(materii);
        }

        [HttpGet]
        public IHttpActionResult MaterieStudentDetaliiGet(long ID_CodEvaluare)
        {
            var detalii = _repo.MaterieStudentDetaliiGet(ID_CodEvaluare);
            return Ok(detalii);
        }

        [HttpPost]
        public IHttpActionResult ChestionarEvaluatInsert(long ID_Chestionar, long ID_CodEvaluare)
        {
            var result = _repo.ChestionarEvaluatInsert(ID_Chestionar, ID_CodEvaluare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult EvaluareInsert([FromBody] CriteriuEvaluareRaspunsInfo ceri)
        {
            _repo.EvaluareInsert(ceri);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult CriteriiEvaluareWithVarianteRaspunsGet(long ID_CodEvaluare)
        {
            var criterii = _repo.CriteriiEvaluareWithVarianteRaspunsGet(ID_CodEvaluare);
            return Ok(criterii);
        }

        [HttpGet]
        public IHttpActionResult CriteriuEvaluareVarianteRaspunsByIdGet(long ID_CriteriuEvaluareVarianteRaspuns)
        {
            var raspuns = _repo.CriteriuEvaluareVarianteRaspunsByIdGet(ID_CriteriuEvaluareVarianteRaspuns);
            return Ok(raspuns);
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListBySpecializareSemestruGet(long ID_Specializare, int NrSemestru)
        {
            var coduri = _repo.CodEvaluareListBySpecializareSemestruGet(ID_Specializare, NrSemestru);
            return Ok(coduri);
        }

        [HttpGet]
        public IHttpActionResult ChestionarAdaugareTest(long CodEvaluare)
        {
            var result = _repo.ChestionarAdaugareTest(CodEvaluare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RoleByUserIdGet(int UserId)
        {
            var role = _repo.RoleByUserIdGet(UserId);
            return Ok(role);
        }

        [HttpGet]
        public IHttpActionResult RoleByUsernameGet(string Username)
        {
            var role = _repo.RoleByUsernameGet(Username);
            return Ok(role);
        }

        [HttpGet]
        public IHttpActionResult CodEvaluareListByUsernameRoleGet(string Username, string Role, long ID_AnUniv)
        {
            var coduri = _repo.CodEvaluareListByUsernameRoleGet(Username, Role, ID_AnUniv);
            return Ok(coduri);
        }

        [HttpGet]
        public IHttpActionResult SpecializariListByUsernameRoleGet(string Username, string Role, long ID_AnUniv)
        {
            var specializari = _repo.SpecializariListByUsernameRoleGet(Username, Role, ID_AnUniv);
            return Ok(specializari);
        }
    }
}
