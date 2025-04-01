using System;
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class PostController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult PostGet(long idPost)
        {
            var repo = new PostRepo();
            var result = repo.PostGet(idPost);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostListGet()
        {
            var repo = new PostRepo();
            var result = repo.PostListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostListByAnUniversitarGet(long idAnUniv, long idScenariu)
        {
            var repo = new PostRepo();
            var result = repo.PostListByAnUniversitarGet(idAnUniv, idScenariu);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult PostListByCatedraGet(long idCatedra, long idAnUniv, long idScenariu)
        {
            var repo = new PostRepo();
            var result = repo.PostListByCatedraGet(idCatedra, idAnUniv, idScenariu);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult PostAdd([FromBody] PostInfo postInfo)
        {
            var repo = new PostRepo();
            var id = repo.PostAdd(postInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult PostUpdate([FromBody] PostInfo postInfo)
        {
            var repo = new PostRepo();
            repo.PostUpdate(postInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult PostDelete([FromBody] PostInfo postInfo)
        {
            var repo = new PostRepo();
            repo.PostDelete(postInfo);
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult OreConventionaleCalculate(long idPost)
        {
            var repo = new PostRepo();
            var result = repo.PostCalculOreConventionale(idPost);
            return Ok(result);
        }
    }
}
