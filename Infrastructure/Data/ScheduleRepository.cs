using Core.Entities;
using Core.Entities.Enum;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

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

    public async Task<IReadOnlyList<Schedule>> GetSchedulesByRouteIdAsync(int id, Period period = Period.None, Day day = Day.None)
    {
        return await _context.Schedules
            .Where(x => x.RouteId == id 
                && period == Period.None ? true : x.Period == period
                && day == Day.None ? true : x.Day == day)
            .ToListAsync();
    }

    public void Update(Schedule schedule)
    {
        _context.Entry(schedule).State = EntityState.Modified;
    }
}