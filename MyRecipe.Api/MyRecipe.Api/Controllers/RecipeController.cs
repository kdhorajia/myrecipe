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
        public async Task<IList<Category>> GetCategories()
        {
            IList<Category> result = await _recipeService.GetCategories();
            return result;
        }

        [HttpPost]
        public async Task<RecipeModel> AddRecipe([FromBody] RecipeModel model)
        {
            var result = await _recipeService.AddRecipe(model);
            return result;
        }
    }
}
