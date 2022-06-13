using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly DataContext _context;
        public ScheduleRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
        }

        public void Delete(Schedule schedule)
        {
             _context.Schedules.Remove(schedule);
        }

        public void Update(Schedule schedule)
        {
            _context.Entry(schedule).State = EntityState.Modified;
        }
    }
}