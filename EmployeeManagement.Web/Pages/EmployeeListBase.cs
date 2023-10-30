using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        protected Dictionary<int, string> EmployeeEmails { get; set; } = new Dictionary<int, string>();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }   
        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<Department> Department { get; set; }

        protected override async Task OnInitializedAsync()
        {
           Employees = (await EmployeeService.GetEmployees()).ToList();

            foreach (var employee in Employees)
            {
                EmployeeEmails[employee.EmployeeId] = employee.Email;
            }
        }
    }
}
