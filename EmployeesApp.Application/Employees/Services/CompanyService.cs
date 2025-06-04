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

    public async Task AddAsync(Company company)
    {
        company.CompanyName = ToInitalCapital(company.CompanyName);
        company.City = company.City.ToLower();

        unitOfWork.Companies.Add(company);
        await unitOfWork.PersistAllAsync();
    }

    string ToInitalCapital(string s) => $"{s[..1].ToUpper()}{s[1..]}";


    public async Task<Company[]> GetAllAsync()
    {
        var employees = await unitOfWork.Companies.GetAllAsync();
        return employees.OrderBy(e => e.City).ToArray();
    }

    public async Task<Company?> GetByIdAsync(int id)
    {
        Company? company = await unitOfWork.Companies.GetByIdAsync(id);

        return company is null ?
            throw new ArgumentException($"Invalid parameter value: {id}", nameof(id)) :
            company;
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.DeleteAllAsync(id);
    }
}
