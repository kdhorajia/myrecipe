using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyRecipe.Models;

namespace MyRecipe.Data
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services, string connectionString)
        {
            //Context lifetime defaults to "scoped"
            services
                 .AddDbContext<MyRecipeDbContext>(options => options.UseSqlServer(connectionString));

            services
               .AddScoped<IRepository<Category>, AtomicRepository<Category>>();
        }
    }
}
