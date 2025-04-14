using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class EvaluareProfesorController : DnnApiController
    {
        private readonly IEvaluareProfesorRepo _repo = new EvaluareProfesorRepo();

        public EvaluareProfesorController()
        {

        }


        public EvaluareProfesorController(IEvaluareProfesorRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorList()
        {
            try
            {
                var result = _repo.EvaluareProfesorList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListNrChestionareCompletate(long idAnUniv, int nrSemestru)
        {
            try
            {
                var result = _repo.EvaluareProfesorListNrChestionareCompletate(idAnUniv, nrSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListNrChestionareCompletate_Prof(long idAnUniv, int nrSemestru)
        {
            try
            {
                var result = _repo.EvaluareProfesorListNrChestionareCompletate_Prof(idAnUniv, nrSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult EvaluareProfesorListProfiDeEvaluat(long idAnUniv, int nrSemestru)
        {
            try
            {
                var result = _repo.EvaluareProfesorListProfiDeEvaluat(idAnUniv, nrSemestru);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult EvaluareProfesorAdd([FromBody] EvaluareProfesorInfo info)
        {
            try
            {
                _repo.EvaluareProfesorAdd(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult EvaluareProfesorUpdate([FromBody] EvaluareProfesorInfo info)
        {
            try
            {
                _repo.EvaluareProfesorUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult EvaluareProfesorDelete([FromBody] EvaluareProfesorInfo info)
        {
            try
            {
                _repo.EvaluareProfesorDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult EvaluareProfesorDeleteBySpecializareSemestru(long idProf, long idSpecializare, int nrSemestru, long idDps)
        {
            try
            {
                _repo.EvaluareProfesorDeleteBySpecializareSemestru(idProf, idSpecializare, nrSemestru, idDps);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult EvaluareProfesor_DeleteBySpecializareSemestru(long idSpecializare, int nrSemestru)
        {
            try
            {
                _repo.EvaluareProfesor_DeleteBySpecializareSemestru(idSpecializare, nrSemestru);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult EvaluareProfesorGenereazaCoduriEvaluare(long idAnUniv, int nrSemestru)
        {
            try
            {
                _repo.EvaluareProfesorGenereazaCoduriEvaluare(idAnUniv, nrSemestru);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult EvaluareProfesorGenereazaCoduriEvaluare_OLD(long idAnUniv, int nrSemestru)
        {
            try
            {
                _repo.EvaluareProfesorGenereazaCoduriEvaluare_OLD(idAnUniv, nrSemestru);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult EvaluareProfesorBifeazaProfesorDinStatImportatInDetaliuPlanSemestru(long idAnUniv)
        {
            try
            {
                _repo.EvaluareProfesorBifeazaProfesorDinStatImportatInDetaliuPlanSemestru(idAnUniv);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}