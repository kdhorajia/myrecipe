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
        private readonly IRepository<Ingredient> _ingredientRepository;
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;

        public RecipeService(IRepository<Category> categoryRepository,
                    IRepository<Ingredient> ingredientRepository,
                    IRecipeRepository recipeRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _ingredientRepository = ingredientRepository;
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<RecipeModel> AddRecipe(RecipeModel recipeModel)
        {
            var recipe = _recipeRepository.AddRecipe(recipeModel);
            await _recipeRepository.SaveChanges();

            await EnrichedRecipeInfo(recipe);
            return _mapper.Map<RecipeModel>(recipe);
        }

        private async Task EnrichedRecipeInfo(Recipe recipe)
        {
            recipe.Category = await _categoryRepository.GetByID(recipe.CategoryId);
            foreach (var recIng in recipe.RecipeIngredient)
            {
                recIng.Ingredient = await _ingredientRepository.GetByID(recIng.IngredientId);
            }
        }

        public async Task<IList<CategoryModel>> GetCategories()
        {
            var result = await _categoryRepository.GetAll();
            return _mapper.Map<CategoryModel[]>(result);
        }

        public async Task<IList<IngredientModel>> GetIngredients()
        {
            var result = await _ingredientRepository.GetAll();
            return _mapper.Map<IngredientModel[]>(result);
        }

        public async Task<IList<RecipeModel>> GetRecipes(string recipeName)
        {
            var result = await _recipeRepository.GetRecipes(recipeName);
            return _mapper.Map<RecipeModel[]>(result); ;
        }
    }
}
