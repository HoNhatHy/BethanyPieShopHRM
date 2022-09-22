﻿using BethanysPieShopHRM.Shared;
using System.Text.Json;

namespace BethanyPieShopHRM.Services
{
    public class JobCategoryDataService : IJobCategoryDataService
    {
        private readonly HttpClient _httpClient;

        public JobCategoryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<JobCategory>>
                (await _httpClient.GetStreamAsync("api/jobcategory"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<JobCategory>();
        }

        public async Task<JobCategory> GetJobCategoryById(int jobCategoryId)
        {
            return await JsonSerializer.DeserializeAsync<JobCategory>
                (await _httpClient.GetStreamAsync($"api/jobcategory/{jobCategoryId}"), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new JobCategory();
        }
    }
}
