using Core.Entities;
using Core.Entities.Enum;

namespace Core.Interfaces
{
    public interface IStationRepository
    {
        void Add(Station station);
        void Update(Station station);
        Task<IReadOnlyList<Station>> GetStationsByCityIdAsync(int id);
    }
}