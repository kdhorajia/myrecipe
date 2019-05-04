using MyRecipe.Models;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.Repositories
{
    public interface IRecipeRepository : ITrackingRepository<Recipe>
    {
        Recipe AddRecipe(RecipeModel recipeModel);
    }
}
