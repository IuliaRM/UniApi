using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class VenitCheltuialaDiverseController : DnnApiController
    {
        private readonly IVenitCheltuialaDiverseRepo _repo = new VenitCheltuialaDiverseRepo();

        public VenitCheltuialaDiverseController()
        {

        }

        [HttpGet]
        public IHttpActionResult Get(long id)
        {
            var result = _repo.VenitCheltuialaDiverseGet(id);
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
            var result = _repo.VenitCheltuialaDiverseList();
            return Ok(result);
        }

        [HttpGet]
        [Route("by-an-universitar/{idAnUniversitar:long}")]
        public IHttpActionResult ListByAnUniversitar(long idAnUniversitar)
        {
            var result = _repo.VenitCheltuialaDiverseListByAnUniversitar(idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        [Route("by-facultate/{idFacultate:long}/an-universitar/{idAnUniversitar:long}")]
        public IHttpActionResult ListByFacultateAnUniv(long idFacultate, long idAnUniversitar)
        {
            var result = _repo.VenitCheltuialaDiverseListByFacultateAnUniv(idFacultate, idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        [Route("by-catedra/{idCatedra:long}/an-universitar/{idAnUniversitar:long}")]
        public IHttpActionResult ListByCatedraAnUniv(long idCatedra, long idAnUniversitar)
        {
            var result = _repo.VenitCheltuialaDiverseListByCatedraAnUniv(idCatedra, idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        [Route("by-trunchi/{idTrunchi:long}/an-universitar/{idAnUniversitar:long}")]
        public IHttpActionResult ListByTrunchiAnUniv(long idTrunchi, long idAnUniversitar)
        {
            var result = _repo.VenitCheltuialaDiverseListByTrunchiAnUniv(idTrunchi, idAnUniversitar);
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            if (venitCheltuiala == null || venitCheltuiala.ID_AnUniv <= 0 || string.IsNullOrEmpty(venitCheltuiala.TipVenitCheltuialaDiverse) || venitCheltuiala.ValoareVenitCheltuialaDiverse < 0)
            {
                return BadRequest("Obiectul venitCheltuialaDiverse nu poate fi null, ID_AnUniv trebuie să fie pozitiv, TipVenitCheltuialaDiverse nu poate fi null sau gol, iar ValoareVenitCheltuialaDiverse trebuie să fie non-negativă.");
            }
            var id = _repo.VenitCheltuialaDiverseAdd(venitCheltuiala);
            return Ok(new { ID = id });
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update([FromBody] VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            if (venitCheltuiala == null || venitCheltuiala.ID_VenitCheltuialaDiverse <= 0 || venitCheltuiala.ID_AnUniv <= 0 || string.IsNullOrEmpty(venitCheltuiala.TipVenitCheltuialaDiverse) || venitCheltuiala.ValoareVenitCheltuialaDiverse < 0)
            {
                return BadRequest("Obiectul venitCheltuialaDiverse nu poate fi null, ID_VenitCheltuialaDiverse și ID_AnUniv trebuie să fie pozitive, TipVenitCheltuialaDiverse nu poate fi null sau gol, iar ValoareVenitCheltuialaDiverse trebuie să fie non-negativă.");
            }
            _repo.VenitCheltuialaDiverseUpdate(venitCheltuiala);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id:long}")]
        public IHttpActionResult Delete(long id)
        {
            if (id <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.VenitCheltuialaDiverseDelete(id);
            return Ok();
        }
    }
}