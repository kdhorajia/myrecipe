using Microsoft.EntityFrameworkCore;
using MyRecipe.Data.EntityConfiguration;
using MyRecipe.Models;

namespace MyRecipe.Data
{
    public partial class MyRecipeDbContext : DbContext
    {
        public MyRecipeDbContext(DbContextOptions<MyRecipeDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeIngredientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingListEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ShoppingIngredientEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ShoppingList> ShoppingList { get; set; }
        public virtual DbSet<ShoppingIngredient> ShoppingIngredient { get; set; }

    }
}
