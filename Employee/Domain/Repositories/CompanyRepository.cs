using EmployeeApi.Domain.Models;
using EmployeeApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Domain.Repositories
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await _context.Companies.ToListAsync();
        }
    }
}
