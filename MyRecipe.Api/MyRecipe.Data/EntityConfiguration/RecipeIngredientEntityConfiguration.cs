using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models;
using System;

namespace MyRecipe.Data.EntityConfiguration
{
    public class RecipeIngredientEntityConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecipeIngredientId");

            builder.Property(c => c.Quantity).IsRequired();
        
            builder.ToTable("RecipeIngredient");
        }
    }
}
