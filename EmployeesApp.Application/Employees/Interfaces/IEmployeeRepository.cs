using EmployeesApp.Domain.Entities;

namespace EmployeesApp.Application.Employees.Interfaces
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        Task<Employee[]> GetAllAsync();
        Task<Employee?> GetByIdAsync(int id);
        void DeleteById(Employee employee);
    }
}