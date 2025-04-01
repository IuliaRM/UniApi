using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;
using System.Collections.Generic;

namespace UniApi.Controllers
{
    public class FacultateCameraController : DnnApiController
    {
        private readonly FacultateCameraRepo _repo = new FacultateCameraRepo();

        [HttpGet]
        public IHttpActionResult FacultateCameraGet(long ID_FacultateCamera)
        {
            var camera = _repo.FacultateCameraGet(ID_FacultateCamera);
            return Ok(camera);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraByFacultateCameraGet(long ID_Facultate, long ID_Camera, long ID_AnUniv)
        {
            var camera = _repo.FacultateCameraByFacultateCameraGet(ID_Facultate, ID_Camera, ID_AnUniv);
            return Ok(camera);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListGet()
        {
            var camere = _repo.FacultateCameraListGet();
            return Ok(camere);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByAnUniversitarGet(long ID_AnUniv)
        {
            var camere = _repo.FacultateCameraListByAnUniversitarGet(ID_AnUniv);
            return Ok(camere);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultateGet(long ID_Facultate)
        {
            var camere = _repo.FacultateCameraListByFacultateGet(ID_Facultate);
            return Ok(camere);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByFacultateAnUnivGet(long ID_Facultate, long ID_AnUniv)
        {
            var camere = _repo.FacultateCameraListByFacultateAnUnivGet(ID_Facultate, ID_AnUniv);
            return Ok(camere);
        }

        [HttpGet]
        public IHttpActionResult FacultateCameraListByCameraGet(long ID_Camera)
        {
            var camere = _repo.FacultateCameraListByCameraGet(ID_Camera);
            return Ok(camere);
        }

        [HttpPost]
        public IHttpActionResult FacultateCameraAdd([FromBody] FacultateCameraInfo objFacultateCamera)
        {
            var id = _repo.FacultateCameraAdd(objFacultateCamera);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult FacultateCameraUpdate([FromBody] FacultateCameraInfo objFacultateCamera)
        {
            _repo.FacultateCameraUpdate(objFacultateCamera);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult FacultateCameraDelete([FromBody] FacultateCameraInfo objFacultateCamera)
        {
            _repo.FacultateCameraDelete(objFacultateCamera);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult FacultateCameraDeleteByFacultateCamera(long ID_Facultate, long ID_Camera)
        {
            _repo.FacultateCameraDeleteByFacultateCamera(ID_Facultate, ID_Camera);
            return Ok();
        }
    }
}
