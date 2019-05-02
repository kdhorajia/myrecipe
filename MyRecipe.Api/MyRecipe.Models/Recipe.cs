namespace MyRecipe.Models
{
    public partial class Recipe : TrackedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instruction { get; set; }

        public int CustomerId { get; set; }
        public int CategoryId { get; set; }

    }
}
