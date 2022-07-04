using Core.Entities;
using Core.Entities.Enum;

namespace Core.Interfaces;
public interface ICityRepository
{
    void Add(City city);
    void Update(City city);
    Task<IReadOnlyList<City>> GetCitesAsync(Visible type = Visible.None, bool noTracking = true);
    Task<City> GetCityByIdAsync(int id, Visible type = Visible.None, bool noTracking = true);
    Task<City> GetCityByUrlAsync(string url, Visible type = Visible.None, bool noTracking = true);
}