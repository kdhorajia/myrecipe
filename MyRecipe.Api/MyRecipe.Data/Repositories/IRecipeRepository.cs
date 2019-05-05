using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public interface IRecipeRepository : ITrackingRepository<Recipe>
    {
        Recipe AddRecipe(Recipe recipeModel);

        Task<Tuple<IList<Recipe>, int>> GetRecipes(string recipeName, int startRecordNumber, int pageSize, string orderBy);
    }
}
