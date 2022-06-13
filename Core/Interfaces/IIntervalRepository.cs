using Core.Entities;

namespace Core.Interfaces
{
    public interface IIntervalRepository
    {
        void Add(Interval interval);
        void Update(Interval interval);
        void Delete(Interval interval);
    }
}