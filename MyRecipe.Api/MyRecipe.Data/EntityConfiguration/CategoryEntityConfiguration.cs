using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models;

namespace MyRecipe.Data.EntityConfiguration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("CategoryId");

            builder.Property(c => c.Name).HasColumnType("varchar(50)");
            builder.Property(c => c.Description).HasColumnType("varchar(100)");
        }
    }
}
