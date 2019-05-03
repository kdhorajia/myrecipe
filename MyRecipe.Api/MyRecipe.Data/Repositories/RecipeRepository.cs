using MyRecipe.Models;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.Repositories
{
    public class RecipeRepository : TrackingRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(MyRecipeDbContext context) : base(context) {}

        public Recipe CreateRecipe(RecipeModel recipeModel)
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
                    Quantity = recipeIngredient.Quantity
                });
            }

            _context.Add(recipe);

            return recipe;
        }
    }
}
