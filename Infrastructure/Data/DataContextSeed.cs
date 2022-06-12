using System.Text.Json;
using Core.Entities;

namespace Infrastructure.Data
{
    public class DataContextSeed
    {
        public static async Task SeedAsync(DataContext context, string rootPath)
        {
            var path = rootPath.Replace("API", "Infrastructure");
            if(!context.Cites.Any())
            {
                var citesData = File.ReadAllText(path + @"Data/SeedData/cites.json");
                var cites = JsonSerializer.Deserialize<List<City>>(citesData);

                foreach (var item in cites)
                {
                    context.Cites.Add(item);
                }

                await context.SaveChangesAsync();
            }

            if(!context.Routes.Any())
            {
                var routesData = File.ReadAllText(path + @"Data/SeedData/routes.json");
                var routes = JsonSerializer.Deserialize<List<Route>>(routesData);

                foreach (var item in routes)
                {
                    context.Routes.Add(item);
                }

                await context.SaveChangesAsync();
            }

             if(!context.Stations.Any())
            {
                var stationsData = File.ReadAllText(path + @"Data/SeedData/stations.json");
                var stations = JsonSerializer.Deserialize<List<Station>>(stationsData);

                foreach (var item in stations)
                {
                    context.Stations.Add(item);
                }

                await context.SaveChangesAsync();
            }
        }
    }
}