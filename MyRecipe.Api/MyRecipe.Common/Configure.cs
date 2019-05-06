using Microsoft.Extensions.DependencyInjection;

namespace MyRecipe.Common
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPrincipalUser, PrincipalUser>();
        }
    }
}
