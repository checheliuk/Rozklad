using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StationRepository : IStationRepository
    {
        private readonly DataContext _context;
        public StationRepository(DataContext context)
        {
            _context = context;
        }
        
        public void Add(Station station)
        {
             _context.Stations.Add(station);
        }
        
        public void Update(Station station)
        {
            _context.Entry(station).State = EntityState.Modified;
        }
    }
}