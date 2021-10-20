using FirstMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCProject.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<ProductResult> productsResult = ProductRepository.GetProducts();

            return View(productsResult);
        }
    }
}
