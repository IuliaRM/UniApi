using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Info;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class DepartamentController : DnnApiController
    {
        private readonly IDepartamentRepo _repo = new DepartamentRepo();

        public DepartamentController()
        {

        }

        public DepartamentController(IDepartamentRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IHttpActionResult DepartamentGet(long idDepartament)
        {
            try
            {
                var departament = _repo.DepartamentGet(idDepartament);
                return departament != null ? (IHttpActionResult)Ok(departament) : NotFound();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult DepartamentList()
        {
            try
            {
                var list = _repo.DepartamentList();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult DepartamentAdd([FromBody] DepartamentInfo info)
        {
            try
            {
                var id = _repo.DepartamentAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult DepartamentUpdate([FromBody] DepartamentInfo info)
        {
            try
            {
                _repo.DepartamentUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult DepartamentDelete(long idDepartament)
        {
            try
            {
                var existing = _repo.DepartamentGet(idDepartament);
                if (existing == null)
                    return NotFound();

                _repo.DepartamentDelete(idDepartament);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
