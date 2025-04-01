using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class AvertismentController : DnnApiController
    {
        private readonly AvertismentRepo _repo = new AvertismentRepo();

       
        [HttpGet]
        public IHttpActionResult AvertismentGet(long idAvertisment)
        {
            var repo = new AvertismentRepo(); // Ensure repository is properly instantiated
            var avertisment = repo.AvertismentGet(idAvertisment); // Fetch data

            if (avertisment != null)
            {
                return Ok(avertisment);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpGet]
        public IHttpActionResult AvertismentList()
        {
            var avertismente = _repo.AvertismentList();
            return Ok(avertismente);
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByCazare(long idCazare)
        {
            var avertismente = _repo.AvertismentListByCazare(idCazare);
            return Ok(avertismente);
        }

        [HttpGet]
        public IHttpActionResult AvertismentListByTipAvertisment(long idTipAvertisment)
        {
            var avertismente = _repo.AvertismentListByTipAvertisment(idTipAvertisment);
            return Ok(avertismente);
        }

        [HttpPost]
        public IHttpActionResult AvertismentAdd([FromBody] AvertismentInfo avertisment)
        {
            var repo = new AvertismentRepo(); // Ensure repository is properly instantiated
            int id = repo.AvertismentAdd(avertisment); // Insert the record and get the ID

            if (id > 0)
            {
                return Ok(id); // Return the new ID if successful
            }
            else
            {
                return BadRequest("Eroare la adãugarea avertismentului."); // Handle insert failure
            }
        }


        [HttpPut]
        public IHttpActionResult AvertismentUpdate([FromBody] AvertismentInfo avertisment)
        {
            _repo.AvertismentUpdate(avertisment);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult AvertismentDelete(long idAvertisment)
        {
            var avertisment = _repo.AvertismentGet(idAvertisment);
            if (avertisment == null)
            {
                return NotFound();
            }

            _repo.AvertismentDelete(idAvertisment);
            return Ok();
        }
    }
}
