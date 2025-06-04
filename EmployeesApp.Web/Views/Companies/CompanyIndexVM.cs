namespace EmployeesApp.Web.Views.Companies;

public class CompanyIndexVM
{
    public CompanyVM[] CompaniesVMs { get; set; } = null!;

    public class CompanyVM
    {
        public required int Id { get; set; }
        public string? CompanyName { get; set; }
    }
}
