using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Core
{
    public interface IRecipeService
    {
        Task<IList<CategoryModel>> GetCategories();
        Task<IList<IngredientModel>> GetIngredients();
        Task<IList<RecipeModel>> GetRecipes(string recipeName);
        Task<RecipeModel> AddRecipe(RecipeModel recipeModel);
    }
}
