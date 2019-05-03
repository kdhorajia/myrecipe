using AutoMapper;
using MyRecipe.Models;
using MyRecipe.Models.Entities;

namespace MyRecipe.Core.Mapper
{
    public class RecipeMapper : Profile
    {
        public RecipeMapper()
        {
            CreateMap<Recipe, RecipeModel>()
                 .ForMember(c => c.RecipeId, o => o.MapFrom(m => m.Id))
                 .ReverseMap();

            CreateMap<RecipeIngredient, RecipeIngredientModel>()
                 .ForMember(c => c.RecipeIngredientId, o => o.MapFrom(m => m.Id))
                 .ReverseMap();
        }
    }
}
