using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyRecipe.Core.Mapper;
using MyRecipe.Core.Services;

namespace MyRecipe.Core
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRecipeService, RecipeService>();
            services.AddAutoMapper(new System.Reflection.Assembly[] { typeof(RecipeMapper).Assembly });
        }
    }
}
