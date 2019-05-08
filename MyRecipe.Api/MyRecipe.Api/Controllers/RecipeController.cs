using Microsoft.AspNetCore.Mvc;
using MyRecipe.Core;
using MyRecipe.Models;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyRecipe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }


        [HttpGet]
        [Route("categories")]
        public async Task<IList<CategoryModel>> GetCategories()
        {
            IList<CategoryModel> result = await _recipeService.GetCategories();
            return result;
        }

        [HttpGet]
        [Route("ingredients")]
        public async Task<IList<IngredientModel>> GetIngredients()
        {
            IList<IngredientModel> result = await _recipeService.GetIngredients();
            return result;
        }

        [HttpPost]
        public async Task<RecipeModel> AddRecipe([FromBody] RecipeModel model)
        {
            var result = await _recipeService.AddRecipe(model);
            return result;
        }

        [HttpGet]
        public async Task<ResultOutputData<IList<RecipeModel>>> GetRecipes(string recipeName = "", int startRecordNumber = 0, int pageSize = 10, string orderBy = "")
        {
            recipeName = recipeName == null ? string.Empty : recipeName;
            var result = await _recipeService.GetRecipes(recipeName, startRecordNumber, pageSize, orderBy);
            return result;
        }


        [Route("test"), HttpGet]
        public async Task<string> Test(string recipeName = "", int startRecordNumber = 0, int pageSize = 10, string orderBy = "")
        {

            return "This is test";
        }

    }
}
