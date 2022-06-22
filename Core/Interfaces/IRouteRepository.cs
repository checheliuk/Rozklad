using Core.Entities;
using Core.Entities.Enum;

namespace Core.Interfaces;
public interface IRouteRepository
{
    void Add(Route route);
    void Update(Route route);
    Task<IReadOnlyList<Route>> GetRoutesByCityIdAsync(int id, Visible type = Visible.None);
}