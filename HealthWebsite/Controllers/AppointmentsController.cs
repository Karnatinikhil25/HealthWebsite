using Microsoft.AspNetCore.Mvc;

namespace HealthWebsite.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Book()
        {
            ViewData["Message"] = "Book an appointment.";
            return View();
        }
    }
}
