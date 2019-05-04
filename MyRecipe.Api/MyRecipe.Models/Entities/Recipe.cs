using System.Collections.Generic;

namespace MyRecipe.Models.Entities
{
    public partial class Recipe : TrackedEntity
    {
        public Recipe()
        {
            RecipeIngredient = new HashSet<RecipeIngredient>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public bool IsPrivate { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredient { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Category Category { get; set; }

    }
}
