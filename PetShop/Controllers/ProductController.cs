using Microsoft.AspNetCore.Mvc;
using PetShop.Models;
using PetShop.ViewModels;

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
        public IActionResult List()
        {
            ProductListViewModel productsListViewModel = new ProductListViewModel();
            productsListViewModel.Products = _productRepository.AllProducts;
            productsListViewModel.CurrentCategory = "Juguetes";
            return View(productsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
