using Core.Entities;

namespace Core.Interfaces
{
    public interface IStationRepository
    {
        void Add(Station station);
        void Update(Station station);
    }
}