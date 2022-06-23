using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data;
public class DataContextSeed
{
    public static async Task SeedAsync(DataContext context, string rootPath)
    {
        var path = rootPath.Replace("API", "Infrastructure");
        if (!context.Cites.Any())
        {
            var citesData = File.ReadAllText(path + @"Data/SeedData/cites.json");
            var cites = JsonSerializer.Deserialize<List<City>>(citesData);

            foreach (var item in cites)
            {
                context.Cites.Add(item);
            }

            await context.SaveChangesAsync();
        }

        if (!context.Routes.Any())
        {
            var routesData = File.ReadAllText(path + @"Data/SeedData/routes.json");
            var routes = JsonSerializer.Deserialize<List<Route>>(routesData);

            foreach (var item in routes)
            {
                context.Routes.Add(item);
            }

            await context.SaveChangesAsync();
        }

        if (!context.Stations.Any())
        {
            var stationsData = File.ReadAllText(path + @"Data/SeedData/stations.json");
            var stations = JsonSerializer.Deserialize<List<Station>>(stationsData);

            foreach (var item in stations)
            {
                context.Stations.Add(item);
            }

            await context.SaveChangesAsync();
        }

        if (!context.Schedules.Any())
        {
            var schedulesData = File.ReadAllText(path + @"Data/SeedData/schedules.json");
            var schedules = JsonSerializer.Deserialize<List<Schedule>>(schedulesData);

            foreach (var item in schedules)
            {
                context.Schedules.Add(item);
            }

            await context.SaveChangesAsync();
        }

        if (!context.Waybills.Any())
        {
            var waybillsData = File.ReadAllText(path + @"Data/SeedData/waybills.json");
            var waybills = JsonSerializer.Deserialize<List<Waybill>>(waybillsData);

            foreach (var item in waybills)
            {
                context.Waybills.Add(item);
            }

            await context.SaveChangesAsync();
        }

        if (!context.Intervals.Any())
        {
            var intervalsData = File.ReadAllText(path + @"Data/SeedData/intervals.json");
            var intervals = JsonSerializer.Deserialize<List<Interval>>(intervalsData);

            foreach (var item in intervals)
            {
                context.Intervals.Add(item);
            }

            await context.SaveChangesAsync();
        }
    }
}