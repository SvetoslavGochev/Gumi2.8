
namespace МоитеГуми.Infrastructure
{
    using Microsoft.AspNetCore.Builder;
    using System.Linq;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using МоитеГуми.Data;
    using МоитеГуми.Data.Models;
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PreparateDatabase(this IApplicationBuilder app)
        {
            using var scopesServices = app.ApplicationServices.CreateScope();

            var data = scopesServices.ServiceProvider.GetService<ApplicationDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(ApplicationDbContext data)
        {

            if (data.Categories.Any())
            {
                return;
            }
            data.Categories.AddRange(new[]
            {
                new Category { Name = "Нови"},
                new Category { Name = "Втора Употреба"},

            });
            data.SaveChanges();
        }
    }
}
