using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application.Employees.Services;
public class CompanyService(IUnitOfWork unitOfWork) : ICompanyService
{
    public Task AddAsync(Company company)
    {
        throw new NotImplementedException();
    }

    public bool CheckIsVIP(Company company)
    {
        throw new NotImplementedException();
    }

    public Task<Company[]> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Company?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
