using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCProject.Models
{
    public class ProductRepository
    {
        // Class that generetes a list of products
        public static List<ProductResult> GetProducts()
        {
            return new List<ProductResult>()
            {
                new ProductResult { ProductID = 1989, ProductName = "Fusca Car"},
                new ProductResult { ProductID = 1990, ProductName = "Corvete Car"}
            };
        }
    }

    // Class that represent products
    public class ProductResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
