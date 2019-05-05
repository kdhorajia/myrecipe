using MyRecipe.Models.Entities;
using System.Threading.Tasks;

namespace MyRecipe.Data.Repositories
{
    public interface IIngredientRepository : ITrackingRepository<Ingredient>
    {
        Task<Ingredient> AddIngredient(string ingredientName);
    }
}
