using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LInqFundamentals.Common;
using LINQFundamentals.DataLayer.EntityClasses;

namespace LINQFundamentals
{
    public class SampleViewModel : InventoryBase
    {
        
        public Product GetFirstOrDefaultProduct()
        {
            var products = GetProducts();

            var result = products.FirstOrDefault(x => x.Color == "Reed",new Product());

            return result;
        }

        public Product GetFirstQueryWithException()
        {
            var products = GetProducts();

            var result = products.First(x => x.Color == "PinkRose");

            return result;
        }

        public List<Product> TakeQuery()
        {
             List<Product> productsResult = new();
            var products = GetProducts();
            // take first 5 products

            productsResult = products.Take(5).ToList();

            //take list of product from 4 to 8

            productsResult = products.Take(3..8).ToList();

            // take list of product from 8

          //  productsResult = products.Take(8..).ToList();

// take last 6 records but skip the last 2 records
         productsResult = products.Take(^6..^2).ToList();

         // take last 5 records

         productsResult = products.Take(^5..).ToList();

            return productsResult;
        
        }
        
        /// <summary>
        /// skips first 10 records and retrivies remaining records
        /// </summary>
        /// <returns></returns>
        public List<Product> SkipData()
        {
             List<Product> productsResult = new();
            var products = GetProducts();

             productsResult = products.Skip(10).ToList();
            return productsResult;
        }
    }
}