﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyRecipe.Data;

namespace MyRecipe.Data.Migrations
{
    [DbContext(typeof(MyRecipeDbContext))]
    partial class MyRecipeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyRecipe.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IngredientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecipeId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("CookingTime")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<int>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Instruction")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PreparationTime")
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Name")
                        .HasName("IDX_Recipe_Name");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.RecipeImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecipeImageId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<string>("ImagePath")
                        .HasColumnType("varchar(300)");

                    b.Property<int>("RecipeId");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeImage");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RecipeIngredientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<int>("IngredientId");

                    b.Property<string>("Preparation")
                        .HasColumnType("varchar(500)");

                    b.Property<double?>("Quantity");

                    b.Property<int>("RecipeId");

                    b.Property<string>("Unit")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredient");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.ShoppingIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShoppingIngredientId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<bool>("Deleted");

                    b.Property<int>("IngredientId");

                    b.Property<double>("Quantity");

                    b.Property<int>("ShoppingListId");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingListId");

                    b.ToTable("ShoppingIngredient");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.ShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShoppingListId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CartDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<int>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CreatedUser");

                    b.Property<int>("CustomerId");

                    b.Property<bool>("Deleted");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("UpdatedUser");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.Recipe", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.Category", "Category")
                        .WithMany("Recipe")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Recipe_Category")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyRecipe.Models.Entities.Customer", "Customer")
                        .WithMany("Recipe")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Recipe_Customer")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.RecipeImage", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.Recipe", "Recipe")
                        .WithMany("RecipeImage")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyRecipe.Models.Entities.Recipe", "Recipe")
                        .WithMany("RecipeIngredient")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.ShoppingIngredient", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.ShoppingList", "ShoppingList")
                        .WithMany("ShoppingIngredient")
                        .HasForeignKey("ShoppingListId")
                        .HasConstraintName("FK_Shopping_Ingredient")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.ShoppingList", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.Customer", "Customer")
                        .WithMany("ShoppingList")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_ShoppingList_Customer")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyRecipe.Models.Entities.User", b =>
                {
                    b.HasOne("MyRecipe.Models.Entities.Customer", "Customer")
                        .WithOne("User")
                        .HasForeignKey("MyRecipe.Models.Entities.User", "CustomerId")
                        .HasConstraintName("FK_User_Customer")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
