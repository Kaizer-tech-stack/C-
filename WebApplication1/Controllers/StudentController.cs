using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                ID = 1,
                Name = "Cloud",
                Grade = 95
            };

            return View(student);
        }
    }
}