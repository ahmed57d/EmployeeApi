using EmployeeApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>().ToTable("Companies");
            builder.Entity<Company>().HasKey(p => p.Id);
            builder.Entity<Company>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Company>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<Company>().HasMany(p => p.Employees).WithOne(p => p.Company).HasForeignKey(p => p.CompanyId);
            
            builder.Entity<Company>().HasData
            (
                new Company { Id = 100, Name = "MyDixi" }, // Id set manually due to in-memory provider
                new Company { Id = 101, Name = "ITShares" }
            );

            builder.Entity<Employee>().ToTable("Employees");
            builder.Entity<Employee>().HasKey(p => p.Id);
            builder.Entity<Employee>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Employee>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            
        }
    }
}
