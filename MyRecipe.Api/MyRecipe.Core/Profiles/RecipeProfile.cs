using AutoMapper;
using MyRecipe.Models;
using MyRecipe.Models.Entities;

namespace MyRecipe.Core.Profiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            CreateMap<Recipe, RecipeModel>()
                 .ForMember(c => c.RecipeId, o => o.MapFrom(m => m.Id))
                 .ForMember(c => c.RecipeIngredients, o => o.MapFrom(m => m.RecipeIngredient))
                 .ReverseMap();

            CreateMap<RecipeIngredient, RecipeIngredientModel>()
                 .ForMember(c => c.RecipeIngredientId, o => o.MapFrom(m => m.Id))
                 .ReverseMap();
        }
    }
}
