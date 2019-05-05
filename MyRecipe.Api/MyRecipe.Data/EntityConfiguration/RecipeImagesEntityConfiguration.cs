using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.EntityConfiguration
{
    public class RecipeImagesEntityConfiguration : IEntityTypeConfiguration<RecipeImage>
    {
        public void Configure(EntityTypeBuilder<RecipeImage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecipeImageId");

            builder.Property(c => c.ImagePath).HasColumnType("varchar(300)");

        }
    }
}
