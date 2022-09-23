using BethanyPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanyPieShopHRM.Api.Models
{
    public interface ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries();
        public Country GetCountryById(int countryId);
    }
}
