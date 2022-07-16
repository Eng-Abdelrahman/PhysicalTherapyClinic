using Microsoft.EntityFrameworkCore;
using PhysicalTherapyClinic.Domain;
using PhysicalTherapyClinic.Domain.Entities;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Services
{
    public class DropDownListService : IDropDownListService
    {
        private readonly PTDBContext _dbContext;
        public DropDownListService(PTDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Get Data

        public async Task<List<CompanyViewModel>> GetCompanies()
        {
            try
            {
                List<Company> companies = await _dbContext.Companies.Where(q => !q.Is_Deleted).ToListAsync();

                List<CompanyViewModel> companiesViewModel = companies.Select(q => new CompanyViewModel
                {
                    CompanyId = q.Id,
                    CompanyName = q.Company_Name
                }).ToList();

                return companiesViewModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<CompanyServiceViewModel>> GetCompanyServices(Guid companyId)
        {
            try
            {
                List<CompanyService> companyServices = await _dbContext.CompanyServices.Include(q => q.Service).Where(q => !q.Is_Deleted && q.Company_Id == companyId).ToListAsync();

                List<CompanyServiceViewModel> companyServicesViewModel = companyServices.Select(q => new CompanyServiceViewModel
                {
                    CompanyServiceId = q.Id,
                    ServiceName = q.Service.Service_Name,
                    ServicePrice = q.Price,
                }).ToList();

                return companyServicesViewModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


        #region Create DropDown List

        public async Task<int> AddCompany(AddCompanyViewModel addCompanyViewModel)
        {
            try
            {

                Company company = new Company()
                {
                    Id = Guid.NewGuid(),
                    Company_Name = addCompanyViewModel.CompanyName,
                    Create_Date = DateTime.Now
                };

                _dbContext.Companies.Add(company);

                return await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<int> AddService(AddServiceViewModel addServiceViewModel)
        {
            try
            {

                Service service = new Service()
                {
                    Id = Guid.NewGuid(),
                    Service_Name = addServiceViewModel.ServiceName,
                    Create_Date = DateTime.Now
                };

                _dbContext.Services.Add(service);

                return await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public async Task<int> AddCompanyService(AddCompanyServiceViewModel addCompanyServiceViewModel)
        {
            try
            {

                CompanyService companyService = new CompanyService()
                {
                    Id = Guid.NewGuid(),
                    Service_Id = addCompanyServiceViewModel.ServiceId,
                    Company_Id = addCompanyServiceViewModel.CompanyId,
                    Price = addCompanyServiceViewModel.Price,
                    Create_Date = DateTime.Now
                };

                _dbContext.CompanyServices.Add(companyService);

                return await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<ServiceViewModel>> GetServices()
        {
            try
            {
                List<Service> services = await _dbContext.Services.Where(q => !q.Is_Deleted).ToListAsync();

                List<ServiceViewModel> companiesViewModel = services.Select(q => new ServiceViewModel
                {
                    ServiceId = q.Id,
                    ServiceName = q.Service_Name
                }).ToList();

                return companiesViewModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<CompanyServiceViewModel>> GetCompanyServices()
        {
            try
            {
                List<CompanyService> companyServices = await _dbContext.CompanyServices.Include(q => q.Company).Include(q => q.Service).Where(q => !q.Is_Deleted).ToListAsync();

                List<CompanyServiceViewModel> companiesViewModel = companyServices.Select(q => new CompanyServiceViewModel
                {
                    CompanyServiceId = q.Id,
                    ServiceName = q.Service.Service_Name,
                    ServicePrice = q.Price,
                    CompanyName = q.Company.Company_Name
                }).OrderBy(q => q.CompanyName).ThenBy(q => q.ServiceName).ToList();

                return companiesViewModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion


    }
}
