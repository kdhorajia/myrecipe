using AutoMapper;
using MyRecipe.Data;
using MyRecipe.Data.Repositories;
using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;

        public RecipeService(IRepository<Category> categoryRepository, IRecipeRepository recipeRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<RecipeModel> AddRecipe(RecipeModel recipeModel)
        {
            var model = _recipeRepository.AddRecipe(recipeModel);
            await _recipeRepository.SaveChanges();
            return _mapper.Map<RecipeModel>(model);
        }

        public async Task<IList<Category>> GetCategories()
        {
            return await _categoryRepository.GetAll();
        }
    }
}
