using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQFundamentals.DataLayer.EntityClasses;

namespace LINQFundamentals.Common.HelperClasses
{
    public static class LINQExtensions
    {
        public static IEnumerable<Product> ByColor(this IEnumerable<Product> products, string color)
        {
            return products.Where(product => product.Color == color);    
        }
    }
}