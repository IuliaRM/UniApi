using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AnUniversitarLunaBursaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult AnUniversitarLunaBursaGetByAnUniv(long idAnUniv)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            var result = repo.AnUniversitarLunaBursaGetByAnUniv(idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarLunaBursaGetByAnUnivAndNumarLuna(long idAnUniv, int numarLuna)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            var result = repo.AnUniversitarLunaBursaGetByAnUnivAndNumarLuna(idAnUniv, numarLuna);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult AnUniversitarLunaBursaGetByAnUnivAndOrdineLuna(long idAnUniv, int ordineLuna)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            var result = repo.AnUniversitarLunaBursaGetByAnUnivAndOrdineLuna(idAnUniv, ordineLuna);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult AnUniversitarLunaBursaUpdate([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            repo.AnUniversitarLunaBursaUpdate(lunaBursaInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndNumarLuna([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            repo.AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndNumarLuna(lunaBursaInfo);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndOrdineLuna([FromBody] AnUniversitarLunaBursaInfo lunaBursaInfo)
        {
            var repo = new AnUniversitarLunaBursaRepo();
            repo.AnUniversitarLunaBursaUpdateLunaInchisaByAnUnivAndOrdineLuna(lunaBursaInfo);
            return Ok();
        }
    }
}
