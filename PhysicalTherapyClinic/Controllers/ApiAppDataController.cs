using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Controllers
{

    [ApiController]
    public class ApiAppDataController : ControllerBase
    {
        private readonly IDropDownListService _dropDownListService;
        public ApiAppDataController(IDropDownListService dropDownListService)
        {
            _dropDownListService = dropDownListService;
        }

        [Route("api/ApiAppData/AddCompany")]
        [HttpPost]
        public async Task<IActionResult> AddCompany(AddCompanyViewModel addCompany)
        {            
            return Ok(await _dropDownListService.AddCompany(addCompany));
        }

        [Route("api/ApiAppData/AddService")]
        [HttpPost]
        public async Task<IActionResult> AddService(AddServiceViewModel addService)
        {            
            return Ok(await _dropDownListService.AddService(addService));
        }

        [Route("api/ApiAppData/AddCompanyService")]
        [HttpPost]
        public async Task<IActionResult> AddCompanyService(AddCompanyServiceViewModel addCompanyService)
        {            
            return Ok(await _dropDownListService.AddCompanyService(addCompanyService));
        }

    }
}
