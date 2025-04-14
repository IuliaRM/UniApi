using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{

    public class MentorPracticaFirmaController : DnnApiController
    {
        private readonly IMentorPracticaFirmaRepo _repo = new MentorPracticaFirmaRepo();

        public MentorPracticaFirmaController()
        {

        }

        public MentorPracticaFirmaController(IMentorPracticaFirmaRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaGet(long idMentorPracticaFirma)
        {
            try
            {
                var result = _repo.MentorPracticaFirmaGet(idMentorPracticaFirma);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaList()
        {
            try
            {
                var result = _repo.MentorPracticaFirmaList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaListByIDFirma(long idFirma)
        {
            try
            {
                var result = _repo.MentorPracticaFirmaListByIDFirma(idFirma);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult MentorPracticaFirmaAdd([FromBody] MentorPracticaFirma info)
        {
            try
            {
                var id = _repo.MentorPracticaFirmaAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult MentorPracticaFirmaUpdate([FromBody] MentorPracticaFirma info)
        {
            try
            {
                _repo.MentorPracticaFirmaUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult MentorPracticaFirmaDelete(long idMentorPracticaFirma)
        {
            try
            {
                _repo.MentorPracticaFirmaDelete(idMentorPracticaFirma);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
