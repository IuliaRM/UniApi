using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class TipSesiuneExameneController : DnnApiController
    {
        private readonly ITipSesiuneExameneRepo _repo = new TipSesiuneExameneRepo();

        public TipSesiuneExameneController() { }

        [HttpGet]
        [Route("list")]
        public IHttpActionResult List()
        {
            var result = _repo.TipSesiuneExameneList();
            return Ok(result);
        }
    }
}