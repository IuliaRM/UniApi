using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("api/valoare-tip-bursa-facultate")]
    public class ValoareTipBursaFacultateController : DnnApiController
    {
        private readonly IValoareTipBursaFacultateRepo _repo = new ValoareTipBursaFacultateRepo();

        public ValoareTipBursaFacultateController()
        {

        }


        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            var result = _repo.ValoareTipBursaFacultateGet(id);
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
            var result = _repo.ValoareTipBursaFacultateList();
            return Ok(result);
        }

        [HttpGet]
        [Route("by-ftl")]
        public IHttpActionResult GetByFTL(long idFacultate, long idTipBursa, long idAnUnivBursa)
        {
            var result = _repo.ValoareTipBursaFacultateGetByFTL(idFacultate, idTipBursa, idAnUnivBursa);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            if (valoareTipBursa == null || valoareTipBursa.ID_Facultate <= 0 || valoareTipBursa.ID_TipBursa <= 0 || valoareTipBursa.NumarLuna <= 0 || valoareTipBursa.ID_AnUnivBursa <= 0)
            {
                return BadRequest("Obiectul ValoareTipBursaFacultateInfo nu poate fi null și ID_Facultate, ID_TipBursa, NumarLuna, ID_AnUnivBursa trebuie să fie valori pozitive.");
            }
            var id = _repo.ValoareTipBursaFacultateAdd(valoareTipBursa);
            return Ok(new { ID = id });
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update([FromBody] ValoareTipBursaFacultateInfo valoareTipBursa)
        {
            if (valoareTipBursa == null || valoareTipBursa.ID_ValoareTipBursaFacultate <= 0 || valoareTipBursa.ID_Facultate <= 0 || valoareTipBursa.ID_TipBursa <= 0 || valoareTipBursa.NumarLuna <= 0 || valoareTipBursa.ID_AnUnivBursa <= 0)
            {
                return BadRequest("Obiectul ValoareTipBursaFacultateInfo nu poate fi null și ID_ValoareTipBursaFacultate, ID_Facultate, ID_TipBursa, NumarLuna, ID_AnUnivBursa trebuie să fie valori pozitive.");
            }
            _repo.ValoareTipBursaFacultateUpdate(valoareTipBursa);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IHttpActionResult Delete(long id)
        {
            if (id <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.ValoareTipBursaFacultateDelete(id);
            return Ok();
        }
    }
}