using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PachetAbsolvireController : DnnApiController
    {
        private readonly PachetAbsolvireRepo _repo;

        public PachetAbsolvireController()
        {
            _repo = new PachetAbsolvireRepo();
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireGet(long idPachetAbsolvire)
        {
            var result = _repo.PachetAbsolvireGet(idPachetAbsolvire);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireListGet()
        {
            var result = _repo.PachetAbsolvireListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PachetAbsolvireListByAnUnivAndSpecializareGet(long idAnUniv, long idSpecializare)
        {
            var result = _repo.PachetAbsolvireListByAnUnivAndSpecializareGet(idAnUniv, idSpecializare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PachetAbsolvireAdd([FromBody] PachetAbsolvireInfo pachetAbs)
        {
            var id = _repo.PachetAbsolvireAdd(pachetAbs);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PachetAbsolvireUpdate([FromBody] PachetAbsolvireInfo pachetAbs)
        {
            _repo.PachetAbsolvireUpdate(pachetAbs);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PachetAbsolvireDelete(long idPachetAbsolvire)
        {
            _repo.PachetAbsolvireDelete(idPachetAbsolvire);
            return Ok();
        }
    }
}
