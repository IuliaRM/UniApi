using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class CatedraController : DnnApiController
    {
        private readonly CatedraRepo _repo = new CatedraRepo();

        [HttpGet]
        public IHttpActionResult CatedraGet(long idCatedra)
        {
            var catedra = _repo.CatedraGet(idCatedra);
            return catedra != null ? Ok(catedra) : NotFound();
        }

        [HttpGet]
        public IHttpActionResult CatedraList()
        {
            var catedre = _repo.CatedraList();
            return Ok(catedre);
        }

        [HttpGet]
        public IHttpActionResult CatedraListByAnUniv(long idAnUniv)
        {
            var catedre = _repo.CatedraListByAnUniv(idAnUniv);
            return Ok(catedre);
        }

        [HttpGet]
        public IHttpActionResult CatedraListByFacultate(long idFacultate)
        {
            var catedre = _repo.CatedraListByFacultate(idFacultate);
            return Ok(catedre);
        }

        [HttpPost]
        public IHttpActionResult CatedraAdd([FromBody] CatedraInfo catedra)
        {
            long id = _repo.CatedraAdd(catedra);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult CatedraUpdate([FromBody] CatedraInfo catedra)
        {
            _repo.CatedraUpdate(catedra);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult CatedraDelete(long idCatedra)
        {
            var catedra = _repo.CatedraGet(idCatedra);
            if (catedra == null)
            {
                return NotFound();
            }

            _repo.CatedraDelete(idCatedra);
            return Ok();
        }
    }
}