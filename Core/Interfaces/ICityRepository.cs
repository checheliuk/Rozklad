using Core.Entities;

namespace Core.Interfaces
{
    public interface ICityRepository
    {
        void Add(City city);
        void Update(City city);
        Task<IReadOnlyList<City>> GetCitesAsync();
        Task<City> GetCityByIdAsync(int id);
        Task<City> GetCityByNameAsync(string name);
    }
}