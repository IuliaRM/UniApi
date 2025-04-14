using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class TaxeController : DnnApiController
    {
        private readonly ITaxeRepo _repo = new TaxeRepo();

        public TaxeController()
        {

        }

        // Constructor cu injecție de dependență
        public TaxeController(ITaxeRepo repo)
        {
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpPost]
        public IHttpActionResult TaxeAdd([FromBody] TaxeInfo tax)
        {
            if (tax == null)
            {
                return BadRequest("Obiectul tax nu poate fi null.");
            }
            var id = _repo.TaxeAdd(tax);
            return Ok(id);
        }

        [HttpDelete]
        public IHttpActionResult TaxeDelete(long idTaxa)
        {
            _repo.TaxeDelete(idTaxa);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult TaxeGet(long idTaxa)
        {
            var result = _repo.TaxeGet(idTaxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeGetByAnUniversitarGet(long idAnUniv)
        {
            var result = _repo.TaxeGetByAnUniversitar(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeGetByTipCicluInvatamantGet(long idTipCiclu)
        {
            var result = _repo.TaxeGetByTipCicluInvatamant(idTipCiclu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeGetByTipFormaInvGet(long idTipFormaInv)
        {
            var result = _repo.TaxeGetByTipFormaInv(idTipFormaInv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeGetByTipTaxaGet(long idTip)
        {
            var result = _repo.TaxeGetByTipTaxa(idTip);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TaxeListGet()
        {
            var result = _repo.TaxeList();
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult TaxeUpdate([FromBody] TaxeInfo tax)
        {
            if (tax == null)
            {
                return BadRequest("Obiectul tax nu poate fi null.");
            }
            _repo.TaxeUpdate(tax);
            return Ok();
        }
    }
}