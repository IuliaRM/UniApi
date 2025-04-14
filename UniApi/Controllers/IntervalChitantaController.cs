using System;
using System.Web.Http;
using System.Data;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class IntervalChitantaController : DnnApiController
    {
        private readonly IIntervalChitantaRepo _repo = new IntervalChitantaRepo();

        public IntervalChitantaController()
        {

        }
        public IntervalChitantaController(IIntervalChitantaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaGet(long id)
        {
            try
            {
                var result = _repo.IntervalChitantaGet(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaGetIntervalActiv(int idUtilizator)
        {
            try
            {
                var result = _repo.IntervalChitantaGetIntervalActiv(idUtilizator);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaGetUltimulNumarDeChitanta(int idUtilizator)
        {
            try
            {
                var result = _repo.IntervalChitantaGetUltimulNumarDeChitanta(idUtilizator);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaList()
        {
            try
            {
                var result = _repo.IntervalChitantaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult IntervalChitantaListByUtilizator(int idUtilizator)
        {
            try
            {
                var result = _repo.IntervalChitantaListByID_Utilizator(idUtilizator);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult IntervalChitantaAdd([FromBody] IntervalChitantaInfo info)
        {
            try
            {
                var id = _repo.IntervalChitantaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult IntervalChitantaUpdate([FromBody] IntervalChitantaInfo info)
        {
            try
            {
                _repo.IntervalChitantaUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult IntervalChitantaDelete([FromBody] IntervalChitantaInfo info)
        {
            try
            {
                _repo.IntervalChitantaDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult IntervalChitantaSeteazaUrmatorulNumarDeChitanta(int idUtilizator)
        {
            try
            {
                var numar = _repo.IntervalChitantaSeteazaUrmatorulNumarDeChitanta(idUtilizator);
                return Ok(numar);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
