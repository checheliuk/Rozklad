using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Helpers
{
    public static class Scope
    {
        public static async Task MigrateDatabase(IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<DataContext>();
            await context.Database.MigrateAsync();
        }
    }
}