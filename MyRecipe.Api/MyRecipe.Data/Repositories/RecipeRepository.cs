using Microsoft.EntityFrameworkCore;
using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public class RecipeRepository : TrackingRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(MyRecipeDbContext context) : base(context) { }

        public Recipe AddRecipe(Recipe recipe)
        {
            this.Add(recipe);
            return recipe;
        }

        public async Task<Tuple<IList<Recipe>, int>> GetRecipes(string recipeName, int startRecordNumber, int pageSize, string orderBy)
        {
            IQueryable<Recipe> query = _context.Set<Recipe>().Where(o => !o.Deleted && o.Name.ToLowerInvariant().Contains(recipeName.ToLowerInvariant()))
                .Include(o => o.Customer)
                .Include(o => o.RecipeIngredient)
                .Include(o => o.RecipeImage)
                .Include("RecipeIngredient.Ingredient");

            query = !string.IsNullOrEmpty(orderBy)
               ? query.OrderBy(orderBy)
               : query.OrderBy(a => a.Name);

            int total = await query.CountAsync();

            if (startRecordNumber > 0)
            {
                query = query.Skip<Recipe>(startRecordNumber);
            }

            if (pageSize > 0)
            {
                query = query.Take<Recipe>(pageSize);
            }

            List<Recipe> result = await query.ToListAsync();

            return new Tuple<IList<Recipe>, int>(result, total);
        }
    }
}
