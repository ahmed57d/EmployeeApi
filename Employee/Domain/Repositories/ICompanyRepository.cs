using EmployeeApi.Domain.Models;

namespace EmployeeApi.Domain.Repositories
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}
