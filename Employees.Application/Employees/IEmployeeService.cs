using EmployeesApp.Domain;

namespace Employees.Application.Employees
{
    public interface IEmployeeService
    {
        void Add(Employee employee);

        Employee[] GetAll();

        Employee GetById(int id);

        public bool CheckIsVIP(Employee employee);
    }
}
