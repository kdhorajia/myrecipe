using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public interface IRecipeRepository : ITrackingRepository<Recipe>
    {
        Recipe AddRecipe(RecipeModel recipeModel);

        Task<List<Recipe>> GetRecipes(string recipeName);
    }
}
