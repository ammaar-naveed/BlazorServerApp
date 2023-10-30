using EmployeeManagement.Models;

namespace EmployeeManagament.Api.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int DepartmentId);
    }
}
