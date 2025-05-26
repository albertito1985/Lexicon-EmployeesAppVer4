using EmployeesApp.Domain;


namespace Employees.Application.Employees
{
    public class EmployeeService(IEmployeeRepository EmployeeRepository) : IEmployeeService
    {
       public void Add(Employee employee)
        {
            //employee.Id = employees.Count < 0 ? 1 : employees.Max(e => e.Id) + 1;
            //employees.Add(employee);


        }


        // Collection expression syntax, introduced in C# 12.
        public Employee[] GetAll() => [.. employees.OrderBy(e => e.Name)];

        ////Classic C# syntax for GetAll()
        //public Employee[] GetAll()
        //{
        //    return employees
        //        .OrderBy(e => e.Name)
        //        .ToArray();
        //}

        public Employee GetById(int id) => employees
            .Single(e => e.Id == id);

        public bool CheckIsVIP(Employee employee) =>
            employee.Email.StartsWith("ADMIN", StringComparison.CurrentCultureIgnoreCase);
    }
}