using Microsoft.AspNetCore.Mvc;

namespace PhysicalTherapyClinic.Controllers
{
    public class AppDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddCompany()
        {
            return View();
        }

        public IActionResult AddService()
        {
            return View();
        }

        public IActionResult AddCompanyService()
        {
            return View();
        }

    }
}
