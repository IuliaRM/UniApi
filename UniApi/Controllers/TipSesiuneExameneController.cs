/*
' Module: Your Module
' Copyright (c) 2019 YourCompany
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/
using System.Collections.Generic;
using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    public class TipSesiuneExameneController : DnnApiController
    {
        [HttpGet]
        public IHttpActionResult TipSesiuneExameneListGet()
        {
            var repo = new TipSesiuneExameneRepo();
            var result = repo.TipSesiuneExameneListGet();
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult TipSesiuneExameneAdd([FromBody] TipSesiuneExameneInfo sesiuneInfo)
        {
            if (sesiuneInfo == null)
                return BadRequest("Invalid session data.");

            var repo = new TipSesiuneExameneRepo();
            var id = repo.TipSesiuneExameneAdd(sesiuneInfo);
            return Ok(id); 
        }

        [HttpDelete]
        public IHttpActionResult TipSesiuneExameneDelete(long idSesiune)
        {
            var repo = new TipSesiuneExameneRepo();
            repo.TipSesiuneExameneDelete(idSesiune);
            return Ok(); 
        }
    }
}

