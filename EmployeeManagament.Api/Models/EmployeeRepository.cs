using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagament.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await appDbContext.Employees.
                FirstOrDefaultAsync(i => i.EmployeeId == employeeId);
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e=>e.EmployeeId==employee.EmployeeId);

            if(result != null)
            {
                result.FirstName=employee.FirstName;
                result.LastName=employee.LastName;
                result.Email=employee.Email;
                result.Gender=employee.Gender;
                result.DepartmentId=employee.DepartmentId;

                await appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
