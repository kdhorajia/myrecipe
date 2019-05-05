using System.Collections.Generic;

namespace MyRecipe.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string AuthorName { get; set; }

        public List<RecipeIngredientModel> RecipeIngredients { get; set; }
        public List<RecipeImageModel> RecipeImages { get; set; }
    }
    public class RecipeIngredientModel
    {
        public int RecipeIngredientId { get; set; }
        public int? IngredientId { get; set; }
        public int RecipeId { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Preparation { get; set; }
        public string IngredientName { get; set; }

        public IngredientModel Ingredient { get; set; }
    }

    public class RecipeImageModel
    {
        public string RecipeImageId { get; set; }

        public int RecipeId { get; set; }

        public string ImagePath { get; set; }
    }
}
