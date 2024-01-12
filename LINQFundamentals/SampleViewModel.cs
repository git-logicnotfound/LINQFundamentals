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
    }
}