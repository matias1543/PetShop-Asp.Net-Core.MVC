using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product { ProductId = 1, Name = "Hueso de goma", Price=9.99M, ShortDescription="Hueso indestructible de color azul", Category= _categoryRepository.AllCategories.ToList()[0], InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRgzIOL4ueIyo8r35aLoRL3DsaXmIKqROCb-gKgIVOe0L1pH-GL"},
                new Product { ProductId = 2, Name = "Nutrique Puppy Cat", Price=29.99M, ShortDescription="Alimento para gatos de 3 a 12 meses de edad", Category= _categoryRepository.AllCategories.ToList()[1], InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://images.rappi.com.ar/products/760690-1572537379304.png?d=200x200&e=webp"},
               new Product { ProductId = 3, Name = "Shampo Gold Cat", Price=19.99M, ShortDescription="Shampo para gatos adultos", Category= _categoryRepository.AllCategories.ToList()[2], InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="https://ipcdn.freshop.com/resize?url=https://images.freshop.com/00073091010906/cc99a8f0b6e235e4ca9cf3bf9c541aca_large.png&width=256&type=webp&quality=40"},
            };

        public IEnumerable<Product> ProductOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
