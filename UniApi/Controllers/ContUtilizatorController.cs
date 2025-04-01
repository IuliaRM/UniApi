using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ContUtilizatorController : DnnApiController
    {
        private readonly ContUtilizatorRepo _repo = new ContUtilizatorRepo();

        [HttpGet]
        public IHttpActionResult ContUtilizatorGet(long idContUtilizator)
        {
            var utilizator = _repo.ContUtilizatorGet(idContUtilizator);
            if (utilizator != null)
            {
                return Ok(utilizator);
            }
            return NotFound();
        }

        [HttpGet]
        public IHttpActionResult ContUtilizatorList()
        {
            var utilizatori = _repo.ContUtilizatorList();
            return Ok(utilizatori);
        }

        [HttpGet]
        public IHttpActionResult ContUtilizatorGetByCNP(string cnp)
        {
            var utilizator = _repo.ContUtilizatorGetByCNP(cnp);
            if (utilizator != null)
            {
                return Ok(utilizator);
            }
            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ContUtilizatorAdd([FromBody] ContUtilizatorInfo objContUtilizator)
        {
            long id = _repo.ContUtilizatorAdd(objContUtilizator);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ContUtilizatorUpdate([FromBody] ContUtilizatorInfo objContUtilizator)
        {
            _repo.ContUtilizatorUpdate(objContUtilizator);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ContUtilizatorDelete(long idContUtilizator)
        {
            var utilizator = _repo.ContUtilizatorGet(idContUtilizator);
            if (utilizator == null)
            {
                return NotFound();
            }
            _repo.ContUtilizatorDelete(idContUtilizator);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ContUtilizatorDeleteByCNP(string cnp)
        {
            var utilizator = _repo.ContUtilizatorGetByCNP(cnp);
            if (utilizator == null)
            {
                return NotFound();
            }
            _repo.ContUtilizatorDeleteByCNP(cnp);
            return Ok();
        }
    }
}
