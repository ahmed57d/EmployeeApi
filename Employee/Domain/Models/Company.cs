namespace EmployeeApi.Domain.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}
