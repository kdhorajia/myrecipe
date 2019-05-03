using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models;

namespace MyRecipe.Data.EntityConfiguration
{
    public class ShoppingListEntityConfiguration : IEntityTypeConfiguration<ShoppingList>
    {
        public void Configure(EntityTypeBuilder<ShoppingList> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ShoppingListId");

            builder.Property(e => e.CartDate)
                  .HasColumnType("datetime")
                  .HasDefaultValueSql("getdate()");

            builder.Property(c => c.Name).HasColumnType("varchar(50)");

            builder.HasOne(d => d.Customer)
              .WithMany(p => p.ShoppingList)
              .HasForeignKey(d => d.CustomerId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_ShoppingList_Customer");

            builder.ToTable("ShoppingList");
        }
    }
}
