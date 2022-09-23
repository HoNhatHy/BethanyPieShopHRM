using BethanyPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanyPieShopHRM.Api.Models
{
    public interface IJobCategoryRepository
    {
        IEnumerable<JobCategory> GetAllJobCategories();
        JobCategory GetJobCategoryById(int jobCategoryId);
    }
}
