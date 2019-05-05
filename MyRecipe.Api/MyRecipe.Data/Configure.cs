using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyRecipe.Data.Repositories;
using MyRecipe.Models.Entities;

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
            services
               .AddScoped<IIngredientRepository, IngredientRepository>();
            services
               .AddScoped<IRecipeRepository, RecipeRepository>();
        }
    }
}
