using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class OfertaPracticaFacultateController : DnnApiController
    {
        private readonly OfertaPracticaFacultateRepo _repo = new OfertaPracticaFacultateRepo();

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateGet(long ID_OfertaPracticaFacultate)
        {
            var oferta = _repo.OfertaPracticaFacultateGet(ID_OfertaPracticaFacultate);
            return Ok(oferta);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListGet()
        {
            var oferte = _repo.OfertaPracticaFacultateListGet();
            return Ok(oferte);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByFacAnStudSpecializDomFCGet(long ID_Facultate, long ID_AnStudiu, long ID_Specializare, long ID_Domeniu, long ID_FC, int Status, DateTime DataValabilitate)
        {
            var oferte = _repo.OfertaPracticaFacultateListByFacAnStudSpecializDomFCGet(ID_Facultate, ID_AnStudiu, ID_Specializare, ID_Domeniu, ID_FC, Status, DataValabilitate);
            return Ok(oferte);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByFacAnStudFCGet(long ID_Facultate, long ID_AnStudiu, long ID_FC, int Status, DateTime DataValabilitate)
        {
            var oferte = _repo.OfertaPracticaFacultateListByFacAnStudFCGet(ID_Facultate, ID_AnStudiu, ID_FC, Status, DataValabilitate);
            return Ok(oferte);
        }

        [HttpGet]
        public IHttpActionResult OfertaPracticaFacultateListByIdOfertaPracticaGet(long ID_OfertaPractica)
        {
            var oferte = _repo.OfertaPracticaFacultateListByIdOfertaPracticaGet(ID_OfertaPractica);
            return Ok(oferte);
        }

        [HttpPost]
        public IHttpActionResult OfertaPracticaFacultateAdd([FromBody] OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateAdd(objOfertaPracticaFacultate);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult OfertaPracticaFacultateUpdate([FromBody] OfertaPracticaFacultate objOfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateUpdate(objOfertaPracticaFacultate);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult OfertaPracticaFacultateDelete(long ID_OfertaPracticaFacultate)
        {
            _repo.OfertaPracticaFacultateDelete(ID_OfertaPracticaFacultate);
            return Ok();
        }
    }
}
