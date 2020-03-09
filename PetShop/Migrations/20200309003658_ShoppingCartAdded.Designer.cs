﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Models;

namespace PetShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200309003658_ShoppingCartAdded")]
    partial class ShoppingCartAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Juguetes",
                            Description = "Juguetes de calidad"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Alimentos",
                            Description = "Alimentos balanceados y naturales"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Higiene",
                            Description = "Herramientas y elementos para la higiene"
                        });
                });

            modelBuilder.Entity("PetShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRgzIOL4ueIyo8r35aLoRL3DsaXmIKqROCb-gKgIVOe0L1pH-GL",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Hueso de goma",
                            Price = 9.99m,
                            ShortDescription = "Hueso de color azul"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images.rappi.com.ar/products/760690-1572537379304.png?d=200x200&e=webp",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Nutrique Puppy Cat",
                            Price = 29.99m,
                            ShortDescription = "Alimento para gatos de 3 a 12 meses de edad"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091010906/cc99a8f0b6e235e4ca9cf3bf9c541aca_large.png&width=256&type=webp&quality=40",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Shampo Gold Cat",
                            Price = 19.99m,
                            ShortDescription = "Shampo para gatos adultos"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://statics.glamit.com.ar/media/catalog/product/cache/82/base/256x256/9df78eab33525d08d6e5fb8d27136e95/g/y/gym-ball-goma-anti-burst-55-cm-dgpzez005.jpg",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            Name = "Pelota de goma",
                            Price = 4.99m,
                            ShortDescription = "Pelota de color verde"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://theurbanpetstore-static.myshopblocks.com/images/2019/08/contain/256x256/691d9f0068ebb61d3107b8b63f8e1076.jpg",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Kong Classic rojo",
                            Price = 19.99m,
                            ShortDescription = "Juguete de color rojo"
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images.rappi.com.ar/products/214314-1534290373.png?d=200x200",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Pro Plan Puppy",
                            Price = 29.99m,
                            ShortDescription = "Alimento Balanceado para perros 3 kg"
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images.rappi.com.ar/products/213935-1534290225.png?d=200x200&e=webp",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            Name = "Eukanuba Puppy",
                            Price = 24.99m,
                            ShortDescription = "Alimento Balanceado para perros 2.5 kg"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://images.rappi.com.ar/products/240563-1553536225050.png?d=200x200",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            Name = "Pedigree Adult",
                            Price = 14.99m,
                            ShortDescription = "Alimento Balanceado para perros 1.5 kg"
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://microless.com/cdn/products/a8faa5fc1a2d29021dbae96a0c34945d-hi.jpg",
                            InStock = true,
                            IsProductOfTheWeek = true,
                            Name = "Paw Puppy Gentle Shampoo",
                            Price = 19.99m,
                            ShortDescription = "Shampo para perros"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091028758/53849faf897b870d061e688b67052cdc_large.png&width=256&type=webp&quality=40",
                            InStock = true,
                            IsProductOfTheWeek = false,
                            Name = "Toy Breed Shampo",
                            Price = 19.99m,
                            ShortDescription = "Shampo para perros mata pulgas"
                        });
                });

            modelBuilder.Entity("PetShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("PetShop.Models.Product", b =>
                {
                    b.HasOne("PetShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("PetShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
