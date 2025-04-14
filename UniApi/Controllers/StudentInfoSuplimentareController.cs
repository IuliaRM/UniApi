using System.Web.Http;
using DotNetNuke.Web.Api;
using UniApi.DAL.Repos;
using UniApi;
using UniApi.Info;

namespace UniApi.Controllers
{
    [AllowAnonymous]
    public class StudentInfoSuplimentareController : DnnApiController
    {
        private readonly IStudentInfoSuplimentareRepo _repo = new StudentInfoSuplimentareRepo();

        public StudentInfoSuplimentareController() { }

        [HttpPost]
        [Route("add")]
        public IHttpActionResult Add([FromBody] StudentInfoSuplimentare sis)
        {
            if (sis == null || sis.ID_Student <= 0 || string.IsNullOrEmpty(sis.TipInfoSuplimentara))
            {
                return BadRequest("Obiectul StudentInfoSuplimentare nu poate fi null, ID_Student trebuie să fie pozitiv, iar TipInfoSuplimentara nu poate fi null sau gol.");
            }
            var id = _repo.StudentInfoSuplimentareAdd(sis);
            return Ok(new { ID = id });
        }

        [HttpPut]
        [Route("update")]
        public IHttpActionResult Update([FromBody] StudentInfoSuplimentare sis)
        {
            if (sis == null || sis.ID_StudentInformatii <= 0 || string.IsNullOrEmpty(sis.TipInfoSuplimentara))
            {
                return BadRequest("Obiectul StudentInfoSuplimentare nu poate fi null, ID_StudentInformatii trebuie să fie pozitiv, iar TipInfoSuplimentara nu poate fi null sau gol.");
            }
            var id = _repo.StudentInfoSuplimentareUpdate(sis);
            return Ok(new { ID = id });
        }

        [HttpDelete]
        [Route("delete/{idStudentInfo:long}")]
        public IHttpActionResult Delete(long idStudentInfo)
        {
            if (idStudentInfo <= 0)
            {
                return BadRequest("ID-ul trebuie să fie o valoare pozitivă.");
            }
            _repo.StudentInfoSuplimentareDelete(idStudentInfo);
            return Ok();
        }

        [HttpGet]
        [Route("list/{idStudent:long}")]
        public IHttpActionResult List(long idStudent)
        {
            var result = _repo.StudentInfoSuplimentareList(idStudent);
            return Ok(result);
        }
    }
}