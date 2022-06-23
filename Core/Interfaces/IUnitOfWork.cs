namespace Core.Interfaces;
public interface IUnitOfWork
{
    ICityRepository CityRepository {get; }
    IWaybillRepository WaybillRepository {get; }
    IRouteRepository RouteRepository {get; }
    IScheduleRepository ScheduleRepository {get; }
    IStationRepository StationRepository {get; }
    Task<bool> Complete();
    bool HasChanges();
}