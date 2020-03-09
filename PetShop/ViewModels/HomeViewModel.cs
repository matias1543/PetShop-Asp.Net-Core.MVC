using PetShop.Models;
using System.Collections.Generic;

namespace PetShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> ProductsOfTheWeek { get; set; }
    }
}
