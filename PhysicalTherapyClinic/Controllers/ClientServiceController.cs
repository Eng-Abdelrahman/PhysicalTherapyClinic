using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{
    public class ClientServiceController : Controller
    {
        private readonly IDropDownListService _dropDownListService;
        private readonly IClientServicesService _clientServicesService;
        public ClientServiceController(IClientServicesService clientServicesService, IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
            _clientServicesService = clientServicesService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clientServicesService.GetClientServices());
        }

        public IActionResult Add()
        {
            return View();
        }
        #region logic

        [HttpGet]
        public async Task<List<CompanyViewModel>> GetCompanies()
        {
            return await _dropDownListService.GetCompanies();
        }

        [HttpGet]
        public async Task<List<CompanyServiceViewModel>> GetCompanyServices(Guid companyId)
        {
            return await _dropDownListService.GetCompanyServices(companyId);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddClinetServiceViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _clientServicesService.AddClientService(model);

                return RedirectToAction(nameof(Index));

            }
            return View(model);
        }
        #endregion

    }
}
