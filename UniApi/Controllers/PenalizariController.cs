using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class PenalizariController : DnnApiController
    {
        private readonly PenalizariRepo _penalizariRepo = new PenalizariRepo();

        [HttpGet]
        public IHttpActionResult PenalizariGet(long id)
        {
            var result = _penalizariRepo.PenalizariGet(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PenalizariAdd([FromBody]PenalizariInfo penalizare)
        {
            if (penalizare == null)
            {
                return BadRequest("Invalid input");
            }

            var id = _penalizariRepo.PenalizariAdd(penalizare);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PenalizariUpdate([FromBody] PenalizariInfo penalizare)
        {
            if (penalizare == null)
            {
                return BadRequest("Invalid input");
            }

            _penalizariRepo.PenalizariUpdate(penalizare);
            return Ok();
        }
    }
}
