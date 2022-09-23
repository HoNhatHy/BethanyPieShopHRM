using BethanyPieShopHRM.Services;
using BethanyPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShopHRM.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter]
		public string EmployeeId { get; set; } = null!;
        public Employee? Employee { get; set; } = new Employee();

		[Inject]
		public IEmployeeDataService EmployeeDataService { get; set; } = null!;

		protected override async Task OnInitializedAsync()
		{
			Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
		}
	}
}
