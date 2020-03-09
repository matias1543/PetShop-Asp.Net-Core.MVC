using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
    new List<Category>
    {
                new Category{CategoryId=1, CategoryName="Juguetes", Description="Juguetes de calidad"},
                new Category{CategoryId=2, CategoryName="Alimentos", Description="Alimentos balanceados y naturales"},
                new Category{CategoryId=3, CategoryName="Higiene", Description="Herramientas y elementos para la higiene"}
    };
    }
}
