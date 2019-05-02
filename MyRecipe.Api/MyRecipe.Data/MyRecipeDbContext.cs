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

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Category> Category { get; set; }
    }
}
