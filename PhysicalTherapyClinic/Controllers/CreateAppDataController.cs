using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{

    [ApiController]
    public class CreateAppDataController : ControllerBase
    {
        private readonly IDropDownListService _dropDownListService;
        public CreateAppDataController(IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
        }

        [Route("api/CreateAppData/AddCompany")]
        [HttpPost]
        public async Task<IActionResult> AddCompany(AddCompanyViewModel addCompany)
        {            
            return Ok(await _dropDownListService.AddCompany(addCompany));
        }

        [Route("api/CreateAppData/AddService")]
        [HttpPost]
        public async Task<IActionResult> AddService(AddServiceViewModel addService)
        {            
            return Ok(await _dropDownListService.AddService(addService));
        }

        [Route("api/CreateAppData/AddCompanyService")]
        [HttpPost]
        public async Task<IActionResult> AddCompanyService(AddCompanyServiceViewModel addCompanyService)
        {            
            return Ok(await _dropDownListService.AddCompanyService(addCompanyService));
        }

    }
}
