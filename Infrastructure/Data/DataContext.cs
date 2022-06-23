using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class DataContext : IdentityDbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<City> Cites { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<Station> Stations { get; set; }
    public DbSet<Schedule> Schedules { get; set; }
    public DbSet<Waybill> Waybills { get; set; }
    public DbSet<Interval> Intervals { get; set; }
}