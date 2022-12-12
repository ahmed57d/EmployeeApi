using EmployeeApi.Domain.Models;
using EmployeeApi.Domain.Repositories;
using System.Runtime.CompilerServices;

namespace EmployeeApi.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _companyRepository.ListAsync();
        }
    }
}
