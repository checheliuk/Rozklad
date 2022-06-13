using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class IntervalRepository : IIntervalRepository
    {
        private readonly DataContext _context;
        public IntervalRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Interval interval)
        {
            _context.Intervals.Add(interval);
        }

        public void Delete(Interval interval)
        {
            _context.Intervals.Remove(interval);
        }

        public void Update(Interval interval)
        {
            _context.Entry(interval).State = EntityState.Modified;
        }
    }
}