using Core.Entities;
using Core.Entities.Enum;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
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

        public async Task<IReadOnlyList<Route>> GetRoutesByCityIdAsync(int id, Visible type = Visible.None)
        {
            return await _context.Routes
                .Where(x => x.CityId == id && type == Visible.None ? true : x.Visible == type)
                .ToListAsync();
        }

        public void Update(Route route)
        {
            _context.Entry(route).State = EntityState.Modified;
        }
    }
}