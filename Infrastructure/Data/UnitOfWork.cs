using Core.Interfaces;

namespace Infrastructure.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;
    public UnitOfWork(DataContext context)
    {
        _context = context;
    }
    public ICityRepository CityRepository => new CityRepository(_context);
    public IIntervalRepository IntervalRepository => new IntervalRepository(_context);
    public IRouteRepository RouteRepository => new RouteRepository(_context);
    public IScheduleRepository ScheduleRepository => new ScheduleRepository(_context);
    public IStationRepository StationRepository => new StationRepository(_context);
    public async Task<bool> Complete()
    {
        return  await _context.SaveChangesAsync() > 0;
    }

    public bool HasChanges()
    {
        return _context.ChangeTracker.HasChanges();
    }
}