﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace EmployeesApp.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
