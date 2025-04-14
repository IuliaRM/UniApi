using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class CatedraProfesorController : DnnApiController
    {
        private readonly ICatedraProfesorRepo _repo = new CatedraProfesorRepo();

        public CatedraProfesorController()
        {

        }

        public CatedraProfesorController(ICatedraProfesorRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IHttpActionResult CatedraProfesorAdd([FromBody] CatedraProfesorInfo info)
        {
            try
            {
                long id = _repo.CatedraProfesorAdd(info);
                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult CatedraProfesorUpdate([FromBody] CatedraProfesorInfo info)
        {
            try
            {
                _repo.CatedraProfesorUpdate(info);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult CatedraProfesorDelete(long idCatedraProfesor)
        {
            try
            {
                var profesor = _repo.CatedraProfesorGet(idCatedraProfesor);
                if (profesor == null)
                    return NotFound();

                _repo.CatedraProfesorDelete(idCatedraProfesor);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorGet(long idCatedraProfesor)
        {
            try
            {
                var profesor = _repo.CatedraProfesorGet(idCatedraProfesor);
                if (profesor == null)
                    return NotFound();

                return Ok(profesor);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorGetByProfesor(long idProfesor)
        {
            try
            {
                var lista = _repo.CatedraProfesorGetByProfesor(idProfesor);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorGetByProfesorAnUniv(long idProfesor, long idAnUniv)
        {
            try
            {
                var lista = _repo.CatedraProfesorGetByProfesorAnUniv(idProfesor, idAnUniv);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedra(long idCatedra)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedra(idCatedra);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraAnUniv(idCatedra, idAnUniv);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraAnCalendaristicFRACSActiv(long idCatedra, long idAnCalendaristic)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraAnCalendaristicFRACSActiv(idCatedra, idAnCalendaristic);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraCercetator(long idCatedra)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraCercetator(idCatedra);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraProfesorActiv(long idCatedra)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraProfesorActiv(idCatedra);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraProfesorInactiv(long idCatedra)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraProfesorInactiv(idCatedra);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListByCatedraProfesorTitularByAnUniv(long idCatedra, long idAnUniv)
        {
            try
            {
                var lista = _repo.CatedraProfesorListByCatedraProfesorTitularByAnUniv(idCatedra, idAnUniv);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult CatedraProfesorListbyProfesor(long idProfesor)
        {
            try
            {
                var lista = _repo.CatedraProfesorListbyProfesor(idProfesor);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
