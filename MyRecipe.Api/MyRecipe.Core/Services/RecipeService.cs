using MyRecipe.Data;
using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly MyRecipeDbContext _context;

        public RecipeService(IRepository<Category> categoryRepository, MyRecipeDbContext context)
        {
            _categoryRepository = categoryRepository;
            _context = context;
        }

        public Task<RecipeModel> CreateRecipe()
        {
            
        }

        public async Task<IList<Category>> GetCategories()
        {
            return await _categoryRepository.GetAll();
        }
    }
}
