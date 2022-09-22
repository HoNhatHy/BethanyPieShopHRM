using BethanyPieShopHRM.Services;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.Pages
{
    public partial class EmployeeOverview
    {
		public IEnumerable<Employee> Employees { get; set; } = null!;

		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; } = null!;
		protected async override Task OnInitializedAsync()
		{
			Employees = await EmployeeDataService.GetAllEmployees();
		}
	}
}
