using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class IntervalChitantaController : DnnApiController
    {
        private readonly IntervalChitantaRepo _repo = new IntervalChitantaRepo();

        [HttpGet]
        public IHttpActionResult IntervalChitantaGet(long ID_IntervalChitanta)
        {
            var chitanta = _repo.IntervalChitantaGet(ID_IntervalChitanta);
            return Ok(chitanta);
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaByUtilizatorGet(int ID_Utilizator)
        {
            var chitanta = _repo.IntervalChitantaByUtilizatorGet(ID_Utilizator);
            return Ok(chitanta);
        }

        [HttpGet]
        public IHttpActionResult UltimulNumarDeChitantaGet(int ID_Utilizator)
        {
            var numar = _repo.UltimulNumarDeChitantaGet(ID_Utilizator);
            return Ok(numar);
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaListGet()
        {
            var chitante = _repo.IntervalChitantaListGet();
            return Ok(chitante);
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaListByUtilizatorGet(int ID_Utilizator)
        {
            var chitante = _repo.IntervalChitantaListByUtilizatorGet(ID_Utilizator);
            return Ok(chitante);
        }

        [HttpPost]
        public IHttpActionResult IntervalChitantaAdd([FromBody] IntervalChitantaInfo objIntervalChitanta)
        {
            var id = _repo.IntervalChitantaAdd(objIntervalChitanta);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult IntervalChitantaUpdate([FromBody] IntervalChitantaInfo objIntervalChitanta)
        {
            _repo.IntervalChitantaUpdate(objIntervalChitanta);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult IntervalChitantaDelete([FromBody] IntervalChitantaInfo objIntervalChitanta)
        {
            _repo.IntervalChitantaDelete(objIntervalChitanta);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult SeteazaUrmatorulNumarDeChitanta(int ID_Utilizator)
        {
            var numar = _repo.SeteazaUrmatorulNumarDeChitanta(ID_Utilizator);
            return Ok(numar);
        }
    }
}
