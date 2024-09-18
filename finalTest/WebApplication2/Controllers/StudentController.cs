using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // render the creation 
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            return View();
        }

        [HttpDelete]
        public ViewResult Delete(int id) 
        { 
            return View();
        }
        [HttpGet]
        public ViewResult Register()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Register(int studentId, int courseId)
        {

        return View(); 
        }

    }
}
