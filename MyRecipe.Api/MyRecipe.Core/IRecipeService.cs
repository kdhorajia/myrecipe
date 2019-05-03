using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Core
{
    public interface IRecipeService
    {
        Task<IList<Category>> GetCategories();
        Task<RecipeModel> CreateRecipe();
    }
}
