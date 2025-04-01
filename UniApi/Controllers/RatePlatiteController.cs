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
        private readonly RatePlatiteRepo _repo = new RatePlatiteRepo();

        [HttpGet]
        public IHttpActionResult RatePlatiteListByTaxeStudentGet(long ID_TaxaStudent, long ID_AnUniv)
        {
            var result = _repo.RatePlatiteListByTaxeStudentGet(ID_TaxaStudent, ID_AnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteListByStudentGet(long ID_Student, long ID_AnUniv)
        {
            var result = _repo.RatePlatiteListByStudentGet(ID_Student, ID_AnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteByRataTaxaGet(long ID_RataTaxa)
        {
            var result = _repo.RatePlatiteByRataTaxaGet(ID_RataTaxa);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RatePlatiteGet(long ID_RatePlatite)
        {
            var result = _repo.RatePlatiteGet(ID_RatePlatite);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult RatePlatiteNextReceiptNumberUpdate(long ID_RatePlatite, long NumarChitanta, long UserID, DateTime DataPentruModificare, bool crescator)
        {
            var result = _repo.RatePlatiteNextReceiptNumberUpdate(ID_RatePlatite, NumarChitanta, UserID, DataPentruModificare, crescator);
            return Ok(result);
        }

        [HttpPut]
        public IHttpActionResult RatePlatiteUpdate([FromBody] RatePlatiteInfo ratePlatiteInfo)
        {
            _repo.RatePlatiteUpdate(ratePlatiteInfo.Data_Plata, ratePlatiteInfo.SumaPlatita, ratePlatiteInfo.SerieChitanta, ratePlatiteInfo.NumarChitanta,  ratePlatiteInfo.ID_ContContabil, ratePlatiteInfo.ID_Utilizator, ratePlatiteInfo.PortalID);
            return Ok();
        }
    }
}
