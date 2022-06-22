using Core.Entities;
using Core.Entities.Enum;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
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

    public async Task<IReadOnlyList<City>> GetCitesAsync(Visible type)
    {
        return await _context.Cites
            .Where(t => type == Visible.None ? true : t.Visible == type)
            .ToListAsync();
    }

    public Task<City> GetCityByIdAsync(int id, Visible type)
    {
        throw new NotImplementedException();
    }

    public async Task<City> GetCityByUrlAsync(string url, Visible type)
    {
        return await _context.Cites
            .Where(x => x.Url == url && type == Visible.None ? true : x.Visible == type)
            .FirstOrDefaultAsync();
    }

    public void Update(City city)
    {
        _context.Entry(city).State = EntityState.Modified;
    }
}