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
                 .ForMember(c => c.RecipeImages, o => o.MapFrom(m => m.RecipeImage))
                 .ForMember(c => c.CategoryName, o => o.MapFrom(m => m.Category.Name))
                 .ReverseMap();

            CreateMap<RecipeIngredient, RecipeIngredientModel>()
                 .ForMember(c => c.RecipeIngredientId, o => o.MapFrom(m => m.Id))
                 .ForMember(c => c.RecipeId, o => o.MapFrom(m => m.RecipeId))
                 .ForMember(c => c.Ingredient, o => o.MapFrom(m => m.Ingredient))
                 .ReverseMap();

            CreateMap<RecipeImage, RecipeImageModel>()
                 .ForMember(c => c.RecipeImageId, o => o.MapFrom(m => m.Id))
                 .ForMember(c => c.RecipeId, o => o.MapFrom(m => m.RecipeId))
                 .ReverseMap();

            CreateMap<Ingredient, IngredientModel>()
                 .ForMember(c => c.IngredientId, o => o.MapFrom(m => m.Id))
                 .ForMember(c => c.IngredientName, o => o.MapFrom(m => m.Name))
                 .ReverseMap();

            CreateMap<Category, CategoryModel>()
                .ForMember(c => c.CategoryId, o => o.MapFrom(m => m.Id))
                .ForMember(c => c.CategoryName, o => o.MapFrom(m => m.Name))
                .ForMember(c => c.CategoryDescription, o => o.MapFrom(m => m.Description))
                .ReverseMap();
        }
    }
}
