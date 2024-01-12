using System.Text;
using System.Threading.Tasks;
using LInqFundamentals.Common;
using LINQFundamentals.Common.HelperClasses;
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

        public List<string> GetNameFromProducts()
        {
            List<Product> products = GetProducts();
            List<string> productNames = new();

            // ProductNames.AddRange(from prod in products select prod.Name);

            productNames.AddRange(products.Select(prod => prod.Name));

            return productNames;
        }

        public List<Product> GetSpecificColumnNames()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            list = (from prod in products
                    select new Product
                    {
                        ProductID = prod.ProductID,
                        Name = prod.Name,
                        Color = prod.Color
                    }).ToList();

            list = products.Select(prod => new Product
            {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color
            }).ToList();

            return list;
        }

        public string GetColumnWithAnonymousClass()
        {
            List<Product> products = GetProducts();
            StringBuilder sb = new(2048);

            // var list = (from prod in products select new {
            //      ProductID = prod.ProductID,
            //     Name = prod.Name,
            //     Color = prod.Color
            // }).ToList();

            var list = products.Select(prod => new
            {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color
            }).ToList();

            foreach (var lst in list)
            {
                sb.AppendLine($"Product Id : {lst.ProductID}");
                sb.AppendLine($"Name : {lst.Name}");
                sb.AppendLine($"Color : {lst.Color}");
            }
            return sb.ToString();
        }

        public List<Product> GetProductsInOrder()
        {
            var products = GetProducts();

            var sortedProducts = products.OrderBy(p => p.Color).ThenBy(p => p.Name).ToList();

            return sortedProducts;
        }

        public List<Product> WhereExtensionByColor()
        {
            var products = GetProducts();

            var filteredByColor = products.ByColor("Red").ToList();
            return filteredByColor;
        }

    }

}