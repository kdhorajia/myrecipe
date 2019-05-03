using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Data.EntityConfiguration
{
    public class ShoppingIngredientEntityConfiguration : IEntityTypeConfiguration<ShoppingIngredient>
    {
        public void Configure(EntityTypeBuilder<ShoppingIngredient> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ShoppingIngredientId");

            builder.Property(c => c.Quantity).IsRequired();

            builder.HasOne(d => d.ShoppingList)
                .WithMany(p => p.ShoppingIngredient)
                .HasForeignKey(d => d.ShoppingListId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Shopping_Ingredient");

            builder.ToTable("ShoppingIngredient");
        }
    }
}
