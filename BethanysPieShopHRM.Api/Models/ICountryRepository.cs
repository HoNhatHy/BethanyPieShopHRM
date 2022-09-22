using BethanysPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Api.Models
{
    public interface ICountryRepository
    {
        public IEnumerable<Country> GetAllCountries();
        public Country GetCountryById(int countryId);
    }
}
