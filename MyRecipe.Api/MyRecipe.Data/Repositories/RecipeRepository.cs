using Microsoft.EntityFrameworkCore;
using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public class RecipeRepository : TrackingRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(MyRecipeDbContext context) : base(context) { }

        public Recipe AddRecipe(RecipeModel recipeModel)
        {
            Recipe recipe = new Recipe()
            {
                Name = recipeModel.Name,
                Description = recipeModel.Description,
                Instruction = recipeModel.Instruction,
                CustomerId = recipeModel.CustomerId,
                CategoryId = recipeModel.CategoryId,
            };

            foreach (RecipeIngredientModel recipeIngredient in recipeModel.RecipeIngredients)
            {
                recipe.RecipeIngredient.Add(new RecipeIngredient()
                {
                    IngredientId = recipeIngredient.IngredientId,
                    Unit = recipeIngredient.Unit,
                    Preparation = recipeIngredient.Preparation,
                    Quantity = recipeIngredient.Quantity
                });
            }

            _context.Add(recipe);

            return recipe;
        }

        public Task<List<Recipe>> GetRecipes(string recipeName)
        {
            return _context.Set<Recipe>().Where(o => !o.Deleted && o.Name.ToLowerInvariant().Contains(recipeName.ToLowerInvariant()))
                .Include(o => o.RecipeIngredient)
                .Include("RecipeIngredient.Ingredient")
                .ToListAsync();
        }
    }
}
