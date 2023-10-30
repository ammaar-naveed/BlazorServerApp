using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagament.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            //inserting/seeding data in departments table
            /*modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "Accounts" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });*/

            //seeding employees table.
            /*modelBuilder.Entity<Employee>().HasData(new Employee
            { EmployeeId = 1,
              FirstName ="Ammaar",
              LastName = "Naveed",
              Email = "test@gmail.com",
              Gender = Gender.Male,
              DepartmentId = 1              
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Ahmed",
                LastName = "Ali",
                Email = "test@gmail.com",
                Gender = Gender.Male,
                DepartmentId = 2
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Ali",
                Email = "test@gmail.com",
                Gender = Gender.Female,
                DepartmentId = 3    
            });*/
        }
    }
}
