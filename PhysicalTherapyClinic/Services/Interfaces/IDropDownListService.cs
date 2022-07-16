using PhysicalTherapyClinic.Models;

namespace PhysicalTherapyClinic.Services.Interfaces
{
    public interface IDropDownListService
    {
        Task<List<CompanyViewModel>> GetCompanies();
        Task<List<ServiceViewModel>> GetServices();
        Task<List<CompanyServiceViewModel>> GetCompanyServices(Guid companyId);
        Task<int> AddCompany(AddCompanyViewModel addCompanyViewModel);
        Task<int> AddService(AddServiceViewModel addServiceViewModel);
        Task<int> AddCompanyService(AddCompanyServiceViewModel addCompanyServiceViewModel);
        Task<List<CompanyServiceViewModel>> GetCompanyServices();
    }
}
