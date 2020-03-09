using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        //public IActionResult List()
        //{
        //    ProductListViewModel productsListViewModel = new ProductListViewModel();
        //    productsListViewModel.Products = _productRepository.AllProducts;
        //    productsListViewModel.CurrentCategory = "Juguetes";
        //    return View(productsListViewModel);
        //}

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if(string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category).OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            
            }
            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
    }
}
