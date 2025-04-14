using System;
using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using UniApi;
using DotNetNuke.Web.Api;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class RatePlatiteController : DnnApiController
    {
        private readonly IRatePlatiteRepo _repo = new RatePlatiteRepo();

        public RatePlatiteController()
        {

        }

        [HttpGet]
        public IHttpActionResult RatePlatiteGet(long idRatePlatite)
        {
            var result = _repo.RatePlatiteGet(idRatePlatite);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteGetByContContabil(long idContContabil)
        {
            var result = _repo.RatePlatiteGetByContContabil(idContContabil);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteGetByRataTaxa(long idRataTaxa)
        {
            var result = _repo.RatePlatiteGetByRataTaxa(idRataTaxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteList()
        {
            var result = _repo.RatePlatiteList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteListByStudentGet(long idStudent, long idAnUniv)
        {
            var result = _repo.RatePlatiteListByStudent(idStudent, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteListByTaxeStudentGet(long idTaxaStudent, long idAnUniv)
        {
            var result = _repo.RatePlatiteListByTaxeStudent(idTaxaStudent, idAnUniv);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult RatePlatiteAdd([FromBody] RatePlatiteInfo ratePlatite)
        {
            if (ratePlatite == null)
            {
                return BadRequest("Obiectul ratePlatite nu poate fi null.");
            }
            var id = _repo.RatePlatiteAdd(ratePlatite);
            return Ok(id);
        }

        [HttpDelete]
        public IHttpActionResult RatePlatiteDelete(long idRatePlatite)
        {
            _repo.RatePlatiteDelete(idRatePlatite);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult RatePlatiteUpdate([FromBody] RatePlatiteInfo ratePlatite)
        {
            if (ratePlatite == null)
            {
                return BadRequest("Obiectul ratePlatite nu poate fi null.");
            }
            _repo.RatePlatiteUpdate(ratePlatite);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult RatePlatiteUpdateUrmatoareleNumereDeChitanta(long idRatePlatite, long numarChitanta, long userId, DateTime dataPentruModificare, bool crescator)
        {
            var result = _repo.RatePlatiteUpdateUrmatoareleNumereDeChitanta(idRatePlatite, numarChitanta, userId, dataPentruModificare, crescator);
            return Ok(result);
        }
    }
}