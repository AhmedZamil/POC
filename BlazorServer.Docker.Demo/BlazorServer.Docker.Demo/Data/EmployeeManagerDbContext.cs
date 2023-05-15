using BlazorServer.Docker.Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Docker.Demo.Data
{
    public class EmployeeManagerDbContext : DbContext
    {
        public EmployeeManagerDbContext(DbContextOptions<EmployeeManagerDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Department> Departments => Set<Department>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Development" },
                new Department { Id = 2, Name = "Dev Ops" },
                new Department { Id = 3, Name = "Q&A" },
                new Department { Id = 4, Name = "Human Resources" },
                new Department { Id = 5, Name = "Marketing" });

            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, FirstName = "Ahmed", LastName = "Zamil", DepartmentId = 2 },
                new Employee { Id = 2, FirstName = "Marielina", LastName = "Fardous", DepartmentId = 5, IsDeveloper = true },
                new Employee { Id = 3, FirstName = "Rihan", LastName = "Munabih", DepartmentId = 5, IsDeveloper = true },
                new Employee { Id = 4, FirstName = "Sara", LastName = "Ahmed", DepartmentId = 1 },
                new Employee { Id = 5, FirstName = "Rain", LastName = "Samara", DepartmentId = 4 },
                new Employee { Id = 6, FirstName = "Moni", LastName = "Xaman", DepartmentId = 3, IsDeveloper = true },
                new Employee { Id = 7, FirstName = "Sophie", LastName = "Lee", DepartmentId = 5 },
                new Employee { Id = 8, FirstName = "Julien", LastName = "Ahmed", DepartmentId = 2 },
                new Employee { Id = 9, FirstName = "Yoni", LastName = "Ashrov", DepartmentId = 4 },
                new Employee { Id = 10, FirstName = "Scott", LastName = "Barron", DepartmentId = 1, IsDeveloper = true });
        }
    }
}
