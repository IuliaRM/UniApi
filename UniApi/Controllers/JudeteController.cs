using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{
    public class JudeteController : DnnApiController
    {
        private readonly IJudeteRepo _repo = new JudeteRepo();

        public JudeteController()
        {

        }

        public JudeteController(IJudeteRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult JudeteGet(string idJudet)
        {
            try
            {
                var result = _repo.JudeteGet(idJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult JudeteByID_N_JudetGet(int idNJudet)
        {
            try
            {
                var result = _repo.JudeteGetByID_N_Judet(idNJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult JudeteByDenumireGet(string denumireJudet)
        {
            try
            {
                var result = _repo.JudeteGetByDenumire(denumireJudet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult JudeteList()
        {
            try
            {
                var result = _repo.JudeteList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult JudeteListByCaractere(string caractere, int topN)
        {
            try
            {
                var result = _repo.JudeteListByCaractere(caractere, topN);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult JudeteAdd([FromBody] JudeteInfo info)
        {
            try
            {
                var id = _repo.JudeteAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult JudeteUpdate([FromBody] JudeteInfo info)
        {
            try
            {
                _repo.JudeteUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult JudeteDelete([FromBody] JudeteInfo info)
        {
            try
            {
                _repo.JudeteDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
