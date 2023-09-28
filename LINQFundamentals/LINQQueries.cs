using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LInqFundamentals.Common;
using LINQFundamentals.DataLayer.EntityClasses;

namespace LINQFundamentals
{
    public class LINQQueries : InventoryBase
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = GetProducts();

            // Query syntax

          //  var productsList = (from prod in products select prod).ToList();

            // Method syntax

            var productsList = products.Select(x => x).ToList();

            return productsList;
        }

    }
}