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
        Task<ResultOutputData<IList<RecipeModel>>> GetRecipes(string recipeName, int startRecordNumber, int pageSize, string orderBy);
        Task<RecipeModel> AddRecipe(RecipeModel recipeModel);
    }
}
