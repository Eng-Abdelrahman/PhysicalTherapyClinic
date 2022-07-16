using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IDropDownListService _dropDownListService;
        public CompanyController(IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _dropDownListService.GetCompanies());
        }
    }
}
