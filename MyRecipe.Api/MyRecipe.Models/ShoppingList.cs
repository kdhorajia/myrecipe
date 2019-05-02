using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models
{
    public partial class ShoppingList : TrackedEntity   
    {
        public DateTime CartDate { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }

    }
}
