using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;

namespace UniApi.Controllers
{
    public class AnunturiController : DnnApiController
    {
        // Adăugare Anunț
        [HttpPost]
        public IHttpActionResult AnunturiAdd([FromBody] AnunturiInfo anunturiInfo)
        {
            var controller = new AnunturiController();
            bool result = controller.AnunturiAdd(anunturiInfo);
            return result ? Ok() : BadRequest("A apărut o eroare la adăugarea anunțului.");
        }

        // Obține un anunț după ID
        [HttpGet]
        public IHttpActionResult AnunturiGet(long idAnunt)
        {
            var controller = new AnunturiController();
            var anunt = controller.AnunturiGet(idAnunt);
            return anunt != null ? Ok(anunt) : NotFound();
        }

        // Obține lista de anunțuri
        [HttpGet]
        public IHttpActionResult AnunturiList()
        {
            var controller = new AnunturiController();
            var anunturiList = controller.AnunturiList();
            return Ok(anunturiList);
        }

        // Șterge un anunț
        [HttpDelete]
        public IHttpActionResult AnunturiDelete(long idAnunt)
        {
            var controller = new AnunturiController();
            controller.AnunturiDelete(idAnunt);
            return Ok();
        }

        // Actualizează un anunț
        [HttpPut]
        public IHttpActionResult AnunturiUpdate([FromBody] AnunturiInfo anunturiInfo)
        {
            var controller = new AnunturiController();
            bool result = controller.AnunturiUpdate(anunturiInfo);
            return result ? Ok() : BadRequest("A apărut o eroare la actualizarea anunțului.");
        }

        // Obține lista de anunțuri pentru un an universitar și facultate
        [HttpGet]
        public IHttpActionResult AnunturiListByAnUniv_Facultate(long idAnUniv, long idFacultate)
        {
            var controller = new AnunturiController();
            var anunturiList = controller.AnunturiListByAnUniv_Facultate(idAnUniv, idFacultate);
            return Ok(anunturiList);
        }

        // Obține lista de anunțuri pentru un student
        [HttpGet]
        public IHttpActionResult AnunturiListByStudent(long idAnUniv, long idAnStudiu, long idFacultate, long idFC, long idFCForma, long idDomeniu, long idSpecializare, long idGrupe)
        {
            var controller = new AnunturiController();
            var anunturiList = controller.AnunturiListByStudentAnUniv(idAnUniv, idAnStudiu, idFacultate, idFC, idFCForma, idDomeniu, idSpecializare, idGrupe);
            return Ok(anunturiList);
        }

        // Obține anunțuri pe pagină
        [HttpGet]
        public IHttpActionResult AnunturiListPaged(int pageIndex, int pageSize)
        {
            var controller = new AnunturiController();
            int totalRecords = 0;
            var anunturiList = controller.AnunturiList_Paged(pageIndex, pageSize, ref totalRecords);
            return Ok(new { TotalRecords = totalRecords, Anunturi = anunturiList });
        }
    }
}
