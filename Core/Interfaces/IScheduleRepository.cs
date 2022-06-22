using Core.Entities;
using Core.Entities.Enum;

namespace Core.Interfaces;
public interface IScheduleRepository
{
    void Add(Schedule schedule);
    void Update(Schedule schedule);
    void Delete(Schedule schedule);
    Task<IReadOnlyList<Schedule>> GetSchedulesByRouteIdAsync(int id, Period period = Period.None, Day day = Day.None);
}