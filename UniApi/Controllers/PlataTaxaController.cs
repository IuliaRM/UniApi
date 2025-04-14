using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;
namespace UniApi.Controllers
{
    public class PlataTaxaController : DnnApiController
    {
        private readonly IPlataTaxaRepo _repo = new PlataTaxaRepo();

        public PlataTaxaController()
        {

        }

        public PlataTaxaController(IPlataTaxaRepo repo)
        {
            _repo = repo;
        }

        
        [HttpGet]
        public IHttpActionResult PlataTaxa_GetStudentByCaractere(string caractereDinNume, int lungimeLista, long idAnUniv)
        {
            try
            {
                var result = _repo.PlataTaxa_GetStudentByCaractere(caractereDinNume, lungimeLista, idAnUniv);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PlataTaxa_StudentGetByID(long idStudent)
        {
            try
            {
                var result = _repo.PlataTaxa_StudentGetByID(idStudent);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        

        
        [HttpGet]
        public IHttpActionResult PlataTaxa_GetUltimulNumarChitanta(int userId)
        {
            try
            {
                var result = _repo.PlataTaxa_GetUltimulNumarChitanta(userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PlataTaxa_GetStudentByID_RataTaxa(long idRataTaxa)
        {
            try
            {
                var result = _repo.PlataTaxa_GetStudentByID_RataTaxa(idRataTaxa);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PlataTaxa_GhetChitanteDinData(DateTime dataChitanta)
        {
            try
            {
                var result = _repo.PlataTaxa_GhetChitanteDinData(dataChitanta);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PlataTaxa_AnuleazaChitanta(long idRataTaxa, int userId)
        {
            try
            {
                _repo.PlataTaxa_AnuleazaChitanta(idRataTaxa, userId);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PlataTaxa_StergeChitanta(long idRataTaxa, int userId)
        {
            try
            {
                _repo.PlataTaxa_StergeChitanta(idRataTaxa, userId);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        

        
        [HttpPost]
        public IHttpActionResult PlataTaxa_InsertRata([FromBody] InsertRataRequest request)
        {
            try
            {
                if (request == null) return BadRequest("Request cannot be null");

                var id = _repo.PlataTaxa_InsertRata(
                    request.IdTaxeStudent, request.SumaPlatita, request.DataChitanta,
                    request.SerieChitanta, request.NumarChitanta, request.ContContabil,
                    request.UserId, request.IdTipPlata);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PlataTaxa_InsertRata_DacaNuExistaEPID([FromBody] InsertRataEPIDRequest request)
        {
            try
            {
                if (request == null) return BadRequest("Request cannot be null");

                var id = _repo.PlataTaxa_InsertRata_DacaNuExistaEPID(
                    request.IdTaxeStudent, request.SumaPlatita, request.DataChitanta,
                    request.SerieChitanta, request.NumarChitanta, request.ContContabil,
                    request.UserId, request.IdTipPlata, request.EPID);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID([FromBody] InsertRataTaxaStudentEPIDRequest request)
        {
            try
            {
                if (request == null) return BadRequest("Request cannot be null");

                var id = _repo.PlataTaxa_InsertRata_DacaNuExistaID_TaxeStudentSiEPID(
                    request.IdStudent, request.SumaPlatita, request.DataChitanta,
                    request.SerieChitanta, request.NumarChitanta, request.ContContabil,
                    request.UserId, request.IdTipPlata, request.EPID);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult PlataTaxa_InsertRata_Direct([FromBody] InsertRataDirectRequest request)
        {
            try
            {
                if (request == null) return BadRequest("Request cannot be null");

                var id = _repo.PlataTaxa_InsertRata_Direct(
                    request.IdStudent, request.IdFacultate, request.IdTaxa, request.IdIstoricTaxe,
                    request.DataChitanta, request.SerieChitanta, request.NumarChitanta,
                    request.SumaPlatita, request.ContContabil, request.IdFc, request.IdTipFormaInv,
                    request.IdAnUnivCurent, request.IdCamin, request.UserId, request.PrimaZiDinLunaStart,
                    request.UltimaZiDinLunaStart, request.SumaPenalizareCalculateInProgram, request.IdTipPlata);

                return Ok(id);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        

        
        [HttpGet]
        public IHttpActionResult PlataTaxa_GetContContabil(long idContContabil)
        {
            try
            {
                var result = _repo.PlataTaxa_GetContContabil(idContContabil);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult PlataTaxa_GetTipTaxa(long idTipTaxa)
        {
            try
            {
                var result = _repo.PlataTaxa_GetTipTaxa(idTipTaxa);
                if (result == null) return NotFound();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        

       
    }

    
    public class InsertRataRequest
    {
        public long IdTaxeStudent { get; set; }
        public double SumaPlatita { get; set; }
        public DateTime DataChitanta { get; set; }
        public string SerieChitanta { get; set; }
        public string NumarChitanta { get; set; }
        public long ContContabil { get; set; }
        public int UserId { get; set; }
        public int IdTipPlata { get; set; }
    }

    public class InsertRataEPIDRequest : InsertRataRequest
    {
        public string EPID { get; set; }
    }

    public class InsertRataTaxaStudentEPIDRequest
    {
        public long IdStudent { get; set; }
        public double SumaPlatita { get; set; }
        public DateTime DataChitanta { get; set; }
        public string SerieChitanta { get; set; }
        public string NumarChitanta { get; set; }
        public long ContContabil { get; set; }
        public int UserId { get; set; }
        public int IdTipPlata { get; set; }
        public string EPID { get; set; }
    }

    public class InsertRataDirectRequest
    {
        public long IdStudent { get; set; }
        public long IdFacultate { get; set; }
        public long IdTaxa { get; set; }
        public long IdIstoricTaxe { get; set; }
        public DateTime DataChitanta { get; set; }
        public string SerieChitanta { get; set; }
        public string NumarChitanta { get; set; }
        public double SumaPlatita { get; set; }
        public long ContContabil { get; set; }
        public long IdFc { get; set; }
        public long IdTipFormaInv { get; set; }
        public string IdAnUnivCurent { get; set; }
        public long IdCamin { get; set; }
        public int UserId { get; set; }
        public DateTime PrimaZiDinLunaStart { get; set; }
        public DateTime UltimaZiDinLunaStart { get; set; }
        public double SumaPenalizareCalculateInProgram { get; set; }
        public int IdTipPlata { get; set; }
    }
    
}