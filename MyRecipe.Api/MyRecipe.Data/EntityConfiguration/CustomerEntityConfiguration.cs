﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyRecipe.Models.Entities;

namespace MyRecipe.Data.EntityConfiguration
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustomerId");

            builder.HasIndex(x => x.Id);

            builder.Property(c => c.FirstName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.LastName).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("varchar(50)").IsRequired();

            builder.Property(c => c.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(c => c.UpdatedDate).HasDefaultValueSql("getdate()");



            builder.ToTable("Customer");
        }
    }
}
