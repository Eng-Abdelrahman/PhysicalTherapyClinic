using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
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

        public async Task<List<CompanyViewModel>> GetCompanies()
        {
            return await _dropDownListService.GetCompanies();
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }  
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCompanyViewModel addCompany)
        {
            await _dropDownListService.AddCompany(addCompany);
            return RedirectToAction("Index");
        }
    }
}
