using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TrunchiController : DnnApiController
    {

        [HttpGet]
        public IHttpActionResult TrunchiGet(long idTrunchi)
        {
            var result = TrunchiGet(idTrunchi);
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TrunchiListGet()
        {
            var result = TrunchiListGet();
            return Ok(result);
        }

        [HttpGet]
        public IHttpActionResult TrunchiListDistinctMinGet()
        {
            var result = TrunchiListDistinctMinGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TrunchiAdd([FromBody] TrunchiInfo trunchiInfo)
        {
            var id = TrunchiAdd(trunchiInfo);
            return Ok(id);
        }

        [HttpPut]
        public IHttpActionResult TrunchiUpdate([FromBody] TrunchiInfo trunchiInfo)
        {
            TrunchiUpdate(trunchiInfo);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult TrunchiDelete(long idTrunchi)
        {
            TrunchiDelete(idTrunchi);
            return Ok();
        }
    }
}
