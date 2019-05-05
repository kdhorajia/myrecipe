namespace MyRecipe.Models.Entities
{
    public partial class RecipeImage : TrackedEntity
    {
        public string ImagePath { get; set; }
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
