using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Data.EntityConfiguration
{
    public class RecipeEntityConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecipeId");

            builder.Property(c => c.Name).HasColumnType("varchar(50)");
            builder.Property(c => c.Description).HasColumnType("varchar(100)");
            builder.Property(c => c.Instruction).HasColumnType("varchar(max)");

            builder.HasOne(d => d.Customer)
              .WithMany(p => p.Recipe)
              .HasForeignKey(d => d.CustomerId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_Recipe_Customer");

            builder.HasOne(d => d.Category)
               .WithMany(p => p.Recipe)
               .HasForeignKey(d => d.CategoryId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_Recipe_Category");

            builder.ToTable("Recipe");
        }
    }
}
