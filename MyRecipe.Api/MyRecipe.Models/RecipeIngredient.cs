using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models
{
    public partial class RecipeIngredient : TrackedEntity   
    {
        public int RecipeId { get; set; }

        public int IngredientId { get; set; }

        public double Quantity { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual Ingredient Ingredient { get; set; }

    }
}
