using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace health_club.API.Controllers
{

    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        // GET (HTTP verb):  https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "Mark" };

            return Ok(studentNames);
        }
    }
}

