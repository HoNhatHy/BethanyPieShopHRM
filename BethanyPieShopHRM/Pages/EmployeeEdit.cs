using BethanyPieShopHRM.Services;
using Microsoft.AspNetCore.Components;
using BethanyPieShopHRM.Shared;

namespace BethanyPieShopHRM.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; } = null!;
        [Inject]
        public ICountryDataService CountryDataService { get; set; } = null!;
        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; } = null!;
        [Parameter]
        public string EmployeeId { get; set; } = null!;

        public Employee Employee { get; set; } = new Employee();
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        protected string CountryId = string.Empty;
        protected string JobCategoryId = string.Empty;

        protected override async Task OnInitializedAsync()
        {

            Countries = (await CountryDataService.GetAllCountries()).ToList<Country>();
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList<JobCategory>();

            CountryId = Employee.CountryId.ToString();
            JobCategoryId = Employee.JobCategoryId.ToString();
        }
    }
}
