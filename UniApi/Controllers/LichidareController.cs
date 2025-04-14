using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{

    public class LichidareController : DnnApiController
    {
        private readonly ILichidareRepo _repo = new LichidareRepo();

        public LichidareController()
        {

        }

        public LichidareController(ILichidareRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult LichidareSecretariatMerge(long idLichidare, long idAbsolvent, long idStudent, long idAnUniv, long idSpecializare, string usernameInitiere)
        {
            try
            {
                _repo.LichidareSecretariatMerge(idLichidare, idAbsolvent, idStudent, idAnUniv, idSpecializare, usernameInitiere);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LichidareInitiereAutomata()
        {
            try
            {
                _repo.LichidareInitiereAutomata();
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult LichidareSecretariatDeselecteaza(long idLichidare, string username, string coloanaDebifata)
        {
            try
            {
                _repo.LichidareSecretariatDeselecteaza(idLichidare, username, coloanaDebifata);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LichidareStudentByIDGet(long idLichidare)
        {
            try
            {
                var result = _repo.LichidareStudentGetByID(idLichidare);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}

