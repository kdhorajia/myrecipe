using MyRecipe.Models;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.Repositories
{
    public interface IRecipeRepository
    {
        Recipe CreateRecipe(RecipeModel recipeModel);
    }
}
