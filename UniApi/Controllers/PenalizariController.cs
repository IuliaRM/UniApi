using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class PenalizariController : DnnApiController
    {
        private readonly IPenalizariRepo _penalizariRepo = new PenalizariRepo();

        public PenalizariController()
        {

        }
        public PenalizariController(IPenalizariRepo penalizariRepo)
        {
            _penalizariRepo = penalizariRepo;
        }

        [HttpGet]
        public IHttpActionResult PenalizariGet(long id)
        {
            try
            {
                var result = _penalizariRepo.PenalizariGet(id);
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PenalizariAdd([FromBody] PenalizariInfo penalizare)
        {
            try
            {
                if (penalizare == null)
                {
                    return BadRequest("Obiectul PenalizariInfo nu poate fi null");
                }

                var id = _penalizariRepo.PenalizariAdd(penalizare);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult PealizariUpdate([FromBody] PenalizariInfo penalizare)
        {
            try
            {
                if (penalizare == null)
                {
                    return BadRequest("Obiectul PenalizariInfo nu poate fi null");
                }

                _penalizariRepo.PenalizariUpdate(penalizare);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}