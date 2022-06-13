using Core.Entities;
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

        public void Update(Route route)
        {
            _context.Entry(route).State = EntityState.Modified;
        }
    }
}