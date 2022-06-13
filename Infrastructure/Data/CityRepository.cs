using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;
        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(City city)
        {
            _context.Cites.Add(city);
        }

        public async Task<IReadOnlyList<City>> GetCitesAsync()
        {
            return await _context.Cites.ToListAsync();
        }

        public Task<City> GetCityByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetCityByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public void Update(City city)
        {
            _context.Entry(city).State = EntityState.Modified;
        }
    }
}