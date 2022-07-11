using PhysicalTherapyClinic.Models;

namespace PhysicalTherapyClinic.Services.Interfaces
{
    public interface IClientServicesService
    {
        Task AddClientService(AddClinetServiceViewModel addServiceViewModel);
        Task<List<ClientServiceViewModel>> GetClientServices();
    }
}
