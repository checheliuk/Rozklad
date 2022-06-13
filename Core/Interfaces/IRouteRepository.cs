using Core.Entities;

namespace Core.Interfaces
{
    public interface IRouteRepository
    {
        void Add(Route route);
        void Update(Route route);
    }
}