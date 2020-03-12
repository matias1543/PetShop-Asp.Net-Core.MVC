


using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Juguetes", Description = "Juguetes de calidad" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Alimentos", Description = "Alimentos balanceados y naturales" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Higiene", Description = "Herramientas y elementos para la higiene" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Hueso de goma",
                Price = 9.99M,
                ShortDescription = "Hueso de color azul",
                CategoryId = 1,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRgzIOL4ueIyo8r35aLoRL3DsaXmIKqROCb-gKgIVOe0L1pH-GL"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Nutrique Puppy Cat",
                Price = 29.99M,
                ShortDescription = "Alimento para gatos de 3 a 12 meses de edad",
                CategoryId = 2,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://images.rappi.com.ar/products/760690-1572537379304.png?d=200x200&e=webp"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Shampo Gold Cat",
                Price = 19.99M,
                ShortDescription = "Shampo para gatos adultos",
                CategoryId = 3,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091010906/cc99a8f0b6e235e4ca9cf3bf9c541aca_large.png&width=256&type=webp&quality=40"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pelota de goma",
                Price = 4.99M,
                ShortDescription = "Pelota de color verde",
                CategoryId = 1,
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://statics.glamit.com.ar/media/catalog/product/cache/82/base/256x256/9df78eab33525d08d6e5fb8d27136e95/g/y/gym-ball-goma-anti-burst-55-cm-dgpzez005.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Kong Classic rojo",
                Price = 19.99M,
                ShortDescription = "Juguete de color rojo",
                CategoryId = 1,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://theurbanpetstore-static.myshopblocks.com/images/2019/08/contain/256x256/691d9f0068ebb61d3107b8b63f8e1076.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Pro Plan Puppy",
                Price = 29.99M,
                ShortDescription = "Alimento Balanceado para perros 3 kg",
                CategoryId = 2,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://images.rappi.com.ar/products/214314-1534290373.png?d=200x200"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Eukanuba Puppy",
                Price = 24.99M,
                ShortDescription = "Alimento Balanceado para perros 2.5 kg",
                CategoryId = 2,
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://images.rappi.com.ar/products/213935-1534290225.png?d=200x200&e=webp"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Pedigree Adult",
                Price = 14.99M,
                ShortDescription = "Alimento Balanceado para perros 1.5 kg",
                CategoryId = 2,
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://images.rappi.com.ar/products/240563-1553536225050.png?d=200x200"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Paw Puppy Gentle Shampoo",
                Price = 19.99M,
                ShortDescription = "Shampo para perros",
                CategoryId = 3,
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://microless.com/cdn/products/a8faa5fc1a2d29021dbae96a0c34945d-hi.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Toy Breed Shampo",
                Price = 19.99M,
                ShortDescription = "Shampo para perros mata pulgas",
                CategoryId = 3,
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091028758/53849faf897b870d061e688b67052cdc_large.png&width=256&type=webp&quality=40"
            });
        }
    }
}
