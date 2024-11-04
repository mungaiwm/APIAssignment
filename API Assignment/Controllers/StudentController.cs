using API_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            Student student = new Student(5, "Mary");
            
            return Ok(student);
        }
    }
}
