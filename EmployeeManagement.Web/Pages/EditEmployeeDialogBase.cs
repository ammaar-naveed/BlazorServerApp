using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System.Runtime.InteropServices;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeDialogBase : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues =true) ]
        public IReadOnlyDictionary<string, dynamic>? Attributes { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public Employee Employees { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            
            int id = Attributes["userId"];
            Employees = await EmployeeService.GetEmployee(id);
        }

        public Gender selectedGender;

    }
}
