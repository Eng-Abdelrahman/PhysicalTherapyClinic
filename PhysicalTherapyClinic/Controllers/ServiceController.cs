using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IDropDownListService _dropDownListService;
        public ServiceController(IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dropDownListService.GetServices());
        }
    }
}
