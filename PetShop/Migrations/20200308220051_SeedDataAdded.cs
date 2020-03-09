using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Juguetes", "Juguetes de calidad" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Alimentos", "Alimentos balanceados y naturales" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Higiene", "Herramientas y elementos para la higiene" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsProductOfTheWeek", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRgzIOL4ueIyo8r35aLoRL3DsaXmIKqROCb-gKgIVOe0L1pH-GL", null, true, true, "Hueso de goma", 9.99m, "Hueso de color azul" },
                    { 4, 1, "https://statics.glamit.com.ar/media/catalog/product/cache/82/base/256x256/9df78eab33525d08d6e5fb8d27136e95/g/y/gym-ball-goma-anti-burst-55-cm-dgpzez005.jpg", null, true, false, "Pelota de goma", 4.99m, "Pelota de color verde" },
                    { 5, 1, "https://theurbanpetstore-static.myshopblocks.com/images/2019/08/contain/256x256/691d9f0068ebb61d3107b8b63f8e1076.jpg", null, true, true, "Kong Classic rojo", 19.99m, "Juguete de color rojo" },
                    { 2, 2, "https://images.rappi.com.ar/products/760690-1572537379304.png?d=200x200&e=webp", null, true, true, "Nutrique Puppy Cat", 29.99m, "Alimento para gatos de 3 a 12 meses de edad" },
                    { 6, 2, "https://images.rappi.com.ar/products/214314-1534290373.png?d=200x200", null, true, true, "Pro Plan Puppy", 29.99m, "Alimento Balanceado para perros 3 kg" },
                    { 7, 2, "https://images.rappi.com.ar/products/213935-1534290225.png?d=200x200&e=webp", null, true, false, "Eukanuba Puppy", 24.99m, "Alimento Balanceado para perros 2.5 kg" },
                    { 8, 2, "https://images.rappi.com.ar/products/240563-1553536225050.png?d=200x200", null, true, false, "Pedigree Adult", 14.99m, "Alimento Balanceado para perros 1.5 kg" },
                    { 3, 3, "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091010906/cc99a8f0b6e235e4ca9cf3bf9c541aca_large.png&width=256&type=webp&quality=40", null, true, true, "Shampo Gold Cat", 19.99m, "Shampo para gatos adultos" },
                    { 9, 3, "https://microless.com/cdn/products/a8faa5fc1a2d29021dbae96a0c34945d-hi.jpg", null, true, true, "Paw Puppy Gentle Shampoo", 19.99m, "Shampo para perros" },
                    { 10, 3, "https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091028758/53849faf897b870d061e688b67052cdc_large.png&width=256&type=webp&quality=40", null, true, false, "Toy Breed Shampo", 19.99m, "Shampo para perros mata pulgas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
