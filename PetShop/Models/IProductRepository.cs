using System.Collections.Generic;

namespace PetShop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductOfTheWeek { get; }

        Product GetProductById(int productId);
    }
}