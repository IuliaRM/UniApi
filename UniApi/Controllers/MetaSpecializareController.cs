using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi;
using UniApi.Dal.Repos;
using DotNetNuke.Common.Utilities;
using Microsoft.ApplicationBlocks.Data;
using System.Configuration;
using System.ComponentModel;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class MetaSpecializareController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult MetaSpecializareGet(long idMetaSpecializare)
        {
            var repo = new MetaSpecializareRepo();
            var result = repo.MetaSpecializareGet(idMetaSpecializare);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareList()
        {
            var repo = new MetaSpecializareRepo();
            var result = repo.MetaSpecializareList();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareListByFacultate(long idFacultate)
        {
            var repo = new MetaSpecializareRepo();
            var result = repo.MetaSpecializareListByFacultate(idFacultate);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult MetaSpecializareListBySpecializare(long idSpecializare)
        {
            var repo = new MetaSpecializareRepo();
            var result = repo.MetaSpecializareListBySpecializare(idSpecializare);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult MetaSpecializareAdd([FromBody] MetaSpecializareInfo objMetaSpecializare)
        {
            var repo = new MetaSpecializareRepo();
            repo.MetaSpecializareAdd(objMetaSpecializare);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult MetaSpecializareUpdate([FromBody] MetaSpecializareInfo objMetaSpecializare)
        {
            var repo = new MetaSpecializareRepo();
            repo.MetaSpecializareUpdate(objMetaSpecializare);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult MetaSpecializareDelete(long idMetaSpecializare)
        {
            var repo = new MetaSpecializareRepo();
            repo.MetaSpecializareDelete(idMetaSpecializare);
            return Ok();
        }
    }
}
