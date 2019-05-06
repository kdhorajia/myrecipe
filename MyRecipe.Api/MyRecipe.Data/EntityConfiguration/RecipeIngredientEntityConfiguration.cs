using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;
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

            builder.Property(c => c.Unit).HasColumnType("varchar(100)");
            builder.Property(c => c.Preparation).HasColumnType("varchar(500)");

            builder.Property(c => c.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(c => c.UpdatedDate).HasDefaultValueSql("getdate()");


            builder.ToTable("RecipeIngredient");
        }
    }
}
