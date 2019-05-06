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
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;

        public RecipeService(IRepository<Category> categoryRepository,
                    IIngredientRepository ingredientRepository,
                    IRecipeRepository recipeRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _ingredientRepository = ingredientRepository;
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public async Task<RecipeModel> AddRecipe(RecipeModel recipeModel)
        {
            foreach(var recipeIngredient in recipeModel.RecipeIngredients)
            {
                if(!recipeIngredient.IngredientId.HasValue)
                {
                    recipeIngredient.Ingredient = _mapper.Map<IngredientModel>(await _ingredientRepository.AddIngredient(recipeIngredient.IngredientName));
                } else
                {
                    recipeIngredient.Ingredient = _mapper.Map<IngredientModel>(await _ingredientRepository.GetByID(recipeIngredient.IngredientId.Value));
                }
            }
            
            Recipe recipe = _mapper.Map<Recipe>(recipeModel);
            var result = _recipeRepository.AddRecipe(recipe);
            await _recipeRepository.SaveChanges();
            await EnrichedRecipeInfo(result);
            return _mapper.Map<RecipeModel>(result);
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

        public async Task<ResultOutputData<IList<RecipeModel>>> GetRecipes(string recipeName, int startRecordNumber, int pageSize, string orderBy)
        {
            var data = await _recipeRepository.GetRecipes(recipeName, startRecordNumber, pageSize, orderBy);
            var result = new ResultOutputData<IList<RecipeModel>>();

            var list = _mapper.Map<RecipeModel[]>(data.Item1);
            foreach(var recipe in list)
            {
                recipe.AuthorName = $"{recipe.Customer.FirstName} {recipe.Customer.LastName}";

                if(recipe.RecipeImages.Any()) {
                    recipe.ImageUrl = recipe.RecipeImages[0].ImagePath;
                }
            }


            result.ResultSet = list;
            result.TotalCount = data.Item2;
            return result;
        }
    }
}
