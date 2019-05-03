using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models.Entities
{
    public partial class ShoppingIngredient : TrackedEntity
    {
        public int ShoppingListId { get; set; }
        public int IngredientId { get; set; }
        public double Quantity { get; set; }
        public virtual ShoppingList ShoppingList { get; set; }

    }
}
