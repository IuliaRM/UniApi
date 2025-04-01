using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class ScenariuController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult ScenariuGet(long idScenariu)
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuGet(idScenariu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuActivGet(long idCatedra, long idAnUniv)
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuActivGet(idCatedra, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListGet()
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByAnUniversitarGet(long idAnUniv)
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuListByAnUniversitarGet(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByCatedraGet(long idCatedra)
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuListByCatedraGet(idCatedra);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult ScenariuListByCatedraAnUnivGet(long idCatedra, long idAnUniv)
        {
            var repo = new ScenariuRepo();
            var result = repo.ScenariuListByCatedraAnUnivGet(idCatedra, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ScenariuAdd([FromBody] ScenariuInfo scenariuInfo)
        {
            var repo = new ScenariuRepo();
            var id = repo.ScenariuAdd(scenariuInfo);
            return Ok(id);
        }

        [HttpPost]
        public IHttpActionResult ScenariuDinAltScenariuAdd([FromBody] ScenariuInfo scenariuInfo)
        {
            var repo = new ScenariuRepo();
            var id = repo.ScenariuDinAltScenariuAdd(scenariuInfo.ID_Scenariu, scenariuInfo.DenumireScenariu,
                                                    scenariuInfo.ID_AnUniv, scenariuInfo.ID_Catedra, scenariuInfo.ID_Utilizator);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult ScenariuUpdate([FromBody] ScenariuInfo scenariuInfo)
        {
            var repo = new ScenariuRepo();
            repo.ScenariuUpdate(scenariuInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult ScenariuActivUpdate([FromBody] ScenariuInfo scenariuInfo)
        {
            var repo = new ScenariuRepo();
            repo.ScenariuActivUpdate(scenariuInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult ScenariuDelete([FromBody] ScenariuInfo scenariuInfo)
        {
            var repo = new ScenariuRepo();
            repo.ScenariuDelete(scenariuInfo);
            return Ok();
        }
    }
}
