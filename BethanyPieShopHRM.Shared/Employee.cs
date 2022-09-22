using System;

namespace BethanysPieShopHRM.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public string Email { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string City { get; set; } = null!;
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool Smoker { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; } = null!;

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
