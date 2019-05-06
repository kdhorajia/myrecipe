using Microsoft.EntityFrameworkCore;
using MyRecipe.Common;
using MyRecipe.Models.Entities;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public class IngredientRepository : TrackingRepository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(MyRecipeDbContext context, IPrincipalUser principalUser) : base(context, principalUser)
        {
        }

        public async Task<Ingredient> AddIngredient(string ingredientName)
        {
            var ingredient = await _context.Set<Ingredient>().FirstOrDefaultAsync(a => a.Name.Equals(ingredientName, System.StringComparison.InvariantCultureIgnoreCase));

            if(ingredient != null)
            {
                return ingredient;
            }

            ingredient = new Ingredient() { Name = ingredientName };
            this.Add(ingredient);
            return ingredient;
        }
    }
}
