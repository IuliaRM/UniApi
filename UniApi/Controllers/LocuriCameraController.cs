using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class LocuriCameraController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult LocuriCameraGet(long idLocuriCamera)
        {
            var repo = new LocuriCameraRepo();
            var result = repo.LocuriCameraGet(idLocuriCamera);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraList()
        {
            var repo = new LocuriCameraRepo();
            var result = repo.LocuriCameraList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraListByAnUniversitar(long idAnUniversitar)
        {
            var repo = new LocuriCameraRepo();
            var result = repo.LocuriCameraListByAnUniversitar(idAnUniversitar);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraListByCamera(long idCamera)
        {
            var repo = new LocuriCameraRepo();
            var result = repo.LocuriCameraListByCamera(idCamera);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult LocuriCameraAdd([FromBody] LocuriCameraInfo locuriCameraInfo)
        {
            var repo = new LocuriCameraRepo();
            var id = repo.LocuriCameraAdd(locuriCameraInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult LocuriCameraUpdate([FromBody] LocuriCameraInfo locuriCameraInfo)
        {
            var repo = new LocuriCameraRepo();
            repo.LocuriCameraUpdate(locuriCameraInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult LocuriCameraDelete(long idLocuriCamera)
        {
            var repo = new LocuriCameraRepo();
            repo.LocuriCameraDelete(idLocuriCamera);
            return Ok();
        }
    }
}
