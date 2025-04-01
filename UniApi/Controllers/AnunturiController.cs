using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class AnunturiController : DnnApiController
    {
       
        [HttpPost]
        public IHttpActionResult AnunturiAdd([FromBody] AnunturiInfo anunturiInfo)
        {
            var repo = new AnunturiRepo(); // Assume you have a repository for DB operations
            bool result = repo.AnunturiAdd(anunturiInfo); // Call repository instead of recursive call

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest("A apărut o eroare la adăugarea anunțului.");
            }
        }

        // Obține un anunț după ID
        [HttpGet]
        public IHttpActionResult AnunturiGet(long idAnunt)
        {
            var repo = new AnunturiRepo(); // Use repository instead of self-referencing
            var anunt = repo.AnunturiGet(idAnunt); // Fetch the announcement from DB

            if (anunt != null)
            {
                return Ok(anunt);
            }
            else
            {
                return NotFound();
            }
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
            var repo = new AnunturiRepo(); // Use repository instead of self-referencing
            bool result = repo.AnunturiUpdate(anunturiInfo); // Call repository method

            if (result)
            {
                return Ok();
            }
            else
            {
                return BadRequest("A apărut o eroare la actualizarea anunțului.");
            }
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
            var anunturiList = controller.AnunturiListByStudent(idAnUniv, idAnStudiu, idFacultate, idFC, idFCForma, idDomeniu, idSpecializare, idGrupe);
            return Ok(anunturiList);
        }

        // Obține anunțuri pe pagină
        [HttpGet]
        public IHttpActionResult AnunturiListPaged(int pageIndex, int pageSize, ref int totalRecords)
        {
            var controller = new AnunturiController();
            var anunturiList = controller.AnunturiListPaged(pageIndex, pageSize, ref totalRecords);
            return Ok(new { TotalRecords = totalRecords, Anunturi = anunturiList });
        }
    }
}
