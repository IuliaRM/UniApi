using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class LichidareController : DnnApiController
    {
        private readonly LichidareRepo _repo = new LichidareRepo();

        [HttpPost]
        public IHttpActionResult LichidareSecretariatMerge(long ID_Lichidare, long ID_Absolvent, long ID_Student, long ID_AnUniv, long ID_Specializare, string UsernameInitiere)
        {
            _repo.LichidareSecretariatMerge(ID_Lichidare, ID_Absolvent, ID_Student, ID_AnUniv, ID_Specializare, UsernameInitiere);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult LichidareInitiereAutomata()
        {
            _repo.LichidareInitiereAutomata();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult LichidareSecretariatDeselecteaza(long ID_Lichidare, string Username, string ColoanaDebifata)
        {
            _repo.LichidareSecretariatDeselecteaza(ID_Lichidare, Username, ColoanaDebifata);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult LichidareStudentByIDGet(long ID_Lichidare)
        {
            var lichidare = _repo.LichidareStudentByIDGet(ID_Lichidare);
            return Ok(lichidare);
        }
    }
}
