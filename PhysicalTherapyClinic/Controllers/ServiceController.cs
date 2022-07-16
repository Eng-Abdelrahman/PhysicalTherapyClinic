using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
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

        public async Task<List<ServiceViewModel>> GetServices()
        {
            return await _dropDownListService.GetServices();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddServiceViewModel addService)
        {
            await _dropDownListService.AddService(addService);
            return RedirectToAction("Index");
        }
    }
}
