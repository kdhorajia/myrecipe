using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyRecipe.Data.EntityConfiguration
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id)
                  .ValueGeneratedOnAdd()
                  .HasColumnName("UserId");

            builder.HasIndex(x => x.Id);

            builder.Property(c => c.UserName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.PasswordHash).HasColumnType("varchar(50)").IsRequired();

            builder.HasOne(d => d.Customer)
               .WithOne(p => p.User)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_User_Customer");

            builder.Property(c => c.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(c => c.UpdatedDate).HasDefaultValueSql("getdate()");


            builder.ToTable("User");

        }
    }
}
