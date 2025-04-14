using System;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;
using System.Data;

namespace UniApi.Controllers
{

    public class LocuriCameraController : DnnApiController
    {
        private readonly ILocuriCameraRepo _repo = new LocuriCameraRepo();

        public LocuriCameraController()
        {

        }

        public LocuriCameraController(ILocuriCameraRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraGet(long idLocuriCamera)
        {
            try
            {
                var result = _repo.LocuriCameraGet(idLocuriCamera);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraList()
        {
            try
            {
                var result = _repo.LocuriCameraList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraListByAnUniversitar(long idAnUniversitar)
        {
            try
            {
                var result = _repo.LocuriCameraListByAnUniversitar(idAnUniversitar);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult LocuriCameraListByCamera(long idCamera)
        {
            try
            {
                var result = _repo.LocuriCameraListByCamera(idCamera);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LocuriCameraAdd([FromBody] LocuriCameraInfo info)
        {
            try
            {
                var id = _repo.LocuriCameraAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult LocuriCameraUpdate([FromBody] LocuriCameraInfo info)
        {
            try
            {
                _repo.LocuriCameraUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult LocuriCameraDelete(long idLocuriCamera)
        {
            try
            {
                _repo.LocuriCameraDelete(idLocuriCamera);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LocuriCameraMerge([FromBody] LocuriCameraInfo info)
        {
            try
            {
                _repo.LocuriCameraMerge(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult LocuriCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie)
        {
            try
            {
                _repo.LocuriCameraImportDinAltAnUniv(idAnUnivSursa, idAnUnivDestinatie);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
