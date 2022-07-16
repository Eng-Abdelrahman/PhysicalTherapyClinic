using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{
    public class CompanyServiceController : Controller
    {
        private readonly IDropDownListService _dropDownListService;
        public CompanyServiceController(IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dropDownListService.GetCompanyServices());
        }

        public async Task<IActionResult> Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCompanyServiceViewModel addCompanyService)
        {
            await _dropDownListService.AddCompanyService(addCompanyService);
            return RedirectToAction("Index");
        }
    }
}
