using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class JudeteController : DnnApiController
    {
        private readonly JudeteRepo _repo = new JudeteRepo();

        [HttpGet]
        public IHttpActionResult JudeteGet(string ID_Judet)
        {
            var judet = _repo.JudeteGet(ID_Judet);
            return Ok(judet);
        }

        [HttpGet]
        public IHttpActionResult JudeteByID_N_JudetGet(int ID_N_Judet)
        {
            var judet = _repo.JudeteByID_N_JudetGet(ID_N_Judet);
            return Ok(judet);
        }

        [HttpGet]
        public IHttpActionResult JudeteListGet()
        {
            var judete = _repo.JudeteListGet();
            return Ok(judete);
        }

        [HttpGet]
        public IHttpActionResult JudeteListByCaractereGet(string Caractere, int TopN)
        {
            var judete = _repo.JudeteListByCaractereGet(Caractere, TopN);
            return Ok(judete);
        }

        [HttpPost]
        public IHttpActionResult JudeteAdd([FromBody] JudeteInfo objJudete)
        {
            var id = _repo.JudeteAdd(objJudete);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult JudeteUpdate([FromBody] JudeteInfo objJudete)
        {
            _repo.JudeteUpdate(objJudete);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult JudeteDelete([FromBody] JudeteInfo objJudete)
        {
            _repo.JudeteDelete(objJudete);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult JudeteByDenumireGet(string DenumireJudet)
        {
            var judet = _repo.JudeteByDenumireGet(DenumireJudet);
            return Ok(judet);
        }
    }
}
