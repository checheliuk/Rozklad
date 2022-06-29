using Core.Entities;

namespace Core.Interfaces
{
    public interface IIntervalRepository
    {
        void Add(Interval interval);
        void Update(Interval interval);
        Task<IReadOnlyList<Interval>> GetIntervalsByWaybillIdAsync(int id);
    }
}