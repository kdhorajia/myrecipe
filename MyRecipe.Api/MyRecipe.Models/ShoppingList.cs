using System;
using System.Collections.Generic;

namespace MyRecipe.Models
{
    public partial class ShoppingList : TrackedEntity
    {
        public ShoppingList()
        {
            ShoppingIngredient = new HashSet<ShoppingIngredient>();
        }

        public DateTime CartDate { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

        public virtual ICollection<ShoppingIngredient> ShoppingIngredient { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
