using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class LocalitatiController : DnnApiController
    {
        private readonly LocalitatiRepo _repo = new LocalitatiRepo();

        [HttpGet]
        public IHttpActionResult LocalitatiGet(string ID_Localitate)
        {
            var localitate = _repo.LocalitatiGet(ID_Localitate);
            return Ok(localitate);
        }

        [HttpGet]
        public IHttpActionResult LocalitatiByID_N_LocalitateGet(int ID_N_Localitate)
        {
            var localitate = _repo.LocalitatiByID_N_LocalitateGet(ID_N_Localitate);
            return Ok(localitate);
        }

        [HttpGet]
        public IHttpActionResult LocalitatiListGet()
        {
            var localitati = _repo.LocalitatiListGet();
            return Ok(localitati);
        }

        [HttpGet]
        public IHttpActionResult LocalitatiListByJudetGet(string ID_Judet)
        {
            var localitati = _repo.LocalitatiListByJudetGet(ID_Judet);
            return Ok(localitati);
        }

        [HttpGet]
        public IHttpActionResult LocalitatiByDenumireIdJudetGet(string DenumireLocalitate, string ID_Judet)
        {
            var localitate = _repo.LocalitatiByDenumireIdJudetGet(DenumireLocalitate, ID_Judet);
            return Ok(localitate);
        }

        [HttpGet]
        public IHttpActionResult LocalitatiListByCaractereDenumireIdJudetGet(string CaractereDenumireLocalitate, string ID_Judet)
        {
            var localitati = _repo.LocalitatiListByCaractereDenumireIdJudetGet(CaractereDenumireLocalitate, ID_Judet);
            return Ok(localitati);
        }

        [HttpPost]
        public IHttpActionResult LocalitatiAdd([FromBody] LocalitatiInfo objLocalitati)
        {
            var id = _repo.LocalitatiAdd(objLocalitati);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult LocalitatiUpdate([FromBody] LocalitatiInfo objLocalitati)
        {
            _repo.LocalitatiUpdate(objLocalitati);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult LocalitatiDelete([FromBody] LocalitatiInfo objLocalitati)
        {
            _repo.LocalitatiDelete(objLocalitati);
            return Ok();
        }
    }
}
