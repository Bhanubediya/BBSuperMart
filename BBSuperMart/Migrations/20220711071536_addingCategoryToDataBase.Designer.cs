﻿// <auto-generated />

using BBSuperMart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BBMartUtility.Migrations
{
    [DbContext(typeof(BBSuperMarketDbContext))]
    [Migration("20220711071536_addingCategoryToDataBase")]
    partial class addingCategoryToDataBase
    {
        protected  void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BBSuperMart.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.HasKey("CatId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BBSuperMart.Models.products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("addToWishlist")
                        .HasColumnType("bit");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
