using System;
using System.Collections.Generic;
using System.Web.Http;
using UniApi.DAL.Repos;
using DotNetNuke.Web.Api;

namespace UniApi.Controllers
{
    public class PlataTaxaController : DnnApiController
    {
        private readonly PlataTaxaRepo _repo = new PlataTaxaRepo();

        [HttpGet]
        public IHttpActionResult StudentByCaractereGet(string caractereDinNume, int lungimeLista, long idAnUniv)
        {
            var result = _repo.StudentByCaractereGet(caractereDinNume, lungimeLista, idAnUniv);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult NextReceiptNumberGet(int userId)
        {
            var result = _repo.NextReceiptNumberGet(userId);
            return Ok(result);
        }

        /* [HttpPost]
        public IHttpActionResult InstallmentInsert([FromBody] InstallmentInfo installmentInfo)
        {
            var id = _repo.InstallmentInsert(installmentInfo.ID_TaxeStudent, installmentInfo.SumaPlatita, installmentInfo.DataChitanta, installmentInfo.SerieChitanta, installmentInfo.NumarChitanta, installmentInfo.ContContabil, installmentInfo.UserId, installmentInfo.ID_TipPlata, installmentInfo.EPID);
            return Ok(id);
        }

        [HttpPost]
        public IHttpActionResult InstallmentDirectInsert([FromBody] DirectInstallmentInfo directInstallmentInfo)
        {
            var id = _repo.InstallmentDirectInsert(directInstallmentInfo.ID_Student, directInstallmentInfo.ID_Facultate, directInstallmentInfo.ID_Taxa, directInstallmentInfo.ID_IstoricTaxe, directInstallmentInfo.DataChitanta, directInstallmentInfo.SerieChitanta, directInstallmentInfo.NumarChitanta, directInstallmentInfo.SumaPlatita, directInstallmentInfo.ContContabil, directInstallmentInfo.ID_FC, directInstallmentInfo.ID_TipFormaInv, directInstallmentInfo.ID_AnUniv_Curent, directInstallmentInfo.ID_Camin, directInstallmentInfo.UserId, directInstallmentInfo.PrimaZiDinLunaStart, directInstallmentInfo.UltimaZiDinLunaStart, directInstallmentInfo.SumaPenalizareCalculateInProgram, directInstallmentInfo.ID_TipPlata);
            return Ok(id);
        } */

        [HttpGet]
        public IHttpActionResult ReceiptDataGenerate(long idRataTaxa)
        {
            var result = _repo.ReceiptDataGenerate(idRataTaxa);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult ReceiptCancel(long idRataTaxa, int userId)
        {
            _repo.ReceiptCancel(idRataTaxa, userId);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult ReceiptDelete(long idRataTaxa, int userId)
        {
            _repo.ReceiptDelete(idRataTaxa, userId);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult CollectionsByPeriodTypeGet(DateTime deLaData, DateTime pinaLaData, long idFacultate, long idTipTaxa, int idUtilizator, long idAnUniv, int idTipPlata)
        {
            var result = _repo.CollectionsByPeriodTypeGet(deLaData, pinaLaData, idFacultate, idTipTaxa, idUtilizator, idAnUniv, idTipPlata);
            return Ok(result);
        }
    }
}
