using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Models
{
    public partial class Ingredient : TrackedEntity
    {
        public string Name { get; set; }

        public string Unit { get; set; }
    }
}
