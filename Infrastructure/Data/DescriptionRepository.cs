using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class DescriptionRepository : IDescriptionRepository
{
    private readonly DataContext _context;
    public DescriptionRepository(DataContext context)
    {
        _context = context;
    }
    public void Add(Description description)
    {
        _context.Descriptions.Add(description);
    }
    public async Task<IReadOnlyList<Description>> GetDescriptionsByCityIdAsync(int id, bool noTracking)
    {
        var descriptions = _context.Descriptions.Where(x => x.CityId == id);
        if (noTracking) descriptions = descriptions.AsNoTracking();
        return await descriptions.ToListAsync();
    }
    public void Update(Description description)
    {
        _context.Entry(description).State = EntityState.Modified;
    }
}