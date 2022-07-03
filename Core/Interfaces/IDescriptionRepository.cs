using Core.Entities;

namespace Core.Interfaces;
public interface IDescriptionRepository
{
    void Add(Description description);
    void Update(Description description);
    Task<IReadOnlyList<Description>> GetDescriptionsByCityIdAsync(int id);
}