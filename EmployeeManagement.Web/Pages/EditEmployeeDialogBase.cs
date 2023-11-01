using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeDialogBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employees { get; set; } = new Employee();

        [Parameter]
        public string employeeId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployee(1);
        }

        public Gender selectedGender;

    }
}
