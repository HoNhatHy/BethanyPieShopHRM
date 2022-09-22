using BethanysPieShopHRM.Shared;

namespace BethanyPieShopHRM.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
