using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Infrastructure.Persistance;
public class UnitOfWork(ApplicationContext context, ICompanyRepository companyRepository, IEmployeeRepository employeeRepository) : IUnitOfWork
{
    public ICompanyRepository Companies => companyRepository;
    public IEmployeeRepository Employees => employeeRepository;

    public async Task DeleteAllAsync(int id)
    {
        Company? company = await Companies.GetByIdAsync(id);

        foreach (var em in company.Employees)
        {
            context.Employees.Remove(em);
        }

        // ta bort company
        context.Companies.Remove(company);

        // persist all
        await PersistAllAsync();
    }

    public async Task PersistAllAsync() => await context.SaveChangesAsync();

}
