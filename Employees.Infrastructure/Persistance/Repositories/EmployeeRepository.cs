﻿using EmployeesApp.Application;
using EmployeesApp.Domain;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly List<Employee> employees =
        [
            new Employee()
            {
                Id = 562,
                Name = "Anders Hejlsberg",
                Email = "Anders.Hejlsberg@outlook.com",
            },
            new Employee()
            {
                Id = 62,
                Name = "Kathleen Dollard",
                Email = "k.d@outlook.com",
            },
            new Employee()
            {
                Id = 15662,
                Name = "Mads Torgersen",
                Email = "Admin.Torgersen@outlook.com",
            },
            new Employee()
            {
                Id = 52,
                Name = "Scott Hanselman",
                Email = "s.h@outlook.com",
            },
            new Employee()
            {
                Id = 563,
                Name = "Jon Skeet",
                Email = "j.s@outlook.com",
            },
        ];

        public void Add(Employee employee)
        {
            employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public Employee[] GetAll() => [.. employees];

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }
}