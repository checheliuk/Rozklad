using Core.Entities;
using Core.Entities.Enum;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class RouteRepository : IRouteRepository
{
    private readonly DataContext _context;
    public RouteRepository(DataContext context)
    {
        _context = context;
    }
    public void Add(Route route)
    {
        _context.Routes.Add(route);
    }
    public async Task<IReadOnlyList<Route>> GetRoutesByCityIdAsync(int id, Visible type, bool noTracking)
    {
        var routes = _context.Routes.AsQueryable();
        if (!(type == Visible.None)) routes = routes.Where(t => t.Visible == type);
        if (noTracking) routes = routes.AsNoTracking();
        return await routes.ToListAsync();
    }
    public void Update(Route route)
    {
        _context.Entry(route).State = EntityState.Modified;
    }
}