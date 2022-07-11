using Microsoft.EntityFrameworkCore;
using PhysicalTherapyClinic.Domain;
using PhysicalTherapyClinic.Domain.Entities;
using PhysicalTherapyClinic.Models;
using PhysicalTherapyClinic.Models.Enums;
using PhysicalTherapyClinic.Services.Interfaces;

namespace PhysicalTherapyClinic.Services
{
    public class ClientServicesService : IClientServicesService
    {
        private readonly PTDBContext _dbContext;
        public ClientServicesService(PTDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddClientService(AddClinetServiceViewModel clinetServiceViewModel)
        {
            try
            {
                CompanyService companyService = await _dbContext.CompanyServices.FirstOrDefaultAsync(q => q.Id == clinetServiceViewModel.CompanyServiceId && !q.Is_Deleted);

                Client client = new Client()
                {
                    Id = Guid.NewGuid(),
                    Client_Name = clinetServiceViewModel.ClientName,
                    Phone = clinetServiceViewModel.Phone,
                    Address = clinetServiceViewModel.Address,
                    Create_Date = DateTime.Now
                };

                _dbContext.Clients.Add(client);

                ClientService clientService = new ClientService()
                {
                    Id = Guid.NewGuid(),
                    Client_Id = client.Id,
                    Company_Service_Id = clinetServiceViewModel.CompanyServiceId,
                    Service_Price = companyService.Price,
                    Payment_Method = clinetServiceViewModel.PaymentMethodType,
                    Endurance_Ratio = clinetServiceViewModel.EnduranceRatio,
                    Create_Date = DateTime.Now
                };

                _dbContext.ClientServices.Add(clientService);

                int result = await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<ClientServiceViewModel>> GetClientServices()
        {
            try
            {
                List<ClientService> clientServices = await _dbContext.ClientServices.Include(q => q.CompanyService).ThenInclude(q => q.Service).Include(q => q.CompanyService).ThenInclude(q => q.Company).Include(q => q.Client).Where(q => !q.Is_Deleted).ToListAsync();

                List<ClientServiceViewModel> clientServicesViewModel = clientServices.Select(q => new ClientServiceViewModel
                {
                    Id = q.Id,
                    ClientName = q.Client.Client_Name,
                    Phone = q.Client.Phone,
                    Address = q.Client.Address,
                    PaymentMethod = q.Payment_Method == PaymentMethodTypeEnum.Cash.ToString() ? "نقدي" :"آجل",
                    CompanyName = q.CompanyService.Company.Company_Name,
                    ServiceName = q.CompanyService.Service.Service_Name,
                    ServicePrice = q.Service_Price,
                    EnduranceRatio = q.Endurance_Ratio

                }).ToList();

                return clientServicesViewModel;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
