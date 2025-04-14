using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Collections.Generic;

namespace UniApi.Controllers
{ 

    public class NotaController : DnnApiController
    {
        private readonly INotaRepo _repo = new NotaRepo();

        public NotaController()
        {

        }

        public NotaController(INotaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult NotaGet(long idNota)
        {
            try
            {
                var result = _repo.NotaGet(idNota);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult NotaList()
        {
            try
            {
                var result = _repo.NotaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult NotaAdd([FromBody] NotaInfo nota)
        {
            try
            {
                var id = _repo.NotaAdd(nota);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult NotaUpdate([FromBody] NotaInfo nota)
        {
            try
            {
                _repo.NotaUpdate(nota);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult NotaDelete(long idNota)
        {
            try
            {
                _repo.NotaDelete(idNota);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult NotaEchivaleaza(long idRestanta, long idEchivalare, long idStudent, int idUtilizator)
        {
            try
            {
                _repo.NotaEchivaleaza(idRestanta, idEchivalare, idStudent, idUtilizator);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}