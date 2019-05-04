using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using MyRecipe.Core.Profiles;
using MyRecipe.Core.Services;

namespace MyRecipe.Core
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRecipeService, RecipeService>();
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new RecipeProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
