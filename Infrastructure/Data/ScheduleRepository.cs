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
    public async Task<IReadOnlyList<Schedule>> GetSchedulesByRouteIdAsync(int id, Period period, Day day, bool noTracking)
    {
        var schedules = _context.Schedules.Where(x => x.RouteId == id);
        if (!(period ==  Period.None)) schedules = schedules.Where(p => p.Period == period);
        if (!(day == Day.None)) schedules = schedules.Where(d => d.Day == day);
        if (noTracking) schedules = schedules.AsNoTracking();
        return await schedules.ToListAsync();
    }
    public void Update(Schedule schedule)
    {
        _context.Entry(schedule).State = EntityState.Modified;
    }
}