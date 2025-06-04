using EmployeesApp.Application.Employees.Interfaces;
using EmployeesApp.Web.Views.Companies;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;
public class CompaniesController(ICompanyService service) : Controller
{
    [HttpGet("companies")]
    public async Task<IActionResult> CompanyIndexAsync()
    {
        var model = await service.GetAllAsync();

        var viewModel = new CompanyIndexVM()
        {
            CompaniesVMs = [.. model
            .Select(e => new CompanyIndexVM.CompanyVM()
            {
                Id = e.Id,
                CompanyName = e.CompanyName != null ? e.CompanyName : "N/A",
            })]
        };

        return View(viewModel);
    }
}
