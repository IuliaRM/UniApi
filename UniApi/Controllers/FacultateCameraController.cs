using System;
using System.Web.Http;
using System.Data;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class FacultateCameraController : DnnApiController
    {
        private readonly IFacultateCameraRepo _repo = new FacultateCameraRepo();

        public FacultateCameraController()
        {

        }

        public FacultateCameraController(IFacultateCameraRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraGet(long idFacultateCamera)
        {
            try
            {
                var result = _repo.FacultateCameraGet(idFacultateCamera);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraByFacultateCameraGet(long idFacultate, long idCamera, long idAnUniv)
        {
            try
            {
                var result = _repo.FacultateCameraGetByFacultateCamera(idFacultate, idCamera, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraList()
        {
            try
            {
                var result = _repo.FacultateCameraList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByAnUniversitar(long idAnUniv)
        {
            try
            {
                var result = _repo.FacultateCameraListByAnUniversitar(idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultate(long idFacultate)
        {
            try
            {
                var result = _repo.FacultateCameraListByFacultate(idFacultate);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultateAnUniv(long idFacultate, long idAnUniv)
        {
            try
            {
                var result = _repo.FacultateCameraListByFacultateAnUniv(idFacultate, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultateAnUnivCamin(long idFacultate, long idAnUniv, long idCamin)
        {
            try
            {
                var result = _repo.FacultateCameraListByFacultateAnUnivCamin(idFacultate, idAnUniv, idCamin);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultateCaminEtajAnUniv(long idFacultate, long idCamin, int etaj, long idAnUniv)
        {
            try
            {
                var result = _repo.FacultateCameraListByFacultateCaminEtajAnUniv(idFacultate, idCamin, etaj, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByCamera(long idCamera)
        {
            try
            {
                var result = _repo.FacultateCameraListByCamera(idCamera);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraRaportLocuriByCaminAnUniv(long idCamin, long idAnUniv)
        {
            try
            {
                var result = _repo.FacultateCameraRaportLocuriByCaminAnUniv(idCamin, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult FacultateCameraAdd([FromBody] FacultateCameraInfo info)
        {
            try
            {
                var id = _repo.FacultateCameraAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult FacultateCameraUpdate([FromBody] FacultateCameraInfo info)
        {
            try
            {
                _repo.FacultateCameraUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult FacultateCameraMerge([FromBody] FacultateCameraInfo info)
        {
            try
            {
                _repo.FacultateCameraMerge(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult FacultateCameraImportDinAltAnUniv(long idAnUnivSursa, long idAnUnivDestinatie)
        {
            try
            {
                _repo.FacultateCameraImportDinAltAnUniv(idAnUnivSursa, idAnUnivDestinatie);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult FacultateCameraDelete([FromBody] FacultateCameraInfo info)
        {
            try
            {
                _repo.FacultateCameraDelete(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult FacultateCameraDeleteByFacultateCamera(long idFacultate, long idCamera)
        {
            try
            {
                _repo.FacultateCameraDeleteByFacultateCamera(idFacultate, idCamera);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
