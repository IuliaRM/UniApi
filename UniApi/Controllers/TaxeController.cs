using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TaxeController : DnnApiController
    {
        [HttpPost]
        public IHttpActionResult TaxeInsert([FromBody] TaxeInfo tax)
        {
            var repo = new TaxeRepo();
            var id = repo.TaxeInsert(tax);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TaxeUpdate([FromBody] TaxeInfo tax)
        {
            var repo = new TaxeRepo();
            repo.TaxeUpdate(tax);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult TaxaGet(long id)
        {
            var repo = new TaxeRepo();
            var result = repo.TaxaGet(id);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeStudentListGet([FromUri] List<long> studentIds, long idAnUniv)
        {
            var repo = new TaxeRepo();
            var result = repo.TaxeStudentListGet(studentIds, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RateTaxeStudentGet(long ID_Student, long ID_AnUniv, bool NumaiTaxeleCuRestDePlata, bool TaxeleDinTotiAnii)
        {
            var repo = new TaxeRepo();
            var result = repo.RateTaxeStudentGet(ID_Student, ID_AnUniv, NumaiTaxeleCuRestDePlata, TaxeleDinTotiAnii);
            return Ok(result);
        }
    }
}
