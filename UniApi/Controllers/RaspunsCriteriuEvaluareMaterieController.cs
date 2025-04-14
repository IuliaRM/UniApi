using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;


namespace UniApi.Controllers
{
    public class RaspunsCriteriuEvaluareMaterieController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieGet(long idRaspunsCriteriuEvaluareMaterie)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            var result = repo.RaspunsCriteriuEvaluareMaterieGet(idRaspunsCriteriuEvaluareMaterie);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieListGet()
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            var result = repo.RaspunsCriteriuEvaluareMaterieListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieListByDetaliuPlanSemestruGet(long idDetaliuPlanSemestru)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            var result = repo.RaspunsCriteriuEvaluareMaterieListByDetaliuPlanSemestruGet(idDetaliuPlanSemestru);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieListByTipCriteriuEvaluareVarianteRaspunsGet(long idTipCriteriuEvaluareVariantaRaspuns)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            var result = repo.RaspunsCriteriuEvaluareMaterieListByTipCriteriuEvaluareVarianteRaspunsGet(idTipCriteriuEvaluareVariantaRaspuns);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieAdd([FromBody] RaspunsCriteriuEvaluareMaterieInfo objRaspunsCriteriuEvaluareMaterie)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            repo.RaspunsCriteriuEvaluareMaterieAdd(objRaspunsCriteriuEvaluareMaterie);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieUpdate([FromBody] RaspunsCriteriuEvaluareMaterieInfo objRaspunsCriteriuEvaluareMaterie)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            repo.RaspunsCriteriuEvaluareMaterieUpdate(objRaspunsCriteriuEvaluareMaterie);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult RaspunsCriteriuEvaluareMaterieDelete(long idRaspunsCriteriuEvaluareMaterie)
        {
            var repo = new RaspunsCriteriuEvaluareMaterieRepo();
            repo.RaspunsCriteriuEvaluareMaterieDelete(idRaspunsCriteriuEvaluareMaterie);
            return Ok();
        }
    }
}
