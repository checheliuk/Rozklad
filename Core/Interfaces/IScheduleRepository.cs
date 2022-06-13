using Core.Entities;

namespace Core.Interfaces
{
    public interface IScheduleRepository
    {
        void Add(Schedule schedule);
        void Update(Schedule schedule);
        void Delete(Schedule schedule);
    }
}