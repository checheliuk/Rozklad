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
    public async Task<IReadOnlyList<City>> GetCitesAsync(Visible type, bool noTracking)
    {
        var cites = _context.Cites.AsQueryable();
        if (!(type == Visible.None)) cites = cites.Where(t => t.Visible == type);
        if (noTracking) cites = cites.AsNoTracking();
        return await cites.ToListAsync();
    }
    public Task<City> GetCityByIdAsync(int id, Visible type, bool noTracking)
    {
        throw new NotImplementedException();
    }
    public async Task<City> GetCityByUrlAsync(string url, Visible type, bool noTracking)
    {
        var city = _context.Cites.AsQueryable();
        if (!(type == Visible.None)) city = city.Where(t => t.Visible == type);
        if (noTracking) city = city.AsNoTracking();
        return await city.FirstOrDefaultAsync(x => x.Url == url);
    }
    public void Update(City city)
    {
        _context.Entry(city).State = EntityState.Modified;
    }
}