using EmployeeApi.Domain.Models;

namespace EmployeeApi.Domain.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}
