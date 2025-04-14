using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class ScenariuController : DnnApiController
    {
        private readonly IScenariuRepo _repo = new ScenariuRepo();

        public ScenariuController()
        {

        }

        [HttpGet]
        public IHttpActionResult ScenariuGet(long idScenariu)
        {
            var result = _repo.ScenariuGet(idScenariu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuGetScenariuActiv(long idCatedra, long idAnUniv)
        {
            var result = _repo.ScenariuGetScenariuActiv(idCatedra, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByAnUniversitarGet(long idAnUniv)
        {
            var result = _repo.ScenariuListByAnUniversitar(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByCatedraGet(long idCatedra)
        {
            var result = _repo.ScenariuListByCatedra(idCatedra);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByCatedraAnUnivGet(long idCatedra, long idAnUniv)
        {
            var result = _repo.ScenariuListByCatedraAnUniv(idCatedra, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ScenariuAdd([FromBody] ScenariuInfo scenariuInfo)
        {
            if (scenariuInfo == null)
            {
                return BadRequest("Obiectul scenariuInfo nu poate fi null.");
            }
            var id = _repo.ScenariuAdd(scenariuInfo);
            return Ok(id);
        }

        [HttpPost]
        public IHttpActionResult ScenariuAddDinAltScenariu([FromBody] ScenariuAddDinAltScenariuRequest request)
        {
            if (request == null)
            {
                return BadRequest("Obiectul request nu poate fi null.");
            }
            var id = _repo.ScenariuAddDinAltScenariu(request.IdScenariuSursa, request.DenumireScenariu,
                request.IdAnUnivCurent, request.IdCatedra, request.IdUtilizator);
            return Ok(id);
        }

        // Am creat o clasă separată pentru a primi parametrii necesari pentru ScenariuAddDinAltScenariu
        public class ScenariuAddDinAltScenariuRequest
        {
            public long IdScenariuSursa { get; set; }
            public string DenumireScenariu { get; set; }
            public long IdAnUnivCurent { get; set; }
            public long IdCatedra { get; set; }
            public long IdUtilizator { get; set; }
        }

        [HttpPut]
        public IHttpActionResult ScenariuUpdate([FromBody] ScenariuInfo scenariuInfo)
        {
            if (scenariuInfo == null)
            {
                return BadRequest("Obiectul scenariuInfo nu poate fi null.");
            }
            _repo.ScenariuUpdate(scenariuInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ScenariuUpdateScenariuActiv(long idScenariu, bool scenariuActiv, long idCatedra, long idAnUniv, DateTime dataModificare, long idUtilizator)
        {
            _repo.ScenariuUpdateScenariuActiv(idScenariu, scenariuActiv, idCatedra, idAnUniv, dataModificare, idUtilizator);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ScenariuDelete(long idScenariu)
        {
            _repo.ScenariuDelete(idScenariu);
            return Ok();
        }
    }
}