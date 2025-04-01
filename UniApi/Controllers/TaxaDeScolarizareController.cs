using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;

namespace UniApi.Controllers
{
    public class TaxaDeScolarizareController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult StudentiCuTaxaScolarizareAchitataMaiPutinDeProcentGet(long ID_AnUniv, long Id_FC, long Id_FCForma, long Id_AnStudiu, long Id_Domeniu, long Id_Specializare, long ID_Grupe, string FiltruTipIntrareIesire, int Procent)
        {
            var repo = new TaxaDeScolarizareRepo();
            var result = repo.StudentiCuTaxaScolarizareAchitataMaiPutinDeProcentGet(ID_AnUniv, Id_FC, Id_FCForma, Id_AnStudiu, Id_Domeniu, Id_Specializare, ID_Grupe, FiltruTipIntrareIesire, Procent);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TipTaxaScolarizareStudentAnCurentGet(long ID_Student, long ID_AnUniv)
        {
            var repo = new TaxaDeScolarizareRepo();
            var result = repo.TipTaxaScolarizareStudentAnCurentGet(ID_Student, ID_AnUniv);
            return Ok(result);
        }

        /* [HttpPost]
        public IHttpActionResult TaxaScolarizareAdd([FromBody] TaxaScolarizareInfo taxaInfo)
        {
            var repo = new TaxaDeScolarizareRepo();
            var id = repo.TaxaScolarizareAdd(taxaInfo);
            return Ok(id);
        } */

        [HttpDelete]
        public IHttpActionResult TaxaScolarizareDelete(long idTaxa)
        {
            var repo = new TaxaDeScolarizareRepo();
            repo.TaxaScolarizareDelete(idTaxa);
            return Ok();
        }
    }
}
