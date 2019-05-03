using System.Collections.Generic;

namespace MyRecipe.Models.Entities
{
    public partial class Category : TrackedEntity
    {
        public Category()
        {
            Recipe = new HashSet<Recipe>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Recipe> Recipe { get; set; }
    }
}
