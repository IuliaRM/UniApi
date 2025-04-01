using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class VenitCheltuialaDiverseController : DnnApiController
    {

        [HttpGet]
        public IHttpActionResult VenitCheltuialaDiverseGet(long id)
        {
            var result = VenitCheltuialaDiverseGet(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult VenitCheltuialaDiverseListGet()
        {
            var result = VenitCheltuialaDiverseListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult VenitCheltuialaDiverseByAnUniversitarGet(long idAnUniversitar)
        {
            var result = VenitCheltuialaDiverseByAnUniversitarGet(idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult VenitCheltuialaDiverseByFacultateGet(long idFacultate, long idAnUniversitar)
        {
            var result = VenitCheltuialaDiverseByFacultateGet(idFacultate, idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult VenitCheltuialaDiverseByCatedraGet(long idCatedra, long idAnUniversitar)
        {
            var result = VenitCheltuialaDiverseByCatedraGet(idCatedra, idAnUniversitar);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult VenitCheltuialaDiverseAdd([FromBody] VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            if (venitCheltuiala == null)
                return BadRequest("Invalid data.");

            var id = VenitCheltuialaDiverseAdd(venitCheltuiala);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult VenitCheltuialaDiverseUpdate([FromBody] VenitCheltuialaDiverseInfo venitCheltuiala)
        {
            if (venitCheltuiala == null)
                return BadRequest("Invalid data.");

            VenitCheltuialaDiverseUpdate(venitCheltuiala);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult VenitCheltuialaDiverseDelete(long id)
        {
            VenitCheltuialaDiverseDelete(id);
            return Ok();
        }
    }
}
