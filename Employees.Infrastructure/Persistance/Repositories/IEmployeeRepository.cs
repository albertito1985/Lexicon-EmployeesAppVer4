using EmployeesApp.Domain;

namespace EmployeesApp.Infrastructure.Persistance.Repositories
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        bool CheckIsVIP(Employee employee);
        Employee[] GetAll();
        Employee GetById(int id);
    }
}