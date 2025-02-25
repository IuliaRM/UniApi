using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class MentorPracticaFirmaController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaGet(long idMentorPracticaFirma)
        {
            var repo = new MentorPracticaFirmaRepo();
            var result = repo.MentorPracticaFirmaGet(idMentorPracticaFirma);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaList()
        {
            var repo = new MentorPracticaFirmaRepo();
            var result = repo.MentorPracticaFirmaList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult MentorPracticaFirmaListByIDFirma(long idFirma)
        {
            var repo = new MentorPracticaFirmaRepo();
            var result = repo.MentorPracticaFirmaListByIDFirma(idFirma);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult MentorPracticaFirmaAdd([FromBody] MentorPracticaFirma objMentorPracticaFirma)
        {
            var repo = new MentorPracticaFirmaRepo();
            repo.MentorPracticaFirmaAdd(objMentorPracticaFirma);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult MentorPracticaFirmaUpdate([FromBody] MentorPracticaFirma objMentorPracticaFirma)
        {
            var repo = new MentorPracticaFirmaRepo();
            repo.MentorPracticaFirmaUpdate(objMentorPracticaFirma);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult MentorPracticaFirmaDelete(long idMentorPracticaFirma)
        {
            var repo = new MentorPracticaFirmaRepo();
            repo.MentorPracticaFirmaDelete(idMentorPracticaFirma);
            return Ok();
        }
    }
}
