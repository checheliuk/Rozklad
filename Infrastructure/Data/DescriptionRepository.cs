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

    public async Task<IReadOnlyList<Description>> GetDescriptionsByCityIdAsync(int id)
    {
        return await _context.Descriptions.Where(x => x.CityId == id).ToListAsync();
    }

    public void Update(Description description)
    {
        _context.Entry(description).State = EntityState.Modified;
    }
}