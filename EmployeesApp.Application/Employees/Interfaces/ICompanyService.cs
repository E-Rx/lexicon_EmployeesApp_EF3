﻿using EmployeesApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Application.Employees.Interfaces;
public interface ICompanyService
{
    Task AddAsync(Company company);

    Task<Company[]> GetAllAsync();

    Task<Company?> GetByIdAsync(int id);

    Task DeleteByIdAsync(int id);

}
