using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.EntityConfiguration
{
    public class IngredientEntityConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("IngredientId");

            builder.Property(c => c.Name).HasColumnType("varchar(200)");
           
            builder.ToTable("Ingredient");
        }
    }
}
