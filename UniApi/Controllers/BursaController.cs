using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{   
    public class BursaController : DnnApiController
    {
        private readonly IBursaRepo _repo = new BursaRepo();

        public BursaController()
        {

        }

        public BursaController(IBursaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult BursaGet(long idBursa)
        {
            try
            {
                var bursa = _repo.BursaGet(idBursa);
                if (bursa == null)
                    return NotFound();

                return Ok(bursa);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaList()
        {
            try
            {
                var list = _repo.BursaList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaListByStudent(long idStudent)
        {
            try
            {
                var list = _repo.BursaListByStudent(idStudent);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaListByAnUniv(long idAnUniv)
        {
            try
            {
                var list = _repo.BursaListByAnUniv(idAnUniv);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaListByTipBursa(long idTipBursa)
        {
            try
            {
                var list = _repo.BursaListByTipBursa(idTipBursa);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaListByDSG(long idDSG)
        {
            try
            {
                var list = _repo.BursaListByDSG(idDSG);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult BursaVizibileAddOrUpdate([FromBody] BursaInfo bursa)
        {
            try
            {
                int id = _repo.BursaVizibileAddOrUpdate(bursa);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult BursaVizibileGetByFacultate(long idFacultate)
        {
            try
            {
                var list = _repo.BursaVizibileGetByFacultate(idFacultate);
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult BursaAddOrUpdate([FromBody] BursaInfo bursa)
        {
            try
            {
                int id = _repo.BursaVizibileAddOrUpdate(bursa); // folosești același SP pentru add/update
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult BursaDelete(long idBursa)
        {
            try
            {
                bool deleted = _repo.BursaDelete(idBursa);
                if (!deleted)
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult BursaDeleteByStudentAnSemestru(long idStudent, long idAnUniv, long numarSemestru)
        {
            try
            {
                bool result = _repo.BursaDeleteByStudentAnSemestru(idStudent, idAnUniv, numarSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult BursaDeleteByStudentAnSemestruStatusNegativ(long idStudent, long idAnUniv, long numarSemestru)
        {
            try
            {
                bool result = _repo.BursaDeleteByStudentAnSemestruStatusNegativ(idStudent, idAnUniv, numarSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
