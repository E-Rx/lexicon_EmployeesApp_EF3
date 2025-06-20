﻿using EmployeesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application.Employees.Interfaces;
public interface IUnitOfWork
{
    ICompanyRepository Companies { get; }
    IEmployeeRepository Employees { get; }
    Task PersistAllAsync();
    Task DeleteAllAsync(int id);
}
